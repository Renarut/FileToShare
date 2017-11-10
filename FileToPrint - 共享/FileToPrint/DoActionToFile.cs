using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using System.Data;


namespace ShareSync
{
    public delegate void LogOutputHandler(string msg, string modeName, ToolTipIcon icon);

    internal class DoActionToFile
    {
        private string className =
            MethodBase.GetCurrentMethod().DeclaringType.FullName;


        private string uid = "";
        private string netpath = "";
        private string pwd = "";
        private string diskmap = "";
        private string Filetype="";

        /// <summary>
        /// 当前 ESB 连接状态
        /// 0: 未连接;
        /// 1: 正在连接中;
        /// 2: 连接成功
        /// </summary>
        private int esbConnectStatus = 0;
        /// <summary>
        /// 上次尝试 ESB 连接时间
        /// </summary>
        private DateTime lastESBConnectTime = DateTime.Now;
        /// <summary>
        /// 再次尝试连接 ESB 的间隔时间
        /// </summary>
        //private int esbReconnectSpantime = 60;

        private Timer tmReadFromxFile = new Timer();

        public DoActionToFile(string Netpath,string Uid,string Pwd,string Map,string filetype)
        {
            try
            {
                pwd = Pwd;
                uid = Uid;
                netpath= Netpath;
                diskmap = Map;
                Filetype = filetype;
                tmReadFromxFile.Interval = 5000;
                tmReadFromxFile.Tick += tmReadFromxFile_Tick;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        ~DoActionToFile()
        {
            tmReadFromxFile.Tick -= tmReadFromxFile_Tick;
        }


        private void tmReadFromxFile_Tick(object sender, EventArgs e)
        {
            string strProcedureName =
                string.Format(
                    "{0}.{1}",
                    className,
                    MethodBase.GetCurrentMethod().Name);
            tmReadFromxFile.Enabled = false;
            try
            {
                if (!Directory.Exists(SysParams.Instance.LocalFileSaveLocation))
                    Directory.CreateDirectory(SysParams.Instance.LocalFileSaveLocation);
                string _dataDir = SysParams.Instance.LocalFileSaveLocation;
                string[] fileList = Directory.GetFiles(_dataDir,Filetype);
                string filename;
                if (fileList.Length > 0)
                {
                    for (int i = 0; i < fileList.Length; i++)
                    {
                        filename =fileList[i];
                        try
                        {
                            NetworkConnection net = new NetworkConnection(diskmap, netpath, uid, pwd);

                            if (!net.Sync(fileList[i],SysParams.Instance.NetFilePath))
                            {
                                WriteLog("同步失败:" + net.ErrMsg, strProcedureName, ToolTipIcon.Error);
                            }
                            else
                            {
                                WriteLog(DateTime.Now.ToString()+"同步成功:" + filename, strProcedureName, ToolTipIcon.None);
                            }
                        }
                        catch (Exception ep)
                        {
                            WriteLog("同步失败:"+ep.Message, strProcedureName, ToolTipIcon.Error);
                        }

                    }
                }
            }
            catch (Exception error)
            {
                OutputLog(error.Message, strProcedureName, ToolTipIcon.Error);
            }
            finally
            {
                tmReadFromxFile.Enabled = true;
            }
        }

        public LogOutputHandler OutputLog = null;


        private void WriteLog(string msg, string modeName, ToolTipIcon icon)
        {
            if (OutputLog != null)
                OutputLog(msg, modeName, icon);
        }
        private void InitProducer()
        {
            string strProcedureName =
                string.Format(
                    "{0}.{1}",
                    className,
                    MethodBase.GetCurrentMethod().Name);

            WriteLog("正在连接远程文件夹 ......", strProcedureName, ToolTipIcon.Info);

            esbConnectStatus = 1;
            //连接测试
            NetworkConnection n = new NetworkConnection(diskmap, netpath, uid, pwd);

            if (n.TestNetWorkConnection())
            {
                esbConnectStatus = 2;
                WriteLog("远程文件夹 连接成功,开始同步文件...", strProcedureName, ToolTipIcon.Info);
                tmReadFromxFile.Enabled = true;
            }
            else
            {
                esbConnectStatus = 0;
                lastESBConnectTime = DateTime.Now;

                WriteLog(
                    
                        "连接失败:"+n.ErrMsg,
                    strProcedureName,
                    ToolTipIcon.Error);
            }
        }

        private void CloseProducer()
        {
            string strProcedureName =
                string.Format(
                    "{0}.{1}",
                    className,
                    MethodBase.GetCurrentMethod().Name);



            esbConnectStatus = 0;
            lastESBConnectTime = DateTime.Now;

            OutputLog("停止服务，关闭监听目录。", strProcedureName, ToolTipIcon.Info);
        }
        public void Start()
        {
            if (esbConnectStatus == 1 || esbConnectStatus == 2)
                return;
            else
            {
                InitProducer();
                
            }
        }

        public void Stop()
        {
            tmReadFromxFile.Enabled = false;
            CloseProducer();
        }
    }
}
