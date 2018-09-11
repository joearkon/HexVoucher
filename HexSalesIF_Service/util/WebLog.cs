using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace HexSalesIF_Service.util
{
    public static class LogHelper
    {
          private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger("DEBUG");
  
          public static void Info(string info)
          {
             Logger.Info(info);
          }
  
         public static void Error(string info)
         {
             Logger.Error(info);
         }
 
         public static void Debug(string info)
         {
            Logger.Debug(info);
         }
 
         public static void Exception(Exception exception)
         {
             Logger.Debug(exception.Message, exception);
         }
     }
}