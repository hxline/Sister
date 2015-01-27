using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class CountDown : Form
    {
        private int timeCount;

        public CountDown(string time)
        {
            InitializeComponent();
            timeCount = int.Parse(time);
            labelCount.Text = timeCount.ToString();
            timerCount.Enabled = true;
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            if (timeCount > 1)
            {
                timeCount--;
                labelCount.Text = timeCount.ToString();
            }
            else
            {
                timerCount.Enabled = false;
                this.Close();
            }
        }
    }
}
