using System;
using System.Configuration;

namespace HardkorowyKodsu.UI.Helpers
{
    public class Setting
    {
        private static readonly Lazy<Setting> _instance = new Lazy<Setting>(() => new Setting());

        public static Setting Instance => _instance.Value;

        public string UrlBase { get; }
        public string GetVersionUrl { get; }
        public string GetAllTablesUrl { get; }
        public string GetAllColumnsUrl { get; }

        private Setting()
        {
            UrlBase = ConfigurationManager.AppSettings["UrlBase"];
            GetVersionUrl = ConfigurationManager.AppSettings["GetVersionUrl"];
            GetAllTablesUrl = ConfigurationManager.AppSettings["GetAllTablesUrl"];
            GetAllColumnsUrl = ConfigurationManager.AppSettings["GetAllColumnsUrl"];
        }
    }

}
