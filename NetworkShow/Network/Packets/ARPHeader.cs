using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkShow.Network.Packets
{
    /// <summary>
    /// The possible ARP operation values
    /// </summary>
    /// <remarks>
    /// References:
    ///  - http://www.networksorcery.com/enp/default1101.htm
    /// </remarks>
    public enum ARPOperation : ushort
    {
        /// <summary>Request</summary>
        /// <remarks>See RFC 826, RFC 5227</remarks>
        Request = 1,

        /// <summary>Response</summary>
        /// <remarks>See RFC 826, RFC 1868, RFC 5227</remarks>
        Response = 2,

        /// <summary>Request Reverse</summary>
        /// <remarks>See RFC 903</remarks>
        RequestReverse = 3,

        /// <summary>Reply Reverse</summary>
        /// <remarks>See RFC 903</remarks>
        ReplyReverse = 4,

        /// <summary>DRARP Request</summary>
        /// <remarks>See RFC 1931</remarks>
        DRARPRequest = 5,

        /// <summary>DRARP Reply</summary>
        /// <remarks>See RFC 1931</remarks>
        DRARPReply = 6,

        /// <summary>DRARP Error</summary>
        /// <remarks>See RFC 1931</remarks>
        DRARPError = 7,

        /// <summary>InARP Request</summary>
        /// <remarks>See RFC 1293</remarks>
        InARPRequest = 8,

        /// <summary>InARP Reply</summary>
        /// <remarks>See RFC 1293</remarks>
        InARPReply = 9,

        /// <summary>ARP NAK</summary>
        /// <remarks>See RFC 1577</remarks>
        ARPNAK = 10,

        /// <summary>MARS Request</summary>
        MARSRequest = 11,

        /// <summary>MARS Multi</summary>
        MARSMulti = 12,

        /// <summary>MARS MServ</summary>
        MARSMServ = 13,

        /// <summary>MARS Join</summary>
        MARSJoin = 14,

        /// <summary>MARS Leave</summary>
        MARSLeave = 15,

        /// <summary>MARS NAK</summary>
        MARSNAK = 16,

        /// <summary>MARS Unserv</summary>
        MARSUnserv = 17,

        /// <summary>MARS SJoin</summary>
        MARSSJoin = 18,

        /// <summary>MARS SLeave</summary>
        MARSSLeave = 19,

        /// <summary>MARS Grouplist Request</summary>
        MARSGrouplistRequest = 20,

        /// <summary>MARS Grouplist Reply</summary>
        MARSGrouplistReply = 21,

        /// <summary>MARS Redirect Map</summary>
        MARSRedirectMap = 22,

        /// <summary>MARS UNARP</summary>
        /// <remarks>See RFC 2176</remarks>
        MaposUnarp = 23,

        /// <summary>OP_EXP1</summary>
        /// <remarks>See RFC 5494</remarks>
        OP_EXP1 = 24,

        /// <summary>OP_EXP2</summary>
        OP_EXP2 = 25
    }    
    
    class ARPHeader
    {
        private ushort hardwareType;         //HTYPE
        private ushort protocolType;         //PTYPE
        private byte hardwareLength;        //HLEN
        private byte protocolLength;        //PLEN
        private ushort operation;            //OPER
        private byte[] senderHarwareAddress = new byte[6];   //SHA
        private uint senderProtocolAddress;  //SPA
        private byte[] targedHarwareAddress = new byte[6];   //THA
        private uint targedProtocolAddress;  //TPA
        private int size;

        public ARPHeader(byte[] byBuffer, int nReceived)
        {
            try
            {
                //Create MemoryStream out of the received bytes
                MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nReceived);
                //Next we create a BinaryReader out of the MemoryStream
                BinaryReader binaryReader = new BinaryReader(memoryStream);

                hardwareType = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                protocolType = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                hardwareLength = binaryReader.ReadByte();
                protocolLength = binaryReader.ReadByte();
                operation = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                binaryReader.Read(senderHarwareAddress, 0, 6);
                senderProtocolAddress = (uint)binaryReader.ReadInt32();
                binaryReader.Read(targedHarwareAddress, 0, 6);
                targedProtocolAddress = (uint)binaryReader.ReadInt32();
                size = nReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NetworkShow", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public ARPOperation Operation
        {
            get { return (ARPOperation)operation; }
        }

        public int Size
        {
            get { return size; }
        }

        public string SHA
        {
            get { return new PhysicalAddress(senderHarwareAddress).ToString(); }
        }

        public string THA
        {
            get { return new PhysicalAddress(targedHarwareAddress).ToString(); }
        }

        public string SPA
        {
            get { return new IPAddress(senderProtocolAddress).ToString(); }
        }

        public string TPA
        {
            get { return new IPAddress(targedProtocolAddress).ToString(); }
        }

        public string Description
        {
            get {
                string description = "";
                if (senderProtocolAddress == targedProtocolAddress)
                    description = "ARP оповещение: у " + SPA + " MAC = " + Utils.ToMAC(SHA);
                else
                    if (Operation == ARPOperation.Request)
                        description = "Кто " + TPA + " Ответьте " + SPA;
                    else
                        if (Operation == ARPOperation.Response)
                            description = "Ответ: у " + SPA + " MAC = " + Utils.ToMAC(SHA);
                        else
                            description = Utils.ToMAC(SHA) + " - " + Utils.ToMAC(THA) + " " + Operation.ToString();

                return description;
            }
        }

    }
}
