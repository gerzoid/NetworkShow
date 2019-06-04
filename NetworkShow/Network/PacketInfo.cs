using NetworkShow.Network.Packets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace NetworkShow.Network
{
    public class PacketInfo
    {
        public string ipDestination="";
        public string ipSource="";
        public string harwareDestination="";
        public string hardwareSource="";
        public string portDestination="0";
        public string portSource="0";
        public string protocol = "-";
        public PacketType protocolE = PacketType.UNKNOWN;
        public string desription="-";
        public string active = "F";
        public DateTime time = DateTime.Now;
        public DateTime lastActiveTime = DateTime.Now;
        public int size = 0;
        public int count = 0;
        public int pos = 0;
        public bool incoming = false;
        //public int id;
    }


    public class PacketRawInfo
    {
        public LinkLayers linkLayer;
        public DateTime time;
        public byte[] data;
        public int size;
    }


    public static class PacketsInfo
    {
        public static object QueueRawLock = new object();
        public  static List<PacketRawInfo> PacketsRawQueue = new List<PacketRawInfo>();

        public  static object QueueLock = new object();
        public static List<PacketInfo> PacketQueue = new List<PacketInfo>();


        public static void AddToQueue(PacketRawInfo packet)
        {
            lock (QueueRawLock)
            {
                PacketsRawQueue.Add(packet);
            }            
        }

        public static void AddToQueue(PacketInfo packet)
        {
            lock (QueueLock)
            {
                PacketQueue.Add(packet);
            }
        }



    }

}
