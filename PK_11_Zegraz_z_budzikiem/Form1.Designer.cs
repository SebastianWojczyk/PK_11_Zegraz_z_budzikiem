namespace PK_11_Zegraz_z_budzikiem
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
            this.userControlClock2 = new PK_11_Zegraz_z_budzikiem.UserControlClock();
            this.userControlClock1 = new PK_11_Zegraz_z_budzikiem.UserControlClock();
            this.userControlClock3 = new PK_11_Zegraz_z_budzikiem.UserControlClock();
            this.SuspendLayout();
            // 
            // userControlClock2
            // 
            this.userControlClock2.BackColor = System.Drawing.Color.Yellow;
            this.userControlClock2.ForeColor = System.Drawing.Color.Red;
            this.userControlClock2.IsDigital = true;
            this.userControlClock2.Location = new System.Drawing.Point(594, 184);
            this.userControlClock2.Name = "userControlClock2";
            this.userControlClock2.Size = new System.Drawing.Size(150, 150);
            this.userControlClock2.TabIndex = 1;
            this.userControlClock2.EventAlarm += new System.Action(this.userControlClock2_EventAlarm);
            // 
            // userControlClock1
            // 
            this.userControlClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.userControlClock1.ForeColor = System.Drawing.Color.Yellow;
            this.userControlClock1.IsDigital = true;
            this.userControlClock1.Location = new System.Drawing.Point(53, 60);
            this.userControlClock1.Name = "userControlClock1";
            this.userControlClock1.Size = new System.Drawing.Size(120, 80);
            this.userControlClock1.TabIndex = 0;
            this.userControlClock1.EventAlarm += new System.Action(this.userControlClock1_EventAlarm);
            // 
            // userControlClock3
            // 
            this.userControlClock3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userControlClock3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlClock3.IsDigital = false;
            this.userControlClock3.Location = new System.Drawing.Point(0, 0);
            this.userControlClock3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userControlClock3.Name = "userControlClock3";
            this.userControlClock3.Size = new System.Drawing.Size(800, 450);
            this.userControlClock3.TabIndex = 2;
            this.userControlClock3.EventAlarm += new System.Action(this.userControlClock3_EventAlarm);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlClock2);
            this.Controls.Add(this.userControlClock1);
            this.Controls.Add(this.userControlClock3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlClock userControlClock1;
        private UserControlClock userControlClock2;
        private UserControlClock userControlClock3;
    }
}

