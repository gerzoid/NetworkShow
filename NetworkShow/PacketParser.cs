using NetworkShow.Network;
using NetworkShow.Network.Packets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NetworkShow
{
    public class PacketParser
    {
        //Поток
        public string incomingIP = "";

        Thread backgroundThread;
        private bool backgroundThreadStop = false;

        public delegate void ChangeRowsCount(PacketType protocol, int position, string portIn, string portOut);
        public event ChangeRowsCount ChangeRowsCountEvent;

        public delegate void UpdateInfo(string protocol);
        public event UpdateInfo UpdateInfoEvent;

        Database.Database db;

        static IList<PacketInfo> connections_ = new List<PacketInfo>();

        public PacketParser()
        {
            backgroundThread = new Thread(BackgrountWorker);
            backgroundThread.Start();
            db = new Database.Database();
        }
       
        public void ParseNetworkPacket(PacketRawInfo args)
        {
            IPHeader ipHeader = null;
            IPv6Header ipv6Header = null;
            EthernetHeader ethernetHeader = null;
            EthernetPacketType ethernetPackeType = EthernetPacketType.IpV4;

            PacketInfo packetInfo = new PacketInfo();
            packetInfo.protocolE = PacketType.UNKNOWN;
            packetInfo.count = 1;

            if (args.linkLayer == LinkLayers.Ethernet)
            {
                ethernetHeader = new EthernetHeader(args.data, args.size);

                ethernetPackeType = ethernetHeader.EtherType;
                packetInfo.hardwareSource = ethernetHeader.SourceMac;
                packetInfo.harwareDestination = ethernetHeader.DestinationMac;
                packetInfo.protocol = ((Protocol)ethernetHeader.EtherType).ToString();
                if (ethernetHeader.EtherType == EthernetPacketType.IpV4)
                {
                    args.data = ethernetHeader.Payload;
                    args.size = ethernetHeader.Payload.Length;
                }
            }
            else
            {
                packetInfo.protocol = Protocol.Iplt.ToString();                
            }
            switch (ethernetPackeType)
            {
                case EthernetPacketType.IpV4:
                    ipHeader = new IPHeader(args.data, args.size);
                    packetInfo.ipDestination = ipHeader.DestinationAddress.ToString();
                    packetInfo.ipSource = ipHeader.SourceAddress.ToString();
                    packetInfo.size = ipHeader.MessageLength;
                    if (packetInfo.ipSource == incomingIP)
                        packetInfo.incoming = true;
                    Statistics.AddToIPPacketsStats(packetInfo.size, packetInfo.incoming);
                    break;
                case EthernetPacketType.IpV6:
                    ipv6Header = new IPv6Header(args.data, args.size);
                    packetInfo.ipDestination = ipv6Header.DestinationAddress.ToString();
                    packetInfo.ipSource = ipv6Header.SourceAddress.ToString();
                    if (packetInfo.ipSource == incomingIP)
                        packetInfo.incoming = true;
                    Statistics.AddToIPPacketsStats(packetInfo.size, packetInfo.incoming);
                    break;
                case EthernetPacketType.Arp:
                    ARPHeader arpHeader = new ARPHeader(ethernetHeader.Payload, ethernetHeader.Payload.Length);
                    packetInfo.ipDestination = arpHeader.TPA;
                    packetInfo.ipSource = arpHeader.SPA;
                    packetInfo.desription = arpHeader.Description;
                    if (packetInfo.ipSource == incomingIP)
                        packetInfo.incoming = true;
                    packetInfo.size = arpHeader.Size;
                    packetInfo.protocol = "ARP";
                    packetInfo.protocolE = PacketType.ARP;
                    Statistics.AddToARPPacketsStats(packetInfo.size, packetInfo.incoming);
                    break;
                case EthernetPacketType.WakeOnLan:

                    break;
                default:
                    packetInfo.desription = "неизвестный Ethernet протокол";
                    break;
            }

            if (ipHeader != null)
            {
                switch (ipHeader.ProtocolType)
                {
                    case Protocol.Udp:
                        NetworkShow.Network.Packets.UDPHeader udpheader = new UDPHeader(ipHeader.Data, ipHeader.Data.Length);                        
                        packetInfo.portDestination = udpheader.DestinationPort;
                        packetInfo.portSource = udpheader.SourcePort;
                        packetInfo.size = udpheader.Length;
                        packetInfo.protocol = "UDP";
                        packetInfo.protocolE = PacketType.UDP;
                        packetInfo.active = "T";
                        Statistics.AddToUDPPacketsStats(packetInfo.size, packetInfo.incoming);
                        break;
                    case Protocol.Tcp:
                        NetworkShow.Network.Packets.TCPHeader tcpheader = new TCPHeader(ipHeader.Data, ipHeader.Data.Length);
                        packetInfo.portDestination = tcpheader.DestinationPort;
                        packetInfo.portSource = tcpheader.SourcePort;
                        packetInfo.size = tcpheader.MessageLength + tcpheader.HeaderLength;
                        packetInfo.active = "T";
                        packetInfo.protocol = "TCP";
                        packetInfo.protocolE = PacketType.TCP;
                        Statistics.AddToTCPPacketsStats(packetInfo.size, packetInfo.incoming);
                        break;
                    case Protocol.InternetControlMessageProtocol:
                        NetworkShow.Network.Packets.ICMPHeader icmpheader = new ICMPHeader(ipHeader.Data, ipHeader.Data.Length);
                        packetInfo.desription = icmpheader.Type.ToString();
                        packetInfo.size = icmpheader.Size;
                        packetInfo.protocol = "ICMP";
                        packetInfo.protocolE = PacketType.ICMP;
                        Statistics.AddToICMPPacketsStats(packetInfo.size, packetInfo.incoming);
                        break;
                    case Protocol.InternetGroupManagementProtocol:
                        NetworkShow.Network.Packets.IGMPHeader igmpheader = new IGMPHeader(ipHeader.Data, ipHeader.Data.Length);
                        packetInfo.desription = igmpheader.GroupAddress + " " + igmpheader.Type + " " + igmpheader.Version;
                        packetInfo.size = igmpheader.Size;
                        packetInfo.protocol = "IGMP";
                        packetInfo.protocolE = PacketType.IGMP;
                        Statistics.AddToIGMPPacketsStats(packetInfo.size, packetInfo.incoming);
                        break;
                    default:
                        packetInfo.desription = "неизвестный IP протокол";
                        packetInfo.protocol = ipHeader.ProtocolType.ToString();
                        packetInfo.protocolE = PacketType.UNKNOWN;
                        packetInfo.size = ipHeader.MessageLength;
                        break;
                }
            }
            //PacketsInfo.AddToQueue(packetInfo);
            int pos = -1;

            if ((packetInfo.protocol == "TCP") || (packetInfo.protocol == "UDP"))
            {
                //pos = FindConnection(packetInfo);
                pos = FindConnection(packetInfo);
                if (pos >= 0)
                {
                    packetInfo = UpdateConnection(pos, packetInfo);
                    UpdateInfoEvent(packetInfo.protocol);
                    db.UpdateConnection(packetInfo.pos, packetInfo);

                }
                else
                {
                    packetInfo.pos = db.SaveNewPacket(packetInfo);
                    AddConnection(packetInfo);
                    ChangeRowsCountEvent(packetInfo.protocolE, packetInfo.pos, packetInfo.portSource, packetInfo.portSource);
                }
            }
            else
            {
                int position = db.SaveNewPacket(packetInfo);
                ChangeRowsCountEvent(packetInfo.protocolE, position, packetInfo.portSource, packetInfo.portSource);
            }

        }

        public void UpdateActiveConnection()
        {
            PacketInfo cconnect = new PacketInfo();
            for (int x = 0; x <= connections_.Count - 1; x++)
            {
                cconnect = connections_[x];
                if (cconnect.protocol == "TCP")
                {
                    if ((DateTime.Now - cconnect.lastActiveTime).Minutes >= 4)
                    {
                        cconnect.active = "F";
                        RemoveConnection(x);

                    }
                }
                else
                    if (cconnect.protocol == "UDP")
                    {
                        if ((DateTime.Now - cconnect.lastActiveTime).Minutes >= 1)
                        {
                            cconnect.active = "F";
                            RemoveConnection(x);
                        }
                    }
                    else
                    {
                        cconnect.active = "F";
                        RemoveConnection(x);
                    }
                db.UpdateConnection(cconnect.pos, cconnect);
                UpdateInfoEvent(cconnect.protocol);
            }
        }

        public void BackgrountWorker()
        {
            while (!backgroundThreadStop)
            {
                bool shouldSleep = true;

                lock (PacketsInfo.QueueRawLock)
                {
                    if (PacketsInfo.PacketsRawQueue.Count != 0)
                    {
                        shouldSleep = false;
                    }
                }

                if (shouldSleep)
                {
                    System.Threading.Thread.Sleep(250);
                }
                else // should process the queue
                {
                    List<PacketRawInfo> ourQueue;
                    lock (PacketsInfo.QueueRawLock)
                    {
                        ourQueue = PacketsInfo.PacketsRawQueue;
                        PacketsInfo.PacketsRawQueue = new List<PacketRawInfo>();
                    }

                    foreach (var packet in ourQueue)
                    {
                        ParseNetworkPacket(packet);
                    }
                }
            }

        }

        public void Stop()
        {
            backgroundThreadStop = true;
            if (backgroundThread.ThreadState == ThreadState.Running)
                backgroundThread.Abort();
            PacketsInfo.PacketsRawQueue.Clear();
            db.Close();            
        }

        public void AddConnection(PacketInfo conn)
        {
            connections_.Add(conn);
        }

        public void RemoveConnection(int id)
        {
            connections_.RemoveAt(id);
        }

        public void RemoveConnection(PacketInfo conn)
        {
            connections_.RemoveAt(FindConnection(conn));
        }

        public void ReplaceConnection(PacketInfo conn)
        {
            connections_[FindConnection(conn)] = conn;
        }
        
        public PacketInfo UpdateConnection(int id, PacketInfo conn)
        {
            connections_[id].size+= conn.size;
            connections_[id].count++;
            connections_[id].lastActiveTime = conn.time;
            return connections_[id];
        }

        public int FindConnection(PacketInfo conn)
        {
            for (int x = 0; x <= connections_.Count - 1; x++)
            {
                if (connections_[x].ipSource == conn.ipSource)
                    if (connections_[x].ipDestination == conn.ipDestination)
                        if (connections_[x].portSource== conn.portSource)
                            if (connections_[x].portDestination== conn.portDestination)
                                if (connections_[x].protocol == conn.protocol)
                                    return x;
            }
            return -1;
        }

        public int FindConnectionUnion(PacketInfo conn)
        {
            for (int x = 0; x <= connections_.Count - 1; x++)
            {
                if (connections_[x].ipSource == conn.ipSource)
                    if (connections_[x].ipDestination == conn.ipDestination)
                        if (connections_[x].portSource == conn.portSource)
                            if (connections_[x].portDestination == conn.portDestination)
                                if (connections_[x].protocol == conn.protocol)
                                    return x;
                if ((connections_[x].ipSource == conn.ipDestination) && (connections_[x].portDestination == conn.portSource) && (connections_[x].protocol == conn.protocol))
                    return x;

            }
            return -1;
        }


        public bool ExistsConnection(PacketInfo conn)
        {
            for (int x = 0; x <= connections_.Count - 1; x++)
            {
                if (connections_[x].ipSource == conn.ipSource)
                    if (connections_[x].ipDestination == conn.ipDestination)
                        if (connections_[x].portSource == conn.portSource)
                            if (connections_[x].portDestination == conn.portDestination)
                                if (connections_[x].protocol == conn.protocol)
                                    return true;
            }
            return false;
        }
    }
}
