using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using N_etworkShow.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NetworkShow.Network;
using DBFShowLib;
using System.Net;
using NetworkShow.Forms;

namespace NetworkShow
{
    public partial class MainForm : Form
    {
        //DBF db;
        Network.NetworkBase network;
        PacketParser parser;
        public LogWriter log;
        public List<int> filteredRecords;
        filters_struct activeFilter;
        NetworkShow.Database.Database db;
        CFilters filters = new CFilters();

        public MainForm()
        {
            InitializeComponent();
            log = LogWriter.Instance;
            db = new Database.Database();
            db.EmptyFile();            
            CreateColumnsInGrid("db");

            for (int x = 0; x <= filters.GetCountUserFilters() - 1; x++)
            {
                tree.Nodes[1].Nodes[0].Nodes.Add(filters.GetUserFilters(x).name);
                tree.Nodes[1].Nodes[0].Nodes[x].Tag = filters.GetUserFilters(x);
            }
            
            //Это на будущее
            tree.Nodes[1].Tag = filters.GetSystemFilters(0);             //IP
            tree.Nodes[1].Nodes[0].Tag = filters.GetSystemFilters(1);    //TCP/UDP
            tree.Nodes[1].Nodes[1].Tag = filters.GetSystemFilters(2);    //ICMP
            tree.Nodes[1].Nodes[2].Tag = filters.GetSystemFilters(3);    //IGMP
            tree.Nodes[1].Nodes[3].Tag = filters.GetSystemFilters(5);    //OTHER
            tree.Nodes[2].Tag = filters.GetSystemFilters(4);             //ARP


            tree.ExpandAll();

            tree.SelectedNode = tree.Nodes[1].Nodes[0];

            filteredRecords = new List<int>();
            activeFilter = new filters_struct();
            activeFilter.proto = PacketType.TCPandUDP;
            //filter.protocol = PacketType.TCPandUDP;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                network = new Network.Sockets.RawSocket();
            else
                network = new Network.SharpPcap.SharpPcap();
            network.Init();

            FormAdapters formAdapters = new FormAdapters();
            formAdapters.devices = new Network.device[network.CountDevices];
                        
            //Заполняем информацию об адаптерах в переменную формы formAdpaters
            for (int x = 0; x <= network.CountDevices - 1; x++)
                formAdapters.devices[x] = network.GetInfoAboutDeviceFromIndex(x);
            formAdapters.ShowDialog();
            if (formAdapters.selectedDeviceIndex != -1)
            {
                parser = new PacketParser();
                parser.incomingIP = formAdapters.devices[formAdapters.selectedDeviceIndex].IP[0].ToString();                
                //parser.ChangeRowsCountEvent += new PacketParser.ChangeRowsCount(parser_ChangeRowsCountEvent);
                parser.ChangeRowsCountEvent += parser_ChangeRowsCountEvent;
                parser.UpdateInfoEvent += parser_UpdateInfoEvent;
                network.StartCapture(Convert.ToByte(formAdapters.selectedDeviceIndex));
                timer1.Start();
            }
        }

