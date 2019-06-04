using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkShow
{
    class CFilters
    {
        public DBFShowLib.DBF db;
        public IList<filters_struct> system_filters;
        public IList<filters_struct> user_filters;
        
        public CFilters()
        {
            db = new DBFShowLib.DBF();
            db.OpenFile("ports.dbf");
            system_filters = new List<filters_struct>();
            user_filters = new List<filters_struct>();
            system_filters.Add(new filters_struct() { name = "IP", userFilter = false, proto =  PacketType.TCPandUDP, ports="",  komm= ""});
            system_filters.Add(new filters_struct() { name = "TCP/UDP", userFilter = false, proto = PacketType.TCPandUDP, ports = "", komm = "" });
            system_filters.Add(new filters_struct() { name = "ICMP", userFilter = false, proto = PacketType.ICMP, ports = "", komm = "" });
            system_filters.Add(new filters_struct() { name = "IGMP", userFilter = false, proto = PacketType.IGMP, ports = "", komm = "" });
            system_filters.Add(new filters_struct() { name = "ARP", userFilter = false, proto = PacketType.ARP, ports = "", komm = "" });
            system_filters.Add(new filters_struct() { name = "OTHER", userFilter = false, proto = PacketType.UNKNOWN, ports = "", komm = "" });
            LoadUserFilters();
        }

        public bool Check(int id, int portIn, int portOut)
        {
            string tmp_ports = user_filters[id].ports;            
            if (tmp_ports.IndexOf('-')> 0)
            {
                int value1 = Convert.ToInt32(tmp_ports.Substring(0, tmp_ports.IndexOf('-')).Trim());
                int value2 = Convert.ToInt32(tmp_ports.Substring(tmp_ports.IndexOf('-')+1, tmp_ports.Length- tmp_ports.IndexOf('-')-1));
                for (int x = value1; x <= value2; x++)
                {
                    if ((portIn == x) || (portOut == x))
                        return true;
                }
            }
            else
                if (portIn==Convert.ToInt32(tmp_ports)||(portOut==Convert.ToInt32(tmp_ports)))
                    return true;
            return false;
        }

        public filters_struct GetSystemFilters(int pos)
        {
            return system_filters[pos];
        }

        public int GetCountUserFilters()
        {
            return user_filters.Count;
        }

        public filters_struct GetUserFilters(int pos)
        {
            return user_filters[pos];
        }

        public void LoadUserFilters()
        {
            user_filters.Clear();
            db.RefreshRecordsCount();
            for (int x = 0; x <= db.GetCountRows - 1; x++)
                user_filters.Add(new filters_struct() { id = x, name = db.GetValue(x, 1), ports = db.GetValue(x, 2), komm = db.GetValue(x, 3), userFilter = true, proto = PacketType.TCPandUDP });            
        }

    }
}
