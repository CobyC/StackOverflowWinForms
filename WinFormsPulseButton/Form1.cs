using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPulseButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int greeness = 255;
        bool pulseUp;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (greeness >= 255)
                pulseUp = false;
            if
                (greeness < 100)
                pulseUp = true;

            if (pulseUp)
                greeness += 20;
            else
                greeness -= 20;

            Color c = Color.FromArgb(0, greeness, 0);
            button1.BackColor = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.WindowState = FormWindowState.Minimized; //fill the window
            childForm.MdiParent = this;//the parent form
            childForm.ControlBox = true;
            childForm.Show();
        }
    }
}
