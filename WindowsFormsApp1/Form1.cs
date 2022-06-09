using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            btn.Text = "또 눌러?";
            lblStatus.Text += "+";
            tbStatus.Text += "+";

            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                elapsedTime = 0;
                lblStatus.Text = "";
                tbStatus.Text = "";
                toolStripProgressBar1.Value = 0;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblStatus.Text = elapsedTime + "초 경과";
            tbStatus.Text = elapsedTime + "초 경과";
            toolStripProgressBar1.Value = elapsedTime;
        }


    }
}
