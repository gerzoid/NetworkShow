using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace NetworkShow.Network
{
    [Serializable()]
    public struct device
    {
        public string ID;               //ID 
        public string Name;             //Наименование сетевой
        public string Description;       //описание
        public IPAddress[] IP;
        public IPAddress[] IPv6;
        public IPAddress[] Gateway;       //Шлюз
        public IPAddress Mask;          //Маска
        public IPAddress[] DHCP;          //Маска
        public IPAddress[] DNS;          //Маска
        public string MAC;              //MAC адрес
        public Object obj;
        
    }
}
