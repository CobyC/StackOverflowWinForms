using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormImageAngle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = this.Width.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.BackColor = SystemColors.Desktop;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.ShowIcon = false;
            //this.ShowInTaskbar = false;
            this.Size = new Size(8, 16);
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            
        }
    }
}
