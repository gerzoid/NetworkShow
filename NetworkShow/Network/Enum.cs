using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkShow.Network
{
    public enum SupportedTypeSniff
    {
        SharpPcap,
        Socket
    }

    public enum eResultCode
    {
        noerror = 0,
        error = 1
    }

    public enum Protocol : byte
    {
        /// <summary>
        /// IPv6 Hop-by-Hop Option RFC 2460   
        /// </summary>
        IpV6HopByHopOption = 0x00,
        /// <summary>
        /// Internet Control Message Protocol RFC 792   
        /// </summary>
        InternetControlMessageProtocol = 0x01,
        /// <summary>
        /// Internet Group Management Protocol RFC 1112   
        /// </summary>
        InternetGroupManagementProtocol = 0x02,
        /// <summary>
        /// Gateway-to-Gateway Protocol RFC 823   
        /// </summary>
        GatewayToGateway = 0x03,
        /// <summary>
        /// IP in IP (encapsulation) RFC 2003   
        /// </summary>
        Ip = 0x04,
        /// <summary>
        /// Internet Stream Protocol RFC 1190, RFC 1819   
        /// </summary>
        Stream = 0x05,
        /// <summary>
        /// Transmission Control Protocol RFC 793   
        /// </summary>
        Tcp = 0x06,
        /// <summary>
        /// CBT   
        /// </summary>
        Cbt = 0x07,
        /// <summary>
        /// Exterior Gateway Protocol RFC 888   
        /// </summary>
        ExteriorGatewayProtocol = 0x08,
        /// <summary>
        /// Interior Gateway Protocol (any private interior gateway (used by Cisco for their IGRP))   
        /// </summary>
        InteriorGatewayProtocol = 0x09,
        /// <summary>
        /// BBN RCC Monitoring   
        /// </summary>
        BbnRccMonitoring = 0x0A,
        /// <summary>
        /// Network Voice Protocol RFC 741   
        /// </summary>
        NetworkVoice = 0x0B,
        /// <summary>
        /// Xerox PUP   
        /// </summary>
        Pup = 0x0C,
        /// <summary>
        /// ARGUS   
        /// </summary>
        Argus = 0x0D,
        /// <summary>
        /// EMCON   
        /// </summary>
        Emcon = 0x0E,
        /// <summary>
        /// Cross Net Debugger IEN 158   
        /// </summary>
        CrossNetDebugger = 0x0F,
        /// <summary>
        /// Chaos   
        /// </summary>
        Chaos = 0x10,
        /// <summary>
        /// User Datagram Protocol RFC 768   
        /// </summary>
        Udp = 0x11,
        /// <summary>
        /// Multiplexing IEN 90   
        /// </summary>
        Multiplexing = 0x12,
        /// <summary>
        /// DCN Measurement Subsystems   
        /// </summary>
        DcnMeasurement = 0x13,
        /// <summary>
        /// Host Monitoring Protocol RFC 869   
        /// </summary>
        HostMonitoringProtocol = 0x14,
        /// <summary>
        /// Packet Radio Measurement   
        /// </summary>
        PacketRadioMeasurement = 0x15,
        /// <summary>
        /// XEROX NS IDP   
        /// </summary>
        XeroxNsInternetDatagramProtocol = 0x16,
        /// <summary>
        /// Trunk-1   
        /// </summary>
        Trunk1 = 0x17,
        /// <summary>
        /// Trunk-2   
        /// </summary>
        Trunk2 = 0x18,
        /// <summary>
        /// Leaf-1   
        /// </summary>
        Leaf1 = 0x19,
        /// <summary>
        /// Leaf-2   
        /// </summary>
        Leaf2 = 0x1A,
        /// <summary>
        /// Reliable Datagram Protocol RFC 908   
        /// </summary>
        ReliableDatagramProtocol = 0x1B,
        /// <summary>
        /// Internet Reliable Transaction Protocol RFC 938   
        /// </summary>
        InternetReliableTransactionProtocol = 0x1C,
        /// <summary>
        /// ISO Transport Protocol Class 4 RFC 905   
        /// </summary>
        IsoTransportProtocolClass4 = 0x1D,
        /// <summary>
        /// Bulk Data Transfer Protocol RFC 998   
        /// </summary>
        BulkDataTransferProtocol = 0x1E,
        /// <summary>
        /// MFE Network Services Protocol   
        /// </summary>
        MagneticFusionEnergyNetworkServicesProtocol = 0x1F,
        /// <summary>
        /// MERIT Internodal Protocol   
        /// </summary>
        MeritInternodalProtocol = 0x20,
        /// <summary>
        /// Datagram Congestion Control Protocol RFC 4340   
        /// </summary>
        DatagramCongestionControlProtocol = 0x21,
        /// <summary>
        /// Third Party Connect Protocol   
        /// </summary>
        ThirdPartyConnect = 0x22,
        /// <summary>
        /// Inter-Domain Policy Routing Protocol RFC 1479   
        /// </summary>
        InterDomainPolicyRoutingProtocol = 0x23,
        /// <summary>
        /// Xpress Transport Protocol   
        /// </summary>
        XpressTransportProtocol = 0x24,
        /// <summary>
        /// Datagram Delivery Protocol   
        /// </summary>
        DatagramDeliveryProtocol = 0x25,
        /// <summary>
        /// IDPR Control Message Transport Protocol   
        /// </summary>
        InterDomainPolicyRoutingProtocolControlMessageTransportProtocol = 0x26,
        /// <summary>
        /// TP++ Transport Protocol   
        /// </summary>
        TransportProtocolPlusPlus = 0x27,
        /// <summary>
        /// IL Transport Protocol   
        /// </summary>
        Il = 0x28,
        /// <summary>
        /// IPv6 RFC 2460   
        /// </summary>
        IpV6 = 0x29,
        /// <summary>
        /// Source Demand Routing Protocol   
        /// </summary>
        SourceDemandRoutingProtocol = 0x2A,
        /// <summary>
        /// Routing Header for IPv6 RFC 2460   
        /// </summary>
        IpV6Route = 0x2B,
        /// <summary>
        /// Fragment Header for IPv6 RFC 2460   
        /// </summary>
        FragmentHeaderForIpV6 = 0x2C,
        /// <summary>
        /// Inter-Domain Routing Protocol   
        /// </summary>
        InterDomainRoutingProtocol = 0x2D,
        /// <summary>
        /// Resource Reservation Protocol   
        /// </summary>
        Rsvp = 0x2E,
        /// <summary>
        /// Generic Routing Encapsulation   
        /// </summary>
        Gre = 0x2F,
        /// <summary>
        /// Mobile Host Routing Protocol   
        /// </summary>
        MobileHostRoutingProtocol = 0x30,
        /// <summary>
        /// BNA   
        /// </summary>
        Bna = 0x31,
        /// <summary>
        /// Encapsulating Security Payload RFC 2406   
        /// </summary>
        Esp = 0x32,
        /// <summary>
        /// Authentication Header RFC 2402   
        /// </summary>
        AuthenticationHeader = 0x33,
        /// <summary>
        /// Integrated Net Layer Security Protocol TUBA   
        /// </summary>
        IntegratedNetLayerSecurityProtocol = 0x34,
        /// <summary>
        /// IP with Encryption   
        /// </summary>
        Swipe = 0x35,
        /// <summary>
        /// NBMA Address Resolution Protocol RFC 1735   
        /// </summary>
        NArp = 0x36,
        /// <summary>
        /// IP Mobility (Min Encap) RFC 2004   
        /// </summary>
        Mobile = 0x37,
        /// <summary>
        /// Transport Layer Security Protocol (using Kryptonet key management)   
        /// </summary>
        TransportLayerSecurityProtocol = 0x38,
        /// <summary>
        /// Simple Key-Management for Internet Protocol RFC 2356   
        /// </summary>
        Skip = 0x39,
        /// <summary>
        /// ICMP for IPv6 RFC 2460   
        /// </summary>
        InternetControlMessageProtocolForIpV6 = 0x3A,
        /// <summary>
        /// No Next Header for IPv6 RFC 2460   
        /// </summary>
        NoNextHeaderForIpV6 = 0x3B,
        /// <summary>
        /// Destination Options for IPv6 RFC 2460   
        /// </summary>
        IpV6Opts = 0x3C,
        /// <summary>
        /// Any host internal protocol   
        /// </summary>
        AnyHostInternal = 0x3D,
        /// <summary>
        /// CFTP   
        /// </summary>
        Cftp = 0x3E,
        /// <summary>
        /// Any local network   
        /// </summary>
        AnyLocalNetwork = 0x3F,
        /// <summary>
        /// SATNET and Backroom EXPAK   
        /// </summary>
        SatnetAndBackroomExpak = 0x40,
        /// <summary>
        /// Kryptolan   
        /// </summary>
        Kryptolan = 0x41,
        /// <summary>
        /// MIT Remote Virtual Disk Protocol   
        /// </summary>
        RemoteVirtualDiskProtocol = 0x42,
        /// <summary>
        /// Internet Pluribus Packet Core   
        /// </summary>
        InternetPluribusPacketCore = 0x43,
        /// <summary>
        /// Any distributed file system   
        /// </summary>
        AnyDistributedFileSystem = 0x44,
        /// <summary>
        /// SATNET Monitoring   
        /// </summary>
        SatMon = 0x45,
        /// <summary>
        /// VISA Protocol   
        /// </summary>
        Visa = 0x46,
        /// <summary>
        /// Internet Packet Core Utility   
        /// </summary>
        InternetPacketCoreUtility = 0x47,
        /// <summary>
        /// Computer Protocol Network Executive   
        /// </summary>
        ComputerProtocolNetworkExecutive = 0x48,
        /// <summary>
        /// Computer Protocol Heart Beat   
        /// </summary>
        ComputerProtocolHeartbeat = 0x49,
        /// <summary>
        /// Wang Span Network   
        /// </summary>
        WangSpanNetwork = 0x4A,
        /// <summary>
        /// Packet Video Protocol   
        /// </summary>
        PacketVideoProtocol = 0x4B,
        /// <summary>
        /// Backroom SATNET Monitoring   
        /// </summary>
        BackroomSatMon = 0x4C,
        /// <summary>
        /// SUN ND PROTOCOL-Temporary   
        /// </summary>
        SunNd = 0x4D,
        /// <summary>
        /// WIDEBAND Monitoring   
        /// </summary>
        WidebandMonitoring = 0x4E,
        /// <summary>
        /// WIDEBAND EXPAK   
        /// </summary>
        WidebandExpak = 0x4F,
        /// <summary>
        /// International Organization for Standardization Internet Protocol   
        /// </summary>
        IsoIp = 0x50,
        /// <summary>
        /// Versatile Message Transaction Protocol RFC 1045   
        /// </summary>
        VersatileMessageTransactionProtocol = 0x51,
        /// <summary>
        /// Secure Versatile Message Transaction Protocol RFC 1045   
        /// </summary>
        SecureVersatileMessageTransactionProtocol = 0x52,
        /// <summary>
        /// VINES   
        /// </summary>
        Vines = 0x53,
        /// <summary>
        /// TTP   
        /// </summary>
        Ttp = 0x54,
        /// <summary>
        /// NSFNET-IGP   
        /// </summary>
        NationalScienceFoundationNetworkInteriorGatewayProtocol = 0x55,
        /// <summary>
        /// Dissimilar Gateway Protocol   
        /// </summary>
        DissimilarGatewayProtocol = 0x56,
        /// <summary>
        /// TCF   
        /// </summary>
        Tcf = 0x57,
        /// <summary>
        /// Enhanced Interior Gateway Routing Protocol   
        /// </summary>
        EnhancedInteriorGatewayRoutingProtocol = 0x58,
        /// <summary>
        /// Open Shortest Path First RFC 1583   
        /// </summary>
        OpenShortestPathFirst = 0x59,
        /// <summary>
        /// Sprite RPC Protocol   
        /// </summary>
        SpriteRpc = 0x5A,
        /// <summary>
        /// Locus Address Resolution Protocol   
        /// </summary>
        LArp = 0x5B,
        /// <summary>
        /// Multicast Transport Protocol   
        /// </summary>
        MulticastTransportProtocol = 0x5C,
        /// <summary>
        /// AX.25   
        /// </summary>
        Ax25 = 0x5D,
        /// <summary>
        /// IP-within-IP Encapsulation Protocol   
        /// </summary>
        IpIp = 0x5E,
        /// <summary>
        /// Mobile Internetworking Control Protocol   
        /// </summary>
        MobileInternetworkingControlProtocol = 0x5F,
        /// <summary>
        /// Semaphore Communications Sec. Pro   
        /// </summary>
        SemaphoreCommunicationsSecondProtocol = 0x60,
        /// <summary>
        /// Ethernet-within-IP Encapsulation RFC 3378   
        /// </summary>
        EtherIp = 0x61,
        /// <summary>
        /// Encapsulation Header RFC 1241   
        /// </summary>
        EncapsulationHeader = 0x62,
        /// <summary>
        /// Any private encryption scheme   
        /// </summary>
        AnyPrivateEncryptionScheme = 0x63,
        /// <summary>
        /// GMTP   
        /// </summary>
        Gmtp = 0x64,
        /// <summary>
        /// Ipsilon Flow Management Protocol   
        /// </summary>
        IpsilonFlowManagementProtocol = 0x65,
        /// <summary>
        /// PNNI over IP   
        /// </summary>
        PrivateNetworkToNetworkInterface = 0x66,
        /// <summary>
        /// Protocol Independent Multicast   
        /// </summary>
        Pin = 0x67,
        /// <summary>
        /// ARIS   
        /// </summary>
        Aris = 0x68,
        /// <summary>
        /// SCPS (Space Communications Protocol Standards)   
        /// </summary>
        SpaceCommunicationsProtocolStandards = 0x69,
        /// <summary>
        /// QNX   
        /// </summary>
        Qnx = 0x6A,
        /// <summary>
        /// Active Networks   
        /// </summary>
        ActiveNetworks = 0x6B,
        /// <summary>
        /// IP Payload Compression Protocol RFC 3173   
        /// </summary>
        IpComp = 0x6C,
        /// <summary>
        /// Sitara Networks Protocol   
        /// </summary>
        SitaraNetworksProtocol = 0x6D,
        /// <summary>
        /// Compaq Peer Protocol   
        /// </summary>
        CompaqPeer = 0x6E,
        /// <summary>
        /// IPX in IP   
        /// </summary>
        InternetworkPacketExchangeInIp = 0x6F,
        /// <summary>
        /// Virtual Router Redundancy Protocol, Common Address Redundancy Protocol (not IANA assigned) VRRP:RFC 3768   
        /// </summary>
        VirtualRouterRedundancyProtocol = 0x70,
        /// <summary>
        /// PGM Reliable Transport Protocol RFC 3208   
        /// </summary>
        PragmaticGeneralMulticastTransportProtocol = 0x71,
        /// <summary>
        /// Any 0-hop protocol   
        /// </summary>
        Any0HopProtocol = 0x72,
        /// <summary>
        /// Layer Two Tunneling Protocol   
        /// </summary>
        LayerTwoTunnelingProtocol = 0x73,
        /// <summary>
        /// D-II Data Exchange (DDX)   
        /// </summary>
        DiiDataExchange = 0x74,
        /// <summary>
        /// Interactive Agent Transfer Protocol   
        /// </summary>
        InteractiveAgentTransferProtocol = 0x75,
        /// <summary>
        /// Schedule Transfer Protocol   
        /// </summary>
        ScheduleTransferProtocol = 0x76,
        /// <summary>
        /// SpectraLink Radio Protocol   
        /// </summary>
        SpectraLinkRadioProtocol = 0x77,
        /// <summary>
        /// UTI   
        /// </summary>
        Uti = 0x78,
        /// <summary>
        /// Simple Message Protocol   
        /// </summary>
        SimpleMessageProtocol = 0x79,
        /// <summary>
        /// SM   
        /// </summary>
        Sm = 0x7A,
        /// <summary>
        /// Performance Transparency Protocol   
        /// </summary>
        PerformanceTransparencyProtocol = 0x7B,
        /// <summary>
        /// IS-IS over IPv4   
        /// </summary>
        IsIsOverIpV4 = 0x7C,
        /// <summary>
        ///   
        /// </summary>
        Fire = 0x7D,
        /// <summary>
        /// Combat Radio Transport Protocol   
        /// </summary>
        CombatRadioTransportProtocol = 0x7E,
        /// <summary>
        /// Combat Radio User Datagram   
        /// </summary>
        CombatRadioUserDatagram = 0x7F,
        /// <summary>
        ///   
        /// </summary>
        ServiceSpecificConnectionOrientedProtocolInAMultilinkAndConnectionlessEnvironment = 0x80,
        /// <summary>
        ///   
        /// </summary>
        Iplt = 0x81,
        /// <summary>
        /// Secure Packet Shield   
        /// </summary>
        SecurePacketShield = 0x82,
        /// <summary>
        /// Private IP Encapsulation within IP Expired I-D draft-petri-mobileip-pipe-00.txt   
        /// </summary>
        Pipe = 0x83,
        /// <summary>
        /// Stream Control Transmission Protocol   
        /// </summary>
        StreamControlTransmissionProtocol = 0x84,
        /// <summary>
        /// Fibre Channel   
        /// </summary>
        FibreChannel = 0x85,
        /// <summary>
        /// RSVP-E2E-IGNORE RFC 3175   
        /// </summary>
        RsvpE2EIgnore = 0x86,
        /// <summary>
        /// Mobility Header RFC 3775   
        /// </summary>
        MobilityHeader = 0x87,
        /// <summary>
        /// UDP Lite RFC 3828   
        /// </summary>
        UdpLite = 0x88,
        /// <summary>
        /// MPLS-in-IP RFC 4023   
        /// </summary>
        MultiprotocolLabelSwitchingInIp = 0x89,
        /// <summary>
        /// MANET Protocols I-D draft-ietf-manet-iana-07.txt   
        /// </summary>
        MobileAdHocNetwork = 0x8A,
        /// <summary>
        /// Host Identity Protocol RFC 5201   
        /// </summary>
        Hip = 0x8B
    }

    //Для парсинга поля EtherType в  заголовке Ethernet
    public enum EthernetPacketType : ushort
    {
        /// <summary>
        /// No Ethernet type
        /// </summary>
        None = 0x0000,
        /// <summary>
        /// Internet Protocol, Version 4 (IPv4)
        /// </summary>
        IpV4 = 0x0800,
        /// <summary>
        /// Address Resolution Protocol (ARP)
        /// </summary>
        Arp = 0x0806,
        /// <summary>
        /// Reverse Address Resolution Protocol (RARP)
        /// </summary>
        ReverseArp = 0x8035,
        /// <summary>
        /// Wake-On-Lan (WOL)
        /// </summary>
        WakeOnLan = 0x0842,
        /// <summary>
        /// AppleTalk (Ethertalk)
        /// </summary>
        AppleTalk = 0x809B,
        /// <summary>
        /// AppleTalk Address Resolution Protocol (AARP)
        /// </summary>
        AppleTalkArp = 0x80F3,
        /// <summary>
        /// VLAN-tagged frame (IEEE 802.1Q)
        /// </summary>
        VLanTaggedFrame = 0x8100,
        /// <summary>
        /// Novell IPX (alt)
        /// </summary>
        NovellInternetworkPacketExchange = 0x8137,
        /// <summary>
        /// Novell
        /// </summary>
        Novell = 0x8138,
        /// <summary>
        /// Internet Protocol, Version 6 (IPv6)
        /// </summary>
        IpV6 = 0x86DD,
        /// <summary>
        /// MAC Control
        /// </summary>
        MacControl = 0x8808,
        /// <summary>
        /// CobraNet
        /// </summary>
        CobraNet = 0x8819,
        /// <summary>
        /// MPLS unicast
        /// </summary>
        MultiprotocolLabelSwitchingUnicast = 0x8847,
        /// <summary>
        /// MPLS multicast
        /// </summary>
        MultiprotocolLabelSwitchingMulticast = 0x8848,
        /// <summary>
        /// PPPoE Discovery Stage
        /// </summary>
        PointToPointProtocolOverEthernetDiscoveryStage = 0x8863,
        /// <summary>
        /// PPPoE Session Stage
        /// </summary>
        PointToPointProtocolOverEthernetSessionStage = 0x8864,
        /// <summary>
        /// EAP over LAN (IEEE 802.1X)
        /// </summary>
        ExtensibleAuthenticationProtocolOverLan = 0x888E,
        /// <summary>
        /// HyperSCSI (SCSI over Ethernet)
        /// </summary>
        HyperScsi = 0x889A,
        /// <summary>
        /// ATA over Ethernet
        /// </summary>
        AtaOverEthernet = 0x88A2,
        /// <summary>
        /// EtherCAT Protocol
        /// </summary>
        EtherCatProtocol = 0x88A4,
        /// <summary>
        /// Provider Bridging (IEEE 802.1ad)
        /// </summary>
        ProviderBridging = 0x88A8,
        /// <summary>
        /// AVB Transport Protocol (AVBTP)
        /// </summary>
        AvbTransportProtocol = 0x88B5,
        /// <summary>
        /// Link Layer Discovery Protocol (LLDP)
        /// </summary>
        LLDP = 0x88CC,
        /// <summary>
        /// SERCOS III
        /// </summary>
        SerialRealTimeCommunicationSystemIii = 0x88CD,
        /// <summary>
        /// Circuit Emulation Services over Ethernet (MEF-8)
        /// </summary>
        CircuitEmulationServicesOverEthernet = 0x88D8,
        /// <summary>
        /// HomePlug
        /// </summary>
        HomePlug = 0x88E1,
        /// <summary>
        /// MAC security (IEEE 802.1AE)
        /// </summary>
        MacSecurity = 0x88E5,
        /// <summary>
        /// Precision Time Protocol (IEEE 1588)
        /// </summary>
        PrecisionTimeProtocol = 0x88f7,
        /// <summary>
        /// IEEE 802.1ag Connectivity Fault Management (CFM) Protocol / ITU-T Recommendation Y.1731 (OAM)
        /// </summary>
        ConnectivityFaultManagementOrOperationsAdministrationManagement = 0x8902,
        /// <summary>
        /// Fibre Channel over Ethernet
        /// </summary>
        FibreChannelOverEthernet = 0x8906,
        /// <summary>
        /// FCoE Initialization Protocol
        /// </summary>
        FibreChannelOverEthernetInitializationProtocol = 0x8914,
        /// <summary>
        /// Q-in-Q
        /// </summary>
        QInQ = 0x9100,
        /// <summary>
        /// Veritas Low Latency Transport (LLT)
        /// </summary>
        VeritasLowLatencyTransport = 0xCAFE,
        /// <summary>
        /// Ethernet loopback packet
        /// </summary>
        Loop = 0x0060,
        /// <summary>
        /// Ethernet echo packet
        /// </summary>
        Echo = 0x0200
    }
    
    //Для передачи в функцию ParseData, что бы отделять Ethernet кадры через SharpPcap и IP пакетов через сокеты
    public enum LinkLayers
    {
        Null = 0,
        Ethernet = 1,
        ExperimentalEthernet3MB = 2,
        AmateurRadioAX25 = 3,
        ProteonProNetTokenRing = 4,
        Chaos = 5,
        Ieee802 = 6,
        ArcNet = 7,
        Slip = 8,
        Ppp = 9,
        Fddi = 10,
        AtmRfc1483 = 11,
        Raw = 12,
        SlipBSD = 15,
        PppBSD = 16,
        AtmClip = 19,
        PppSerial = 50,
        CiscoHDLC = 104,
        Ieee80211 = 105,
        Loop = 108,
        LinuxSLL = 113,
        Ieee80211_Radio = 127,
        PerPacketInformation = 192,
    }
    
}
