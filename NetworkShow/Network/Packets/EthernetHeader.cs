using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
//using MiscUtil.Conversion;

namespace NetworkShow.Network.Packets
{
    public class EthernetHeader
    {
        private byte[] destinationMac = new byte[6];
        private byte[] sourceMac = new byte[6];
        private Int16 etherType;
        private byte[] payload;

        public EthernetHeader(byte[] byBuffer, int nReceived)
        {
            try
            {
                //Create MemoryStream out of the received bytes
                MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nReceived);
                //Next we create a BinaryReader out of the MemoryStream
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                
                binaryReader.Read(destinationMac, 0, 6);
                binaryReader.Read(sourceMac, 0, 6);
                etherType = binaryReader.ReadInt16();
                payload = new byte[nReceived-13];
                binaryReader.Read(payload, 0, nReceived - 13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NetworkShow", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public string DestinationMac
        {
            get { return new PhysicalAddress(destinationMac).ToString(); }
        }
        public string SourceMac
        {
            get { return new PhysicalAddress(destinationMac).ToString(); }
        }
                
        public EthernetPacketType EtherType
        {
            get { return (EthernetPacketType)IPAddress.NetworkToHostOrder(etherType); }
        }

        public byte[] Payload
        {
            get { return payload; }
        }
        
    }
}
