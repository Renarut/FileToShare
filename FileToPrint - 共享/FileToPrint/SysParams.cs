using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ShareSync
{
    public class SysParams
    {
        private static SysParams _instance = null;

        private SysParams()
        {

        }
        public static SysParams Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SysParams();
                return _instance;
            }
        }
        /// <summary>
        /// 是否记录日志
        /// </summary>
        public bool IsWriteLog
        {
            get { return GetBoolean("WriteLog"); }
            set { SaveParams("WriteLog", value.ToString()); }
        }

        /// <summary>
        /// 程序自动更新配置文件来源
        /// </summary>
        public string UpgradeURL
        {
            get { return GetString("UpgradeURL"); }
            set { SaveParams("UpgradeURL", value); }
        }
        public string FileType
        {
            get { return GetString("Local file type"); }
            set { SaveParams("Local file type", value); }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Uid
        {
            get { return GetString("Uid"); }
            set { SaveParams("Uid", value); }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get { return GetString("Pwd"); }
            set { SaveParams("Pwd", value); }
        }
        /// <summary>
        /// 网络路径
        /// </summary>
        public string NetPath
        {
            get { return GetString("NetPath"); }
            set { SaveParams("NetPath", value); }
        }
        /// <summary>
        /// 网络文件夹路径
        /// </summary>
        public string NetFilePath
        {
            get { return GetString("NetFilePath"); }
            set { SaveParams("NetFilePath", value); }
        }
        /// <summary>
        /// 本地磁盘映射
        /// </summary>
        public string DiskMap
        {
            get { return GetString("DiskMap"); }
            set { SaveParams("DiskMap", value); }
        }
        
        /// <summary>
        /// 本地文件保存路径
        /// </summary>
        public string LocalFileSaveLocation
        {
            get { return GetString("Local file location"); }
            set { SaveParams("Local file location", value); }
        }

        private void SaveParams(string key, string value)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings[key] == null)
                config.AppSettings.Settings.Add(key, value);
            else
                config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private string GetString(string key)
        {
            string rlt = "";
            if (ConfigurationManager.AppSettings[key] != null)
            {
                rlt = ConfigurationManager.AppSettings[key];
            }
            return rlt;
        }

        private bool GetBoolean(string key)
        {
            bool rlt = false;
            if (ConfigurationManager.AppSettings[key] != null)
            {
                try { rlt = Convert.ToBoolean(ConfigurationManager.AppSettings[key]); }
                catch { rlt = false; }
            }
            return rlt;
        }
    }
}
