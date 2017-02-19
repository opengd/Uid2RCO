namespace Uid2RCO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorkerReaderMonitor = new System.ComponentModel.BackgroundWorker();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMinimized = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeState = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxMinimizeToTrayOnAppStart = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClipboardOutput = new System.Windows.Forms.TextBox();
            this.checkBoxOutputToForgroundWindow = new System.Windows.Forms.CheckBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.checkBoxClipboard = new System.Windows.Forms.CheckBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelOutputInfo = new System.Windows.Forms.Label();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.buttonReaderRefresh = new System.Windows.Forms.Button();
            this.labelReaderInfo = new System.Windows.Forms.Label();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStripMinimized.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.tabPageReader.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerReaderMonitor
            // 
            this.backgroundWorkerReaderMonitor.WorkerSupportsCancellation = true;
            this.backgroundWorkerReaderMonitor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReaderMonitor_DoWork);
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.BalloonTipText = "Uid2RCO";
            this.notifyIconApp.BalloonTipTitle = "Uid2RCO";
            this.notifyIconApp.ContextMenuStrip = this.contextMenuStripMinimized;
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "Uid2RCO";
            this.notifyIconApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconApp_MouseDoubleClick);
            // 
            // contextMenuStripMinimized
            // 
            this.contextMenuStripMinimized.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripMinimized.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClose,
            this.toolStripSeparator1,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemChangeState});
            this.contextMenuStripMinimized.Name = "contextMenuStrip1";
            this.contextMenuStripMinimized.Size = new System.Drawing.Size(245, 168);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(244, 38);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemChangeState
            // 
            this.toolStripMenuItemChangeState.Checked = true;
            this.toolStripMenuItemChangeState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemChangeState.Name = "toolStripMenuItemChangeState";
            this.toolStripMenuItemChangeState.Size = new System.Drawing.Size(244, 38);
            this.toolStripMenuItemChangeState.Text = "Enable";
            this.toolStripMenuItemChangeState.Click += new System.EventHandler(this.toolStripMenuItemChangeState_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 752);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxMinimizeToTrayOnAppStart);
            this.tabPage1.Controls.Add(this.checkBoxMinimizeToTray);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.groupBoxOutput);
            this.tabPage1.Controls.Add(this.checkBoxEnable);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTrayOnAppStart
            // 
            this.checkBoxMinimizeToTrayOnAppStart.AutoSize = true;
            this.checkBoxMinimizeToTrayOnAppStart.Checked = true;
            this.checkBoxMinimizeToTrayOnAppStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizeToTrayOnAppStart.Location = new System.Drawing.Point(17, 130);
            this.checkBoxMinimizeToTrayOnAppStart.Name = "checkBoxMinimizeToTrayOnAppStart";
            this.checkBoxMinimizeToTrayOnAppStart.Size = new System.Drawing.Size(383, 29);
            this.checkBoxMinimizeToTrayOnAppStart.TabIndex = 9;
            this.checkBoxMinimizeToTrayOnAppStart.Text = "Minimize to tray on application start";
            this.checkBoxMinimizeToTrayOnAppStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Checked = true;
            this.checkBoxMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(17, 76);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(195, 29);
            this.checkBoxMinimizeToTray.TabIndex = 8;
            this.checkBoxMinimizeToTray.Text = "Minimize to tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(484, 652);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 47);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.AutoSize = true;
            this.groupBoxOutput.Controls.Add(this.label1);
            this.groupBoxOutput.Controls.Add(this.textBoxClipboardOutput);
            this.groupBoxOutput.Controls.Add(this.checkBoxOutputToForgroundWindow);
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Controls.Add(this.checkBoxClipboard);
            this.groupBoxOutput.Controls.Add(this.labelOutput);
            this.groupBoxOutput.Controls.Add(this.labelOutputInfo);
            this.groupBoxOutput.Location = new System.Drawing.Point(4, 179);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(591, 452);
            this.groupBoxOutput.TabIndex = 6;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clipboard output text:";
            // 
            // textBoxClipboardOutput
            // 
            this.textBoxClipboardOutput.Location = new System.Drawing.Point(18, 246);
            this.textBoxClipboardOutput.Name = "textBoxClipboardOutput";
            this.textBoxClipboardOutput.Size = new System.Drawing.Size(420, 31);
            this.textBoxClipboardOutput.TabIndex = 6;
            this.textBoxClipboardOutput.Text = "%RCO%";
            // 
            // checkBoxOutputToForgroundWindow
            // 
            this.checkBoxOutputToForgroundWindow.AutoSize = true;
            this.checkBoxOutputToForgroundWindow.Checked = true;
            this.checkBoxOutputToForgroundWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOutputToForgroundWindow.Location = new System.Drawing.Point(18, 45);
            this.checkBoxOutputToForgroundWindow.Name = "checkBoxOutputToForgroundWindow";
            this.checkBoxOutputToForgroundWindow.Size = new System.Drawing.Size(307, 29);
            this.checkBoxOutputToForgroundWindow.TabIndex = 5;
            this.checkBoxOutputToForgroundWindow.Text = "Output to forground window";
            this.checkBoxOutputToForgroundWindow.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(18, 116);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(420, 31);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.Text = "%RCO%";
            // 
            // checkBoxClipboard
            // 
            this.checkBoxClipboard.AutoSize = true;
            this.checkBoxClipboard.Location = new System.Drawing.Point(18, 176);
            this.checkBoxClipboard.Name = "checkBoxClipboard";
            this.checkBoxClipboard.Size = new System.Drawing.Size(212, 29);
            this.checkBoxClipboard.TabIndex = 4;
            this.checkBoxClipboard.Text = "Copy to clipboard";
            this.checkBoxClipboard.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(13, 88);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(224, 25);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.Text = "Forground output text:";
            // 
            // labelOutputInfo
            // 
            this.labelOutputInfo.AutoSize = true;
            this.labelOutputInfo.Location = new System.Drawing.Point(13, 300);
            this.labelOutputInfo.Name = "labelOutputInfo";
            this.labelOutputInfo.Size = new System.Drawing.Size(290, 125);
            this.labelOutputInfo.TabIndex = 3;
            this.labelOutputInfo.Text = "Available variables:\r\n%RCO% = RCO\r\n%UID% = UID\r\n%TIME% = Timestamp\r\n%READER% = Re" +
    "ader name";
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.Checked = true;
            this.checkBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnable.Location = new System.Drawing.Point(17, 24);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(111, 29);
            this.checkBoxEnable.TabIndex = 0;
            this.checkBoxEnable.Text = "Enable";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            this.checkBoxEnable.Click += new System.EventHandler(this.checkBoxEnable_Click);
            // 
            // tabPageReader
            // 
            this.tabPageReader.Controls.Add(this.buttonReaderRefresh);
            this.tabPageReader.Controls.Add(this.labelReaderInfo);
            this.tabPageReader.Location = new System.Drawing.Point(8, 39);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(603, 705);
            this.tabPageReader.TabIndex = 1;
            this.tabPageReader.Text = "Card Reader";
            this.tabPageReader.UseVisualStyleBackColor = true;
            // 
            // buttonReaderRefresh
            // 
            this.buttonReaderRefresh.Location = new System.Drawing.Point(6, 6);
            this.buttonReaderRefresh.Name = "buttonReaderRefresh";
            this.buttonReaderRefresh.Size = new System.Drawing.Size(124, 41);
            this.buttonReaderRefresh.TabIndex = 1;
            this.buttonReaderRefresh.Text = "Refresh";
            this.buttonReaderRefresh.UseVisualStyleBackColor = false;
            this.buttonReaderRefresh.Click += new System.EventHandler(this.buttonReaderRefresh_Click);
            // 
            // labelReaderInfo
            // 
            this.labelReaderInfo.AutoSize = true;
            this.labelReaderInfo.Location = new System.Drawing.Point(1, 71);
            this.labelReaderInfo.Name = "labelReaderInfo";
            this.labelReaderInfo.Size = new System.Drawing.Size(59, 25);
            this.labelReaderInfo.TabIndex = 0;
            this.labelReaderInfo.Text = "temp";
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.textBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(8, 39);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(603, 705);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(597, 699);
            this.textBoxLog.TabIndex = 0;
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(244, 38);
            this.toolStripMenuItemClose.Text = "Close";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 752);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uid2RCO";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripMinimized.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.tabPageReader.ResumeLayout(false);
            this.tabPageReader.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerReaderMonitor;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMinimized;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangeState;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBoxEnable;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.Label labelOutputInfo;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxClipboard;
        private System.Windows.Forms.CheckBox checkBoxOutputToForgroundWindow;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelReaderInfo;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReaderRefresh;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTrayOnAppStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClipboardOutput;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

