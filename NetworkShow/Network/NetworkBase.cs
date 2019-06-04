using System;
using System.Collections.Generic;
using System.Text;
using NetworkShow.Network.Packets;

namespace NetworkShow.Network
{
    public delegate void ReceiveEventHandler(object sender, PacketRawInfo e);

    abstract class NetworkBase
    {    
        
        protected device[] devices;

        //Лог файл
        public LogWriter log;
        

        public bool recieved = false;

        private static object QueueLock = new object();
        //private static List<PacketInfo> PacketQueue = new List<PacketInfo>();
        private static List<PacketRawInfo> PacketQueue = new List<PacketRawInfo>();

        //Добавить в очередь
        /*public void AddToQueue3(PacketRawInfo packet)
        {
            lock (QueueLock)
            {
                PacketQueue.Add(packet);
//                ParseData(packet);
            }            
        }*/

        //ВОзвращает Количество поддерживаемых устройств
        public int CountDevices
        {
            get
            {
                if (devices == null)
                    return 0;
                else
                    return devices.Length;
            }            
        }


        //Инициализация
        abstract public int Init();
        //1. Получаем список сетевых адаптеров в системе
        
        abstract public void Close();

        //Начать сбор пакетов
        abstract public int StartCapture(byte IdDevice);

        //Остановить сбор пакетов
        abstract public int StopCapture();

        abstract public bool IsSupport();

        //Возвращает описание по индексу.
        virtual public device GetInfoAboutDeviceFromIndex(int index)
        {
            return devices[index];
        }
    }
}
