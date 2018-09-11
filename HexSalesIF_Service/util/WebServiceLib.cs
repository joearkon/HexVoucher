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
    }
}