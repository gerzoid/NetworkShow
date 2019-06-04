using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkShow
{
    public static class Utils
    {
        //Возвращает массив byte строкой в HEX
        public static string GetString(byte[] Byte, int Offset, int Length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = Offset; i < Offset + Length; i++)
            {
                sb.AppendFormat("{0:x2} ", Byte[i]);
            }
            return sb.ToString();
        }

        //Преобразует в MAC вида ZZ:ZZ:ZZ:ZZ:ZZ:ZZ
        public static string ToMAC(string mac)
        {
            mac = mac.Insert(2, ":").Insert(5, ":").Insert(8, ":").Insert(11, ":").Insert(14, ":");
            return mac;
        }
    }

}
