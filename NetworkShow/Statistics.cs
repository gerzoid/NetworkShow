using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkShow
{
    public static class Statistics
    {
        static int incomingPacketsCount = 0;
        static int incomingPacketsLength = 0;

        static int outgoingPacketsCount = 0;
        static int outgoingPacketsLength = 0;

        static int incomingIPPacketsCount = 0;
        static int incomingIPPacketsLength = 0;
        static int outgoingIPPacketsCount = 0;
        static int outgoingIPPacketsLength = 0;

        static int incomingTCPPacketsCount = 0;
        static int incomingTCPPacketsLength = 0;
        static int outgoingTCPPacketsCount = 0;
        static int outgoingTCPPacketsLength = 0;

        static int incomingUDPPacketsCount = 0;
        static int incomingUDPPacketsLength = 0;
        static int outgoingUDPPacketsCount = 0;
        static int outgoingUDPPacketsLength = 0;

        static int incomingICMPPacketsCount = 0;
        static int incomingICMPPacketsLength = 0;
        static int outgoingICMPPacketsCount = 0;
        static int outgoingICMPPacketsLength = 0;

        static int incomingIGMPPacketsCount = 0;
        static int incomingIGMPPacketsLength = 0;
        static int outgoingIGMPPacketsCount = 0;
        static int outgoingIGMPPacketsLength = 0;

        static int incomingARPPacketsCount = 0;
        static int incomingARPPacketsLength = 0;
        static int outgoingARPPacketsCount = 0;
        static int outgoingARPPacketsLength = 0;

        public static void AddToPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingPacketsCount++;
                incomingPacketsLength += length;
            }
            else
            {
                outgoingPacketsCount++;
                outgoingPacketsLength += length;
            }

        }

        public static void AddToIPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingIPPacketsCount++;
                incomingIPPacketsLength += length;
            }
            else
            {
                outgoingIPPacketsCount++;
                outgoingIPPacketsLength += length;
            }

        }

        public static void AddToTCPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingTCPPacketsCount++;
                incomingTCPPacketsLength += length;
            }
            else
            {
                outgoingTCPPacketsCount++;
                outgoingTCPPacketsLength += length;
            }

        }

        public static void AddToUDPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingUDPPacketsCount++;
                incomingUDPPacketsLength += length;
            }
            else
            {
                outgoingUDPPacketsCount++;
                outgoingUDPPacketsLength += length;
            }

        }

        public static void AddToICMPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingICMPPacketsCount++;
                incomingICMPPacketsLength += length;
            }
            else
            {
                outgoingICMPPacketsCount++;
                outgoingICMPPacketsLength += length;
            }

        }

        public static void AddToIGMPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingIGMPPacketsCount++;
                incomingIGMPPacketsLength += length;
            }
            else
            {
                outgoingIGMPPacketsCount++;
                outgoingIGMPPacketsLength += length;
            }

        }

        public static void AddToARPPacketsStats(int length, bool incoming)
        {
            if (incoming)
            {
                incomingARPPacketsCount++;
                incomingARPPacketsLength += length;
            }
            else
            {
                outgoingARPPacketsCount++;
                outgoingARPPacketsLength += length;
            }

        }
    }
}
