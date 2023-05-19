using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_11_Zegraz_z_budzikiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControlClock3_EventAlarm()
        {
            MessageBox.Show("Alarm różowy");
        }

        private void userControlClock2_EventAlarm()
        {
            MessageBox.Show("Alarm żółty");
        }

        private void userControlClock1_EventAlarm()
        {
            MessageBox.Show("Alarm czerwony");
            //System.Media.SoundPlayer p = new System.Media.SoundPlayer("sciezka do pliku");
            //p.Play();
        }
    }
}
