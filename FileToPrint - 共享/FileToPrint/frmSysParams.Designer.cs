namespace ShareSync
{
    partial class frmSysParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcSysParams = new System.Windows.Forms.TabControl();
            this.tpSysParams = new System.Windows.Forms.TabPage();
            this.chkWriteLog = new System.Windows.Forms.CheckBox();
            this.tpProgramParams = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.btn_localpathopen = new System.Windows.Forms.Button();
            this.btn_localpathchose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.edtLocalFileLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFtpParams = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edtpwd = new System.Windows.Forms.TextBox();
            this.edtmap = new System.Windows.Forms.TextBox();
            this.edtpath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtuid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtsubpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcSysParams.SuspendLayout();
            this.tpSysParams.SuspendLayout();
            this.tpProgramParams.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbFtpParams.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSysParams
            // 
            this.tcSysParams.Controls.Add(this.tpSysParams);
            this.tcSysParams.Controls.Add(this.tpProgramParams);
            this.tcSysParams.Controls.Add(this.tbFtpParams);
            this.tcSysParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSysParams.Location = new System.Drawing.Point(0, 0);
            this.tcSysParams.Name = "tcSysParams";
            this.tcSysParams.SelectedIndex = 0;
            this.tcSysParams.Size = new System.Drawing.Size(635, 471);
            this.tcSysParams.TabIndex = 0;
            // 
            // tpSysParams
            // 
            this.tpSysParams.Controls.Add(this.chkWriteLog);
            this.tpSysParams.Location = new System.Drawing.Point(4, 22);
            this.tpSysParams.Name = "tpSysParams";
            this.tpSysParams.Padding = new System.Windows.Forms.Padding(3);
            this.tpSysParams.Size = new System.Drawing.Size(608, 445);
            this.tpSysParams.TabIndex = 0;
            this.tpSysParams.Text = "系统参数";
            this.tpSysParams.UseVisualStyleBackColor = true;
            // 
            // chkWriteLog
            // 
            this.chkWriteLog.AutoSize = true;
            this.chkWriteLog.Location = new System.Drawing.Point(8, 373);
            this.chkWriteLog.Name = "chkWriteLog";
            this.chkWriteLog.Size = new System.Drawing.Size(96, 16);
            this.chkWriteLog.TabIndex = 0;
            this.chkWriteLog.Text = "是否记录日志";
            this.chkWriteLog.UseVisualStyleBackColor = true;
            // 
            // tpProgramParams
            // 
            this.tpProgramParams.Controls.Add(this.groupBox2);
            this.tpProgramParams.Location = new System.Drawing.Point(4, 22);
            this.tpProgramParams.Name = "tpProgramParams";
            this.tpProgramParams.Padding = new System.Windows.Forms.Padding(3);
            this.tpProgramParams.Size = new System.Drawing.Size(608, 445);
            this.tpProgramParams.TabIndex = 2;
            this.tpProgramParams.Text = "程序参数";
            this.tpProgramParams.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboFileType);
            this.groupBox2.Controls.Add(this.btn_localpathopen);
            this.groupBox2.Controls.Add(this.btn_localpathchose);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.edtLocalFileLocation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本地文件配置";
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Location = new System.Drawing.Point(101, 65);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(312, 20);
            this.cboFileType.TabIndex = 3;
            // 
            // btn_localpathopen
            // 
            this.btn_localpathopen.Location = new System.Drawing.Point(511, 19);
            this.btn_localpathopen.Name = "btn_localpathopen";
            this.btn_localpathopen.Size = new System.Drawing.Size(75, 23);
            this.btn_localpathopen.TabIndex = 2;
            this.btn_localpathopen.Text = "打开";
            this.btn_localpathopen.UseVisualStyleBackColor = true;
            this.btn_localpathopen.Click += new System.EventHandler(this.btn_localpathopen_Click);
            // 
            // btn_localpathchose
            // 
            this.btn_localpathchose.Location = new System.Drawing.Point(430, 19);
            this.btn_localpathchose.Name = "btn_localpathchose";
            this.btn_localpathchose.Size = new System.Drawing.Size(75, 23);
            this.btn_localpathchose.TabIndex = 2;
            this.btn_localpathchose.Text = "浏览...";
            this.btn_localpathchose.UseVisualStyleBackColor = true;
            this.btn_localpathchose.Click += new System.EventHandler(this.btn_localpathchose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(428, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "例：*.xml";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "文件格式：";
            // 
            // edtLocalFileLocation
            // 
            this.edtLocalFileLocation.Location = new System.Drawing.Point(101, 20);
            this.edtLocalFileLocation.Name = "edtLocalFileLocation";
            this.edtLocalFileLocation.Size = new System.Drawing.Size(312, 21);
            this.edtLocalFileLocation.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "文件读取路径：";
            // 
            // tbFtpParams
            // 
            this.tbFtpParams.Controls.Add(this.groupBox3);
            this.tbFtpParams.Location = new System.Drawing.Point(4, 22);
            this.tbFtpParams.Name = "tbFtpParams";
            this.tbFtpParams.Size = new System.Drawing.Size(627, 445);
            this.tbFtpParams.TabIndex = 3;
            this.tbFtpParams.Text = "共享文件夹参数";
            this.tbFtpParams.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edtpwd);
            this.groupBox3.Controls.Add(this.edtsubpath);
            this.groupBox3.Controls.Add(this.edtmap);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.edtpath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.edtuid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(8, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 164);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FTP参数";
            // 
            // edtpwd
            // 
            this.edtpwd.Location = new System.Drawing.Point(146, 48);
            this.edtpwd.Name = "edtpwd";
            this.edtpwd.PasswordChar = '*';
            this.edtpwd.Size = new System.Drawing.Size(287, 21);
            this.edtpwd.TabIndex = 6;
            // 
            // edtmap
            // 
            this.edtmap.Location = new System.Drawing.Point(146, 129);
            this.edtmap.Name = "edtmap";
            this.edtmap.Size = new System.Drawing.Size(287, 21);
            this.edtmap.TabIndex = 5;
            // 
            // edtpath
            // 
            this.edtpath.Location = new System.Drawing.Point(146, 75);
            this.edtpath.Name = "edtpath";
            this.edtpath.Size = new System.Drawing.Size(287, 21);
            this.edtpath.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "共享文件夹映射磁盘地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "用户名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "共享文件夹路径：";
            // 
            // edtuid
            // 
            this.edtuid.Location = new System.Drawing.Point(146, 21);
            this.edtuid.Name = "edtuid";
            this.edtuid.Size = new System.Drawing.Size(287, 21);
            this.edtuid.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "密码：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(400, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "子文件夹路径：";
            // 
            // edtsubpath
            // 
            this.edtsubpath.Location = new System.Drawing.Point(146, 102);
            this.edtsubpath.Name = "edtsubpath";
            this.edtsubpath.Size = new System.Drawing.Size(287, 21);
            this.edtsubpath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(439, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "例：sync\\  ,无则设为\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(439, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "例：Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(439, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "例：\\\\192.168.57.100\\share";
            // 
            // frmSysParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcSysParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSysParams";
            this.Text = "参数配置";
            this.Load += new System.EventHandler(this.frmSysParams_Load);
            this.tcSysParams.ResumeLayout(false);
            this.tpSysParams.ResumeLayout(false);
            this.tpSysParams.PerformLayout();
            this.tpProgramParams.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbFtpParams.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSysParams;
        private System.Windows.Forms.TabPage tpSysParams;
        private System.Windows.Forms.TabPage tpProgramParams;
        private System.Windows.Forms.CheckBox chkWriteLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_localpathopen;
        private System.Windows.Forms.Button btn_localpathchose;
        private System.Windows.Forms.TextBox edtLocalFileLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbFtpParams;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox edtpath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtpwd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtuid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtmap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtsubpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}