        void parser_UpdateInfoEvent(string protocol)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new PacketParser.UpdateInfo(parser_UpdateInfoEvent), new object[] { protocol });
                return;
            }
            else
            {
                if (grid.Columns.Count <= 0)
                    return;
                grid.InvalidateColumn(4);
                grid.InvalidateColumn(5);
                grid.InvalidateColumn(6);
                grid.InvalidateColumn(12);
            }
        }

        void parser_ChangeRowsCountEvent(PacketType protocol, int position, string portIn, string portOut)
        {

            if (filteredRecords == null)
                return;

            if (activeFilter.proto == PacketType.TCPandUDP)
            {
                if ((protocol != PacketType.TCP) && (protocol != PacketType.UDP))
                    return;
            }
            else
                if ((protocol != activeFilter.proto) )  
                    return;

            if (activeFilter.userFilter)
            {
                if (!filters.Check(activeFilter.id, Convert.ToInt32(portIn), Convert.ToInt32(portOut)))
                    return;
            }

            if (InvokeRequired)
            {
                BeginInvoke(new PacketParser.ChangeRowsCount(parser_ChangeRowsCountEvent), new object[] { protocol, position, portIn, portOut });
                return;
            }
            else
            {
                filteredRecords.Add(position);
                grid.RowCount++;
                
            }
        }

        public void CreateColumnsInGrid(string nameTable)
        {
            grid.Enabled = false;
            grid.Columns.Clear();
            grid.ColumnHeadersHeight = 50;
            for (int x = 0; x <= db.GetCountColumns() - 1; x++)
            {
                grid.Columns.Add(db.GetColumnName(x), RenameColumn(db.GetColumnName(x)));
                grid.Columns[x].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns[x].HeaderCell.Style.WrapMode = DataGridViewTriState.True;
            }
            grid.Columns["ACTIVE"].Width = 45;
            grid.Columns["PORT_S"].Width = 70;
            grid.Columns["PORT_D"].Width = 70;
            grid.Columns["TOTAL_B"].Width = 70;
            grid.Columns["TOTAL_P"].Width = 70;
            grid.Columns["PROTOCOL"].Width = 70;
            grid.Columns["DNS_SOURCE"].Visible = false;
            grid.Columns["DNS_DEST"].Visible = false;
            grid.Columns["TYPE"].Visible = false;
            grid.Columns["PROTO"].Visible = false;

            //db.RefreshRecordsCount();
            grid.RowCount = db.GetCountRows();
            grid.Enabled = true;
        }

        //Переименованеи колонок на русский 8)
        public string RenameColumn(string nameColumn)
        {
            switch (nameColumn)
            {
                case "IP_SOURCE":
                    return "Отправитель";
                case "IP_DEST":
                    return "Получатель";
                case "PORT_S":
                    return "Порт отправителя";
                case "PORT_D":
                    return "Порт получателя";
                case "ACTIVE":
                    return "Активн";
                case "TOTAL_B":
                    return "Всего байт";
                case "TOTAL_P":
                    return "Всего пакетов";
                case "PROTOCOL":
                    return "Протокол";
                case "TYPE":
                    return "Тип";
                case "DATEBEGIN ":
                    return "Начало";
                case "LASTACTIVE ":
                    return "Посл. активность";
                case "DESCRIPT":
                    return "Описание";
                default:
                    return nameColumn;
            }

        }


        public void ReloadUserFilters()
        {
            filters.LoadUserFilters();
            tree.Nodes[1].Nodes[0].Nodes.Clear();
            for (int x = 0; x <= filters.GetCountUserFilters() - 1; x++)
            {
                tree.Nodes[1].Nodes[0].Nodes.Add(filters.GetUserFilters(x).name);
                tree.Nodes[1].Nodes[0].Nodes[x].Tag = filters.GetUserFilters(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

/*            Stream TestFileStream = File.Create("ser.ser");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, devices);
            TestFileStream.Close();
            
            if (File.Exists("ser.ser"))
            {
                Stream TestFileStream = File.OpenRead("ser.ser");
                BinaryFormatter deserializer = new BinaryFormatter();
                device[] devices = (device[])deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
            }*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parser!=null)
                parser.Stop();
            if ((network != null)&&(network.recieved))
                network.StopCapture();
            timer1.Stop();
            
        }

        private void grid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {                
            e.Value = db.GetValue(GetCurrentRowPosition(e.RowIndex), e.ColumnIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Обновление информации об активности маршрутов
            if (parser!=null)
                parser.UpdateActiveConnection();
        }

        //Выдает текущую позицию строки в зависимости от фильтрации или сортировки.. 
        public int GetCurrentRowPosition(int RowIndex)
        {
            if (filteredRecords != null)
            {
                if (filteredRecords.Count > 0)
                    return filteredRecords[RowIndex];
                else
                    return RowIndex;
            }
            else
                return RowIndex;
        }


        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            PacketType pt;

            if (Convert.ToString(e.Node.Tag) == "info")
                return;
            activeFilter = (filters_struct)(e.Node.Tag);
            filteredRecords = new List<int>();
            if (!activeFilter.userFilter)
            {
                for (int i = 0; i <= db.GetCountRows() - 1; i++)
                {
                    pt = db.GetValueProto(i);
                    if ((pt == activeFilter.proto) || (activeFilter.proto == PacketType.TCPandUDP) && ((pt == PacketType.TCP) || (pt == PacketType.UDP)))
                        filteredRecords.Add(i);
                }
            }
            if (activeFilter.userFilter)
            {                
                for (int i = 0; i <= db.GetCountRows() - 1; i++)
                {
                    if (filters.Check(activeFilter.id, Convert.ToInt32(db.GetValuePortIn(i)), Convert.ToInt32(db.GetValuePortOut(i))))
                    //if ((db.GetValuePortIn(i)==activeFilter.ports)||(db.GetValuePortOut(i)==activeFilter.ports))
                        filteredRecords.Add(i);
                }
            }


            if (grid.Rows.Count > 0)
                grid.FirstDisplayedScrollingRowIndex = 0;
            grid.RowCount = filteredRecords.Count;
            grid.Refresh();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            splitContainer1.Width = this.Width - 40;
            splitContainer1.Height = this.Height - 90;
        }

        private void gsdfgsfdToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string tt = Dns.GetHostEntry(Convert.ToString(grid.SelectedCells[0].Value)).HostName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (network!=null)
                network.StopCapture();
            if (parser != null)
            {
                parser.ChangeRowsCountEvent -= parser_ChangeRowsCountEvent;
                parser.UpdateInfoEvent -= parser_UpdateInfoEvent;                
                parser.Stop();
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.network;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void протоколыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowFilters formShowFilters = new FormShowFilters();
            formShowFilters.ShowDialog();
            ReloadUserFilters();
        }

    }
}
