using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net;
using System.Windows.Forms;

namespace NetworkShow.Network.Sockets
{
    class SocketClass
    {
        public event ReceiveEventHandler ReceiveEvent;
        //Лог файл
        LogWriter log;

        private Socket mainSocket;                          //Сокет
        private byte[] byteData = new byte[4096];
        private bool bContinueCapturing = false;            //Флаг для проверки активен ли сбор пакетов или нет        

        byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
        byte[] byOut = new byte[4] { 1, 0, 0, 0 }; //Capture outgoing packets

        public SocketClass()
        {
            log = LogWriter.Instance;
        }

        //Получить перечень всех адаптеров в системе
        public device[] GetListAllAdapters()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            device[] devices = new device[nics.Length];
            for (int x = 0; x <= nics.Length - 1; x++)
            {
                devices[x] = new device();
                if (nics[x].GetIPProperties().UnicastAddresses.Count != 0)
                {
                    devices[x].IP = new  IPAddress[nics[x].GetIPProperties().UnicastAddresses.Count];
                    devices[x].IPv6 = new IPAddress[nics[x].GetIPProperties().UnicastAddresses.Count];
                    byte countIP = 0, countIPv6 = 0;
                    //Перебираем все IP адреса на текущем интерфейсе
                    for (int d = 0; d <= nics[x].GetIPProperties().UnicastAddresses.Count - 1; d++)
                    {
                        //Проверяем являетеся ли IP из IPv6
                        if (nics[x].GetIPProperties().UnicastAddresses[d].Address != null)
                        {
                            if (nics[x].GetIPProperties().UnicastAddresses[d].Address.IsIPv6LinkLocal)
                            {
                                devices[x].IPv6[countIPv6] = nics[x].GetIPProperties().UnicastAddresses[d].Address;
                                countIPv6++;
                            }
                            else
                            {
                                devices[x].IP[countIP] = nics[x].GetIPProperties().UnicastAddresses[d].Address;
                                countIP++;
                            }
                        }
                    }
                    if (nics[x].GetIPProperties().UnicastAddresses[0].IPv4Mask != null)                        
                        devices[x].Mask = nics[x].GetIPProperties().UnicastAddresses[0].IPv4Mask;
                }
                devices[x].ID = nics[x].Id;
                devices[x].Description = nics[x].Description;
                devices[x].Name = nics[x].Name;
                devices[x].MAC = nics[x].GetPhysicalAddress().ToString();
                //Получить список DHCP адресов
                if (nics[x].GetIPProperties().DhcpServerAddresses.Count != 0)
                {
                    devices[x].DHCP = new System.Net.IPAddress[nics[x].GetIPProperties().DhcpServerAddresses.Count];
                    for (int y = 0; y <= nics[x].GetIPProperties().DhcpServerAddresses.Count-1; y++)
                    {
                        devices[x].DHCP[y] = nics[x].GetIPProperties().DhcpServerAddresses[y];
                    }
                }
                //Получить список DNS адресов
                if (nics[x].GetIPProperties().DnsAddresses.Count != 0)
                {
                    devices[x].DNS = new System.Net.IPAddress[nics[x].GetIPProperties().DnsAddresses.Count];
                    for (int y = 0; y <= nics[x].GetIPProperties().DnsAddresses.Count-1; y++)
                    {
                        devices[x].DNS[y] = nics[x].GetIPProperties().DnsAddresses[y];
                    }
                }
                //Получить список шлюзов
                if (nics[x].GetIPProperties().GatewayAddresses.Count != 0)
                {
                    devices[x].Gateway = new System.Net.IPAddress[nics[x].GetIPProperties().GatewayAddresses.Count];
                    for (int y = 0; y <= nics[x].GetIPProperties().GatewayAddresses.Count-1; y++)
                    {
                        devices[x].Gateway[y] = nics[x].GetIPProperties().GatewayAddresses[y].Address;
                    }
                }
            }
            return devices;
        }

        //Инииализация сокета и привязка его к IP
        public eResultCode CreateSocket(AddressFamily family, SocketType socketType, ProtocolType protocolType, IPAddress ipAddress)
        {

            try
            {
                mainSocket = new Socket(family, socketType, protocolType);

                mainSocket.SetSocketOption(SocketOptionLevel.Socket,            //Applies only to IP packets
                                           SocketOptionName.ExclusiveAddressUse, //Set the include the header
                                           true);                           //option to true
                mainSocket.Bind(new IPEndPoint(ipAddress, 0));
                mainSocket.SetSocketOption(SocketOptionLevel.IP,            //Applies only to IP packets
                                           SocketOptionName.HeaderIncluded, //Set the include the header
                                           true);                           //option to true
                mainSocket.IOControl(IOControlCode.ReceiveAll,              //Equivalent to SIO_RCVALL constant of Winsock 2                    
                                     byTrue,
                                     byOut);
                return eResultCode.noerror;
            }
            catch (Exception e)
            {                
                log.WriteToLog("Ошибка при создании сокета- " + e.Message);
                MessageBox.Show("Ошибка при создании сокета- " + e.Message);
                return eResultCode.error;
            }
        }

        public void BeginReceive(SocketFlags flags)
        {
            bContinueCapturing = true;
            mainSocket.BeginReceive(byteData, 0, byteData.Length, flags,
                new AsyncCallback(OnReceive), null);
        }

        //Функция вызываемая при получении
        private void OnReceive(IAsyncResult ar)
        {
            int nReceived = 0;
            //if (mainSocket.)
                nReceived = mainSocket.EndReceive(ar);

            //ParseData(byteData, nReceived);

            //Создали аргументы для события приёма пакетов
            PacketRawInfo args = new PacketRawInfo();
            args.data = byteData;
            args.time = DateTime.Now;
            args.size = nReceived;
            args.linkLayer = LinkLayers.Null;
            ReceiveEvent(this, args);

            if (bContinueCapturing)
            {
                byteData = new byte[4096];
                mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), null);
            }

        }

        //Остановить передачу
        public void StopReceive()
        {
            bContinueCapturing = false; 
            mainSocket.Shutdown( SocketShutdown.Both);
        }


    }
}
