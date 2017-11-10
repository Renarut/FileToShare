using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShareSync
{
    public partial class frmFiletoFTP : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private string className =
            MethodBase.GetCurrentMethod().DeclaringType.FullName;
        private List<DoActionToFile> producers = new List<DoActionToFile>();
        private bool canClosed = false;
        private FormWindowState formStatus = FormWindowState.Minimized;
        private object lockArea = new object();
        private List<string> wait4ReadToxFile = new List<string>();

        public frmFiletoFTP()
        {
            InitializeComponent();
        }
        private void ClearProducers()
        {
            for (int i = 0; i < producers.Count; i++)
            {
                producers[i].Stop();
                producers[i].OutputLog -= OutputLog;
                producers[i] = null;
            }
            producers.Clear();
        }
        private void InitProducers()
        {
            ClearProducers();

            DoActionToFile producer =
                new DoActionToFile(
                    SysParams.Instance.NetPath,
                    SysParams.Instance.Uid,
                    SysParams.Instance.Pwd,
                    SysParams.Instance.DiskMap,
                    SysParams.Instance.FileType);

            producer.OutputLog += OutputLog;
            producer.Start();

            producers.Add(producer);
        }
        private void OutputLog(string msg, string modeName, ToolTipIcon icon)
        {
            WriteLog.Instance.Write(msg, modeName);

            edtLogs.Text += string.Format("{0}\r\n", msg);
            ShowMessageInBalloon(msg, icon, 5000);
        }
        private void ShowMessageInBalloon(
            string msg,
            ToolTipIcon icon = ToolTipIcon.None,
            int timeout = 1000)
        {
            string caption = "";
            switch (icon)
            {
                case ToolTipIcon.Error:
                    caption = "错误消息";
                    break;
                case ToolTipIcon.Info:
                    caption = "提示信息";
                    break;
                case ToolTipIcon.None:
                    return;
                case ToolTipIcon.Warning:
                    caption = "警告信息";
                    break;
            }
            notifyIcon.ShowBalloonTip(timeout, caption, msg, icon);
        }
        private void showfrmParams()
        {
            using (frmSysParams frmParams = new frmSysParams())
            {
                frmParams.ShowDialog();
                if (frmParams.DialogResult == DialogResult.OK)
                {
                    ClearProducers();
                    Thread.Sleep(100);
                    InitProducers();
                }
            }
        }
        private void btn_params_Click(object sender, EventArgs e)
        {
            showfrmParams();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitProducers();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ClearProducers();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            canClosed = true;
            Close();
        }

        private void tsmiConfiguration_Click(object sender, EventArgs e)
        {
            showfrmParams();
        }

        private void edtLogs_TextChanged(object sender, EventArgs e)
        {
            edtLogs.SelectionStart = edtLogs.Text.Length;
            edtLogs.ScrollToCaret();
        }

        private void ShowForm()
        {
            formStatus = FormWindowState.Normal;
            Show();
            ShowInTaskbar = true;
            Activate();
            SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
        }
        private void HideForm()
        {
            //方便操作工不隐藏窗口
            //return;
            formStatus = FormWindowState.Minimized;

            //if (WindowState == FormWindowState.Maximized)
            //    WindowState = FormWindowState.Normal;

            Hide();
            ShowInTaskbar = false;
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (formStatus == FormWindowState.Minimized)
            {
                ShowForm();
            }
            else
            {
                HideForm();
            }
        }

        private void frmFiletoPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClosed)
            {
                e.Cancel = false;
                notifyIcon.Visible = false;
            }
            else
            {
                e.Cancel = true;
                HideForm();
            }
        }

        private void frmFiletoPrint_Load(object sender, EventArgs e)
        {
            //方便操作工自动开始采集 
            btnStart_Click(sender, e);
        }

        private void frmFiletoPrint_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
