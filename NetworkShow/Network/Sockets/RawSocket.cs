using System;
using System.Collections.Generic;
using System.Text;
using NetworkShow.Network;
using System.Net;

namespace NetworkShow.Network.Sockets
{
    class RawSocket: NetworkBase
    {
        SocketClass mainSocket;
         
        //Инициализация
        public override int Init()
        {
            //Создаем скласс сокета
            log = LogWriter.Instance;
            mainSocket= new SocketClass();
            //Получаем список всех сетевых устройств в системе
            devices = mainSocket.GetListAllAdapters();
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


        /*public override void ParseData(object obj, RecieveByteArgs args)
        {
            
            log.WriteToLog("Получены данные - "+args.time );                        
        }
        */
        //Начать сбор пакетов
        public override int StartCapture(byte IdDevice)
        {
            IPAddress ipAddress = GetInfoAboutDeviceFromIndex(IdDevice).IP[0];
            if (mainSocket.CreateSocket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Raw, System.Net.Sockets.ProtocolType.IP, ipAddress) == eResultCode.noerror)
            {
                mainSocket.BeginReceive(System.Net.Sockets.SocketFlags.None);
                mainSocket.ReceiveEvent += new ReceiveEventHandler(OnRecieve);
                recieved = true;
                return 0;
            }
            return 1;
        }


        public void OnRecieve(object obj, PacketRawInfo args)
        {
            PacketsInfo.AddToQueue(args);
            //AddToQueue(args);
        }

        //Остановить сбор пакетов
        public override int StopCapture()
        {
            if (recieved)
                mainSocket.StopReceive();
            recieved = false;
            return 0;
        }
    

    }
}
