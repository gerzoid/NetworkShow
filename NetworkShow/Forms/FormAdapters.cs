using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetworkShow.Network;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace N_etworkShow.Forms
{
    public partial class FormAdapters : Form
    {
        public device[] devices;
        public int selectedDeviceIndex =-1;

        public FormAdapters()
        {
            InitializeComponent();
        }

        private void FormAdapters_Shown(object sender, EventArgs e)
        {
            this.Icon = NetworkShow.Properties.Resources.network;
            for (int x = 0; x <= devices.Length - 1; x++)
                listBoxAdapters.Items.Add(devices[x].Description);
            listBoxAdapters.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDeviceIndex = listBoxAdapters.SelectedIndex;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void listBoxAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string mac, dns, dhcp, gateway;
            int index = listBoxAdapters.SelectedIndex;
            adapterInfo.Items.Clear();
            adapterInfo.Items.Add("Наименование");
            adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(devices[index].Name);
            adapterInfo.Items.Add("Описание");
            adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(devices[index].Description);
            adapterInfo.Items.Add("MAC");
            mac = devices[index].MAC;            
            if ((mac!=null)&&(mac != "")) mac = mac.Insert(2, ":").Insert(5, ":").Insert(8, ":").Insert(11, ":").Insert(14, ":");
            adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(mac);            
            if (devices[index].IP != null)            
                for (int j = 0; j <= devices[index].IP.Length - 1; j++)
                {
                    if (devices[index].IP[j] != null)
                    {
                        adapterInfo.Items.Add("IP адрес");
                        adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(devices[index].IP[j].ToString());
                    }
                }            
            if (devices[index].IPv6 != null)            
                for (int j = 0; j <= devices[index].IPv6.Length - 1; j++)
                {
                    if (devices[index].IPv6[j] != null)
                    {
                        adapterInfo.Items.Add("IPv6 адрес");
                        adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(devices[index].IPv6[j].ToString());
                    }
                }
            
             adapterInfo.Items.Add("Маска");
             if (devices[index].Mask != null)
                 adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(devices[index].Mask.ToString());
             adapterInfo.Items.Add("DHCP");
             dhcp = (devices[index].DHCP!=null && devices[index].DHCP.Length != 0) ? devices[index].DHCP[0].ToString() : "-";
             adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(dhcp);
             adapterInfo.Items.Add("Шлюз");
             gateway = (devices[index].Gateway != null && devices[index].Gateway.Length != 0) ? devices[index].Gateway[0].ToString() : "-";
             adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(gateway);
             adapterInfo.Items.Add("DNS");
             dns = (devices[index].DNS != null && devices[index].DNS.Length != 0) ? devices[index].DNS[0].ToString() : "-";
             adapterInfo.Items[adapterInfo.Items.Count - 1].SubItems.Add(dns);
        }
    }
}
