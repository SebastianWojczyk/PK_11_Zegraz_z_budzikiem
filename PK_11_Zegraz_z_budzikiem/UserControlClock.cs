using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_11_Zegraz_z_budzikiem
{
    public partial class UserControlClock : UserControl
    {
        private Graphics graph;
        private int r;
        private bool isDigital;
        private FormAlarmSettings formAlarmSettings = new FormAlarmSettings();

        public event Action EventAlarm;

        public bool IsDigital
        {
            get
            {
                return isDigital;
            }
            set
            {
                isDigital = value;
                if (isDigital)
                {
                    labelTimeDigital.Visible = true;
                    pictureBoxTimeAnalog.Visible = false;

                    digitalToolStripMenuItem.Enabled = false;
                    analogToolStripMenuItem.Enabled = true;
                }
                else
                {
                    labelTimeDigital.Visible = false;
                    pictureBoxTimeAnalog.Visible = true;

                    digitalToolStripMenuItem.Enabled = true;
                    analogToolStripMenuItem.Enabled = false;
                }
            }
        }
        public UserControlClock()
        {
            InitializeComponent();
            IsDigital = true;
            PrepareNewImage();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshTime();
        }

        private void RefreshTime()
        {
            DateTime currentTime = DateTime.Now;
            if (IsDigital)
            {
                labelTimeDigital.Text = currentTime.ToLongTimeString();
            }
            else
            {
                graph.Clear(this.BackColor);

                graph.ResetTransform();
                graph.TranslateTransform(pictureBoxTimeAnalog.Width / 2, pictureBoxTimeAnalog.Height / 2);
                graph.DrawEllipse(new Pen(this.ForeColor, 4), -r, -r, 2 * r, 2 * r);

                /*{
                    int x = (int)(Math.Cos(2 * Math.PI / 60 * (currentTime.Second - 15)) * r);
                    int y = (int)(Math.Sin(2 * Math.PI / 60 * (currentTime.Second - 15)) * r);
                    graph.DrawLine(new Pen(this.ForeColor, 1), 0, 0, x, y);
                }*/
                graph.ResetTransform();
                graph.TranslateTransform(pictureBoxTimeAnalog.Width / 2, pictureBoxTimeAnalog.Height / 2);
                graph.RotateTransform(360 / 60 * currentTime.Second);
                graph.DrawLine(new Pen(this.ForeColor, 1), 0, 0, 0, -r);

                graph.ResetTransform();
                graph.TranslateTransform(pictureBoxTimeAnalog.Width / 2, pictureBoxTimeAnalog.Height / 2);
                graph.RotateTransform(360 / 60 * currentTime.Minute);
                graph.DrawLine(new Pen(this.ForeColor, 2), 0, 0, 0, (int)(-r * 0.8));


                graph.ResetTransform();
                graph.TranslateTransform(pictureBoxTimeAnalog.Width / 2, pictureBoxTimeAnalog.Height / 2);
                graph.RotateTransform(360 / 12 * currentTime.Hour);
                graph.DrawLine(new Pen(this.ForeColor, 4), 0, 0, 0, (int)(-r * 0.6));

                pictureBoxTimeAnalog.Refresh();
            }
            if (currentTime.Hour == formAlarmSettings.Hour &&
                currentTime.Minute == formAlarmSettings.Minute &&
                currentTime.Second == formAlarmSettings.Second)
            {
                EventAlarm?.Invoke();
            }
        }

        private void analogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDigital = false;
        }

        private void digitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDigital = true;
        }

        private void pictureBoxTimeAnalog_SizeChanged(object sender, EventArgs e)
        {
            PrepareNewImage();
        }

        private void PrepareNewImage()
        {
            pictureBoxTimeAnalog.Image = new Bitmap(pictureBoxTimeAnalog.Width, pictureBoxTimeAnalog.Height);
            graph = Graphics.FromImage(pictureBoxTimeAnalog.Image);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            r = Math.Min(pictureBoxTimeAnalog.Width, pictureBoxTimeAnalog.Height) / 2 - 10;

            RefreshTime();
        }

        private void alarmSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAlarmSettings.ShowDialog();
            PrepareAlarmInfo();
        }

        private void PrepareAlarmInfo()
        {
            labelAlarmInfo.Text = $"Alarm: {formAlarmSettings.Hour}:{formAlarmSettings.Minute}:{formAlarmSettings.Second}";
            if (formAlarmSettings.IsActive)
            {
                labelAlarmInfo.Visible = true;
            }
            else
            {
                labelAlarmInfo.Visible = false;
            }
        }
    }
}
