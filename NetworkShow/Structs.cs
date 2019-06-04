using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkShow
{

    struct ActiveFilter
    {
        public string filter;
        public PacketType protocol;
    }

    struct filters_struct
    {
        public int id;
        public bool userFilter;
        public string name;
        public string ports;
        public string komm;
        public PacketType proto;
    }

    public enum PacketType
    {
        UNKNOWN=0,
        TCP=1,
        UDP=2,
        TCPandUDP=3,
        IGMP=4,
        ICMP=5,
        ARP=6,
        OTHER=7
    }
}
