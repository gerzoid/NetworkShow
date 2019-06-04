using System;
using System.Collections.Generic;
using System.Text;
using SharpPcap;
using NetworkShow.Network;
using SharpPcap.LibPcap;

namespace NetworkShow.Network.SharpPcap
{
    class PcapClass
    {
        public ICaptureDevice activeDevice;
        LogWriter log;
        
        //Перечень всех устройств в системе
        private CaptureDeviceList devices_list;


        public PcapClass()
        {
            devices_list = CaptureDeviceList.Instance;
            log = LogWriter.Instance;
        }
    
        //Получить перечень всех адаптеров в системе
        public device[] GetListAllAdapters()
        {
            device[] devices = new device[devices_list.Count];
            for (int x = 0; x <= devices_list.Count - 1; x++)
            {
                devices[x].Description = "";
                devices[x].MAC= "";
                devices[x].Name = "";
                try
                {
                    devices_list[x].Open();
                    log.WriteToLog("Открыли " + x + " устройство");

                    devices[x].Name = ((PcapDevice)devices_list[x]).Interface.FriendlyName;
                    log.WriteToLog("Name " + devices[x].Name);
                    devices[x].ID = ((PcapDevice)devices_list[x]).Interface.Name;
                    devices[x].Description = ((LibPcapLiveDevice)devices_list[x]).Interface.Description;
                    try
                    {
                        devices[x].MAC = devices_list[x].MacAddress.ToString();
                    }
                    catch (Exception e)
                    {
                    }
                    if (((LibPcapLiveDevice)devices_list[x]).Addresses.Count > 0)
                    {
                        devices[x].IP = new System.Net.IPAddress[((LibPcapLiveDevice)devices_list[x]).Addresses.Count - 1];
                        devices[x].IPv6 = new System.Net.IPAddress[((LibPcapLiveDevice)devices_list[x]).Addresses.Count - 1];
                    }
                    byte countIP = 0, countIPv6 = 0;
                    //Перебираем все IP адреса на текущем интерфейсе
                    if (((LibPcapLiveDevice)devices_list[x]).Addresses.Count>0)
                        for (int d = 0; d <= ((LibPcapLiveDevice)devices_list[x]).Addresses.Count - 1; d++)
                        {
                            if (((LibPcapLiveDevice)devices_list[x]).Addresses[d].Addr.ipAddress != null)
                            {
                                if (((LibPcapLiveDevice)devices_list[x]).Addresses[d].Addr.ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                                {
                                    devices[x].IP[countIPv6] = ((LibPcapLiveDevice)devices_list[x]).Addresses[d].Addr.ipAddress;
                                    countIPv6++;
                                }
                                else
                                {
                                    devices[x].IP[countIP] = ((LibPcapLiveDevice)devices_list[x]).Addresses[d].Addr.ipAddress;
                                    countIP++;
                                }
                            }
                        }

                    devices[x].Mask = ((LibPcapLiveDevice)devices_list[x]).Addresses[0].Netmask.ipAddress;
                    if (((PcapDevice)devices_list[x]).Interface.GatewayAddress != null)
                    {
                        devices[x].Gateway = new System.Net.IPAddress[1];
                        devices[x].Gateway[0] = ((PcapDevice)devices_list[x]).Interface.GatewayAddress;
                    }
                    devices_list[x].Close();
                }
                catch (Exception e)
                {

                }
            }

            return devices;
        }

        //Открыть устройство
        public void OpenDevice(byte numDevice, DeviceMode mode)
        {
            activeDevice = devices_list[numDevice];
//            activeDevice.OnPacketArrival += new PacketArrivalEventHandler(OnRecieve);
            activeDevice.Open(mode);            
        }

        public void StartCapture()
        {
            activeDevice.StartCapture();
        }

        public void StopCapture()
        {
            if (activeDevice != null)
                if (activeDevice.Started)
                    activeDevice.StopCapture();
        }

    }
}
