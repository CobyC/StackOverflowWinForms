using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSeletionStayFocused
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.HideSelection = false;
            richTextBox1.AutoWordSelection = false;
        }
        int selectedIdxStart = 0;
        int selectedIdxLen = 0;
        int logIdx = 0;
        int newCharScrollIdx = 0;
       

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                button2.BackColor = Color.Green;
            else
                button2.BackColor = this.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddLogs();
        }

        private void AddLogs()
        {
            //richTextBox1.SuspendLayout();

            selectedIdxStart = richTextBox1.SelectionStart;
            selectedIdxLen = richTextBox1.SelectionLength;

            //for tracking the bottom of the textbox
            newCharScrollIdx = richTextBox1.GetCharIndexFromPosition(new Point(3, richTextBox1.Height));

            lblPosition.Text = $"St:{selectedIdxStart} Sc:{newCharScrollIdx} Ln:{selectedIdxLen}";
            
            for (int i = 0; i < 10; i++)
            {
                richTextBox1.AppendText($"Line {logIdx}{Environment.NewLine}");
                logIdx++;
            }
            

            //if (selectedIdxStart == 0)            
            //{
            //    richTextBox1.Select(newCharScrollIdx, 0);
            //    richTextBox1.ScrollToCaret();
            //}
            //else
            //{
            //    richTextBox1.Select(selectedIdxStart, selectedIdxLen);
            //    richTextBox1.ScrollToCaret();
            //}

            //richTextBox1.ResumeLayout();
        }

        private void buttonTrack_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
            selectedIdxStart = 0;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
