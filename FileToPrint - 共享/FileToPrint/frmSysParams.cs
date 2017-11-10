using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShareSync
{
    public partial class frmSysParams : Form
    {
        public frmSysParams()
        {
            InitializeComponent();
        }

        private void frmSysParams_Load(object sender, EventArgs e)
        {
            chkWriteLog.Checked = SysParams.Instance.IsWriteLog;

            edtLocalFileLocation.Text = SysParams.Instance.LocalFileSaveLocation;
            edtpwd.Text = SysParams.Instance.Pwd;
            edtuid.Text = SysParams.Instance.Uid;
            edtpath.Text = SysParams.Instance.NetPath;
            edtmap.Text = SysParams.Instance.DiskMap;
            edtsubpath.Text = SysParams.Instance.NetFilePath;
            cboFileType.Text = SysParams.Instance.FileType;

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SysParams.Instance.IsWriteLog = chkWriteLog.Checked;

            SysParams.Instance.LocalFileSaveLocation = edtLocalFileLocation.Text.Trim();
            SysParams.Instance.Pwd = edtpwd.Text.Trim();
            SysParams.Instance.Uid = edtuid.Text.Trim();
            SysParams.Instance.NetPath = edtpath.Text.Trim();
            SysParams.Instance.DiskMap = edtmap.Text.Trim();
            SysParams.Instance.NetFilePath = edtsubpath.Text.Trim();
            SysParams.Instance.FileType = cboFileType.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_localpathchose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择本地文件存放目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                edtLocalFileLocation.Text = folder.SelectedPath;
            }
        }


        private void btn_localpathopen_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(edtLocalFileLocation.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
