using System;
using System.Collections.Generic;
using System.Text;
using NetworkShow.Network;
using NetworkShow.Network.SharpPcap;
using SharpPcap;

namespace NetworkShow.Network.SharpPcap
{
    class SharpPcap:NetworkBase
    {
        PcapClass pcap;

        //Инициализация
        public override int Init()
        {
            log = LogWriter.Instance;
            pcap = new PcapClass();
            log.WriteToLog("Инициализация Pcap");
            devices =  pcap.GetListAllAdapters();
            return 0;
        }

        //Поддерживается ли
        public override bool IsSupport()
        {
            throw new NotImplementedException();
        }


        public override void Close()
        {

        }

        //Начать сбор пакетов
        public override int StartCapture(byte IdDevice)
        {
            pcap.OpenDevice(IdDevice, DeviceMode.Promiscuous);
            pcap.activeDevice.OnPacketArrival += new PacketArrivalEventHandler(OnRecieve);
            pcap.StartCapture();            
            recieved = true;
            return 0;
        }

        public void OnRecieve(object sender, CaptureEventArgs e)
        {
            PacketRawInfo args = new PacketRawInfo();
            args.data = e.Packet.Data;
            args.size = e.Packet.Data.Length;
            args.time = e.Packet.Timeval.Date;
            args.linkLayer = LinkLayers.Ethernet;
                
            PacketsInfo.AddToQueue(args);
        }


        //Остановить сбор пакетов
        public override int StopCapture()
        {
            pcap.StopCapture();
            pcap.activeDevice.OnPacketArrival -= new PacketArrivalEventHandler(OnRecieve);
            recieved = false;
            return 0;
        }


    }
}
