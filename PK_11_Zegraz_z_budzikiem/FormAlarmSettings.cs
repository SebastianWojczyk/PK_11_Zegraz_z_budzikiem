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
    public partial class FormAlarmSettings : Form
    {
        public bool IsActive
        {
            get => checkBoxActive.Checked;
        }
        public int Hour
        {
            get => (int)numericUpDownHour.Value;
        }
        public int Minute
        {
            get => (int)numericUpDownMinute.Value;
        }
        public int Second
        {
            get => (int)numericUpDownSecond.Value;
        }

        public FormAlarmSettings()
        {
            InitializeComponent();
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                numericUpDownHour.Enabled = true;
                numericUpDownMinute.Enabled = true;
                numericUpDownSecond.Enabled = true;
            }
            else
            {
                numericUpDownHour.Enabled = false;
                numericUpDownMinute.Enabled = false;
                numericUpDownSecond.Enabled = false;
            }
        }
    }
}
