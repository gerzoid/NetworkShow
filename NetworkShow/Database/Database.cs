using System;
using System.Collections.Generic;
using System.Text;
using DBFShowLib;
using NetworkShow.Network;

namespace NetworkShow.Database
{     
    class Database
    {
        const int POS_IP_SOURCE_POS = 0;
        const int POS_IP_DEST_POS = 1;
        const int POS_PORT_SOURCE_POS = 2;
        const int POS_PORT_DEST_POS = 3;
        const int POS_ACTIVE = 4;
        public const int POS_TOTAL_BYTES = 5;
        public const int POS_TOTAL_PACKETS = 6;
        public const int POS_DNS_SOURCE = 7;
        const int POS_DNS_DEST = 8;
        const int POS_PROTOCOL = 9;
        const int POS_TYPE = 10;
        const int POS_DATEBEGIN = 11;
        const int POS_LASTACTIVE = 12;
        const int POS_DESCRIPTION = 13;
        public const int POS_PROTO = 14;

        DBF dbf;        
        
        private Object thisLock = new Object();

        public Database()
        {
            //dbf = new DBFShow();
            dbf = new DBF();
            dbf.OpenFile("db.dbf");
            dbf.SetCodePage(201, 1251);
        }
                
        public void EmptyFile()
        {
            dbf.EmptyFile();
        }

        public string GetValue(int RowIndex, int ColumnIndex)
        {
            return dbf.GetValue(RowIndex, ColumnIndex);
        }

        public string GetValuePortIn(int RowIndex)
        {
            return dbf.GetValue(RowIndex, POS_PORT_SOURCE_POS);
        }

        public string GetValuePortOut(int RowIndex)
        {
            return dbf.GetValue(RowIndex, POS_PORT_DEST_POS);
        }
        

        public PacketType GetValueProto(int RowIndex)
        {
            return (PacketType)(Convert.ToInt32(dbf.GetValue(RowIndex, POS_PROTO)));
        }


        public int GetCountColumns()
        {
            return dbf.GetCountColumns;
        }

        public int GetCountRows()
        {
            dbf.RefreshRecordsCount();
            return dbf.GetCountRows;
        }

        public string GetColumnName(int ColumnIndex)
        {
            return dbf.GetColumnName(ColumnIndex);
        }

        public void Close()
        {
            dbf.Close();
        }

        public int SaveNewPacket(PacketInfo packet)
        {
            int pos=-1;
            lock (thisLock)
            {
                dbf.AddRow();
                pos = dbf.GetCountRows - 1;

                dbf.SetValue(pos, POS_IP_SOURCE_POS, packet.ipSource, dbf.GetColumnType(POS_IP_SOURCE_POS));
                dbf.SetValue(pos, POS_IP_DEST_POS, packet.ipDestination, dbf.GetColumnType(POS_IP_DEST_POS));
                dbf.SetValue(pos, POS_ACTIVE, packet.active, dbf.GetColumnType(POS_ACTIVE));
                dbf.SetValue(pos, POS_PORT_SOURCE_POS, packet.portSource, dbf.GetColumnType(POS_PORT_SOURCE_POS));
                dbf.SetValue(pos, POS_PORT_DEST_POS, packet.portDestination, dbf.GetColumnType(POS_PORT_DEST_POS));
                dbf.SetValue(pos, POS_PROTOCOL, packet.protocol, dbf.GetColumnType(POS_PROTOCOL));
                dbf.SetValue(pos, POS_TOTAL_BYTES, Convert.ToString(packet.size), dbf.GetColumnType(POS_TOTAL_BYTES));
                dbf.SetValue(pos, POS_TOTAL_PACKETS, "1", dbf.GetColumnType(POS_TOTAL_PACKETS));
                dbf.SetValue(pos, POS_DATEBEGIN, packet.time.ToString(), dbf.GetColumnType(POS_DATEBEGIN));
                dbf.SetValue(pos, POS_LASTACTIVE, packet.time.ToString(), dbf.GetColumnType(POS_LASTACTIVE));
                dbf.SetValue(pos, POS_DESCRIPTION, packet.desription, dbf.GetColumnType(POS_DESCRIPTION));
                dbf.SetValue(pos, POS_PROTO, Convert.ToString((int)packet.protocolE), dbf.GetColumnType(POS_PROTO));
                dbf.RefreshRecordsCount();
            }
            return pos;
        }

        public void UpdateConnection(int pos, PacketInfo packet)        
        {
            lock (thisLock)
            {
                dbf.SetValue(pos, POS_ACTIVE, packet.active, dbf.GetColumnType(POS_ACTIVE));
                dbf.SetValue(pos, POS_TOTAL_BYTES, Convert.ToString(packet.size), dbf.GetColumnType(POS_TOTAL_BYTES));
                dbf.SetValue(pos, POS_TOTAL_PACKETS, Convert.ToString(packet.count), dbf.GetColumnType(POS_TOTAL_PACKETS));
                dbf.SetValue(pos, POS_LASTACTIVE, packet.lastActiveTime.ToString(), dbf.GetColumnType(POS_LASTACTIVE));
            }
        }


    }
}
