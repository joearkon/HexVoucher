using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;

namespace HexSalesIF_Service.util
{
    /// <summary>
    ///配置获取接口
    /// </summary>
    public interface IConfigReader
    {
        /// <summary>
        /// 获取key
        /// </summary>
        /// <param name="key">key name</param>
        /// <param name="def">default</param>
        /// <returns></returns>
        string GetAppSetting(string key, string def);

    }
    public class WebConfigReader : IConfigReader
    {
        public string GetAppSetting(string key, string def)
        {
            try
            {
                return ConfigurationManager.AppSettings[key].ToString();
            }
            catch
            {
                return def;
            }
        }
    }
}