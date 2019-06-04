using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace NetworkShow.Network.Packets
{

    public enum IGMPMessageType
    {
        MembershipQuery = 17,
        MembershipReportIGMPv1 = 18,
        MembershipReportIGMPv2 = 22,
        LeaveGroup = 23,
        MembershipReportIGMPv3 = 34,
    }
    
    class IGMPHeader
    {
        private byte versionType;
        private byte unused;
        private ushort checkSum;
        private uint groupAddress;
        private int size;

        public IGMPHeader(byte[] byBuffer, int nReceived)
        {
            MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nReceived);
            BinaryReader binaryReader = new BinaryReader(memoryStream);

            versionType = (byte)binaryReader.ReadByte();
            unused = (byte)IPAddress.NetworkToHostOrder(binaryReader.ReadByte());
            checkSum = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
            //groupAddress = (uint)IPAddress.NetworkToHostOrder(binaryReader.ReadInt32());
            groupAddress = (uint)binaryReader.ReadInt32();
            size = nReceived;
        }

        public int Size
        {
            get { return size; }
        }

        public IGMPMessageType Type
        {
            get
            {
                return (IGMPMessageType)versionType;
            }
        }

        public string Version
        {
            get
            {
                byte tmp = versionType;
                tmp = tmp >>= 4;
                return Convert.ToString(tmp);
            }
        }

        public string Checksum
        {
            get
            {
                return string.Format("0x{0:x2}", checkSum);
            }
        }

        public IPAddress GroupAddress
        {
            get
            {
                return new IPAddress(groupAddress);
            }
        }

    }
}
