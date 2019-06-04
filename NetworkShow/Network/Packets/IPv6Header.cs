using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NetworkShow.Network.Packets
{
    class IPv6Header
    {
        //IP Header fields
        private Int32 versionPrioFlowLabel;
        private ushort payloadLength;
        private byte nextHeader;
        private byte hopLimit;
        private byte[] sourceAddress = new byte[16];
        private byte[] destinationAddress = new byte[16];
        private byte[] byIPv6Data;  //Data carried by the datagram   

        public IPv6Header(byte[] byBuffer, int nReceived)
        {
            //Create MemoryStream out of the received bytes
            MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nReceived);
            //Next we create a BinaryReader out of the MemoryStream
            BinaryReader binaryReader = new BinaryReader(memoryStream);

            //The first eight bits of the IP header contain the version and
            //header length so we read them
            versionPrioFlowLabel = binaryReader.ReadInt32();
            payloadLength = (ushort)binaryReader.ReadInt16();
            nextHeader = binaryReader.ReadByte();
            hopLimit = binaryReader.ReadByte();
            binaryReader.Read(sourceAddress, 0, 12);
            binaryReader.Read(destinationAddress, 0, 12);
        }

        public string Version
        {
            get { return ""; }
        }

        public IPAddress DestinationAddress
        {
            get
            {
                return new IPAddress(destinationAddress);
            }
        }

        public IPAddress SourceAddress
        {
            get
            {
                return new IPAddress(sourceAddress);
            }
        }

    }
}