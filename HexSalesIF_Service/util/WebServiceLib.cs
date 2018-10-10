using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.util
{
    public class WebServiceLib
    {
        public static string NewLineString(string data)
        {
            if (string.IsNullOrEmpty(data)){
                return "";
            }
            data = data.Replace("~", "\n").Replace("\r", "");
            return data;
        }

        public static string SubStr(string s,  int len)
        {
            if (string.IsNullOrEmpty(s)) { return ""; }

            if (s.Length < len)
            {
                return s;
            }

            string newStr = s.Substring(0, len);
            newStr = newStr + "...";
            return newStr;
        }
    }
}