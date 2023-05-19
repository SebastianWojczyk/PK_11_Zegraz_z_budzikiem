namespace PK_11_Zegraz_z_budzikiem
{
    partial class UserControlClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTimeDigital = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.analogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxTimeAnalog = new System.Windows.Forms.PictureBox();
            this.alarmSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAlarmInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeAnalog)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTimeDigital
            // 
            this.labelTimeDigital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeDigital.Location = new System.Drawing.Point(0, 0);
            this.labelTimeDigital.Name = "labelTimeDigital";
            this.labelTimeDigital.Size = new System.Drawing.Size(136, 83);
            this.labelTimeDigital.TabIndex = 0;
            this.labelTimeDigital.Text = "label1";
            this.labelTimeDigital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analogToolStripMenuItem,
            this.digitalToolStripMenuItem,
            this.alarmSettingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 70);
            // 
            // analogToolStripMenuItem
            // 
            this.analogToolStripMenuItem.Name = "analogToolStripMenuItem";
            this.analogToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.analogToolStripMenuItem.Text = "Analog";
            this.analogToolStripMenuItem.Click += new System.EventHandler(this.analogToolStripMenuItem_Click);
            // 
            // digitalToolStripMenuItem
            // 
            this.digitalToolStripMenuItem.Name = "digitalToolStripMenuItem";
            this.digitalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.digitalToolStripMenuItem.Text = "Digital";
            this.digitalToolStripMenuItem.Click += new System.EventHandler(this.digitalToolStripMenuItem_Click);
            // 
            // pictureBoxTimeAnalog
            // 
            this.pictureBoxTimeAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTimeAnalog.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTimeAnalog.Name = "pictureBoxTimeAnalog";
            this.pictureBoxTimeAnalog.Size = new System.Drawing.Size(136, 83);
            this.pictureBoxTimeAnalog.TabIndex = 2;
            this.pictureBoxTimeAnalog.TabStop = false;
            this.pictureBoxTimeAnalog.SizeChanged += new System.EventHandler(this.pictureBoxTimeAnalog_SizeChanged);
            // 
            // alarmSettingsToolStripMenuItem
            // 
            this.alarmSettingsToolStripMenuItem.Name = "alarmSettingsToolStripMenuItem";
            this.alarmSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.alarmSettingsToolStripMenuItem.Text = "Alarm settings";
            this.alarmSettingsToolStripMenuItem.Click += new System.EventHandler(this.alarmSettingsToolStripMenuItem_Click);
            // 
            // labelAlarmInfo
            // 
            this.labelAlarmInfo.AutoSize = true;
            this.labelAlarmInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAlarmInfo.Location = new System.Drawing.Point(0, 70);
            this.labelAlarmInfo.Name = "labelAlarmInfo";
            this.labelAlarmInfo.Size = new System.Drawing.Size(0, 13);
            this.labelAlarmInfo.TabIndex = 3;
            // 
            // UserControlClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelAlarmInfo);
            this.Controls.Add(this.pictureBoxTimeAnalog);
            this.Controls.Add(this.labelTimeDigital);
            this.Name = "UserControlClock";
            this.Size = new System.Drawing.Size(136, 83);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeAnalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeDigital;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem analogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxTimeAnalog;
        private System.Windows.Forms.ToolStripMenuItem alarmSettingsToolStripMenuItem;
        private System.Windows.Forms.Label labelAlarmInfo;
    }
}
