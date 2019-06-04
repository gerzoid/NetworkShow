using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace NetworkShow.Network.Packets
{
    public enum ICMPv4TypeCodes
    {
        EchoReply = 0,
        Unassigned1 = 256,
        Unassigned2 = 512,
        Unreachable_Net = 768,
        Unreachable_Host = 769,
        Unreachable_Protocol = 770,
        Unreachable_Port = 771,
        Unreachable_FragmentationNeeded = 772,
        Unreachable_SourceRouteFailed = 773,
        Unreachable_DestinationNetworkUnknown = 774,
        Unreachable_DestinationHostUnknown = 775,
        Unreachable_SourceHostIsolated = 776,
        Unreachable_NetworkProhibited = 777,
        Unreachable_HostProhibited = 778,
        Unreachable_NetworkUnreachableForServiceType = 779,
        Unreachable_HostUnreachableForServiceType = 780,
        Unreachable_CommunicationProhibited = 781,
        Unreachable_HostPrecedenceViolation = 782,
        Unreachable_PrecedenceCutoffInEffect = 783,
        SourceQuench = 1024,
        AlternateHostAddress = 1280,
        Redirect_Network = 1280,
        Redirect_Host = 1281,
        Redirect_TypeOfServiceAndNetwork = 1282,
        Redirect_TypeOfServiceAndHost = 1283,
        Unassigned3 = 1792,
        EchoRequest = 2048,
        RouterAdvertisement = 2304,
        RouterSelection = 2560,
        TimeExceeded = 2816,
        Param_PointerIndicatesError = 3072,
        Param_MissingRequiredOption = 3073,
        Param_BadLength = 3074,
        Timestamp = 3328,
        TimestampReply = 3584,
        InformationRequest = 3840,
        InformationReply = 4096,
        AddressMaskRequest = 4352,
        AddressMaskReply = 4608,
        Reserved4Security = 4864,
        Reserved4robustnessExperiment1 = 5120,
        Reserved4robustnessExperiment2 = 5376,
        Reserved4robustnessExperiment3 = 5632,
        Reserved4robustnessExperiment4 = 5888,
        Reserved4robustnessExperiment5 = 6144,
        Reserved4robustnessExperiment6 = 6400,
        Reserved4robustnessExperiment7 = 6656,
        Reserved4robustnessExperiment8 = 6912,
        Reserved4robustnessExperiment9 = 7168,
        Reserved4robustnessExperiment10 = 7424,
        Traceroute = 7680,
        DatagramConversionError = 7936,
        MobileHostRedirect = 8192,
        IPv6WhereAreYou = 8448,
        IPv6IAmHere = 8704,
        MobileReqistrationRequest = 8960,
        MobileRegistrationReply = 9216,
        Skip = 9472,
        Photuri_BadSPI = 9728,
        Photuri_AuthenticationFailed = 9729,
        Photuri_DecompressionFailed = 9730,
        Photuri_DecryptionFailed = 9731,
        Photuri_NeedAuthentication = 9732,
        Photuri_NeedAuthorization = 9733,
    }    
    
    class ICMPHeader
    {
        //        private byte type;
        //      private byte cod;
        private ushort type;
        private ushort checkSum;
        private int size;

        public ICMPHeader(byte[] byBuffer, int nReceived)
        {
            MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nReceived);
            BinaryReader binaryReader = new BinaryReader(memoryStream);

            //            type = (byte)binaryReader.ReadByte();
            //            cod = (byte)IPAddress.NetworkToHostOrder(binaryReader.ReadByte());
            type = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
            checkSum = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
            size = nReceived;
        }

        public int Size
        {
            get { return size; }
        }
        public ICMPv4TypeCodes Type
        {
            get
            {
                return (ICMPv4TypeCodes)type;
            }

        }
    }
}
