using System;
using System.Collections.Generic;
using System.Web;

namespace HexSalesIF_Service.util
{
    public interface ILogger
    {
        void Debug(string info);
        void Info(string info);
        void Error(string info);
        void Exception(string info);
    }

    public class WebLogger : ILogger
    {
        public void Debug(string info)
        {
            throw new NotImplementedException();
        }

        public void Error(string info)
        {
            throw new NotImplementedException();
        }

        public void Exception(string info)
        {
            throw new NotImplementedException();
        }

        public void Info(string info)
        {
            throw new NotImplementedException();
        }
    }
}