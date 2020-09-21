using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsPulseButton
{
    public partial class MDIParent2 : Form
    {
        private int childFormNumber = 0;

        public MDIParent2()
        {
            InitializeComponent();
        }

       


        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "New Child")
                ShowNewForm(sender, e);
        } 

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            Button btn = new Button() { Text = "ClickME", Size = new Size(200, 20) };
            btn.Click += MDIParent2_Click;
            childForm.Controls.Add(btn);
            childForm.Show();
        }

        private void MDIParent2_Click(object sender, EventArgs e)
        {
            //Form child = ((Form)(((Button)sender).Parent)).MdiChildren[0];
            //Application.OpenForms["form1"];
        }
    }
}
