using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLongRunningProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await completeSale();
        }

        AjaxLoader loader = null;
        public async Task completeSale()//invoked on Sell button
        {

            loader = new AjaxLoader();//this is a form
            loader.label1.Text = "Printing...";
            loader.TopMost = true;
            loader.WindowState = FormWindowState.Normal;
            loader.StartPosition = FormStartPosition.CenterParent;
            loader.ShowInTaskbar = false;
            loader.ControlBox = false;
            loader.FormBorderStyle = FormBorderStyle.None;

            //loader.PointToClient(this.DesktopLocation);
            //await Execution();
            await Task.CompletedTask;

        }

        private async Task Execution()
        {
            this.Enabled = false;
            loader.Show(this);
            //Application.DoEvents();
            await update_sale("Sold");
            loader.Close();
            this.Enabled = true;
        }

        private async Task update_sale(string v)
        {
            //long running process like printing etc..
            await Task.Delay(5000);
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            return base.ProcessKeyEventArgs(ref m);
        }

        //string _barcode;
        StringBuilder _barcodeBuilder = new StringBuilder();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData != Keys.Return)
            {
                switch (keyData)
                {
                    case Keys.NumPad0:
                        _barcodeBuilder.Append(0);
                        break;
                    case Keys.NumPad1:
                        _barcodeBuilder.Append(1);
                        break;
                    case Keys.NumPad2:
                        _barcodeBuilder.Append(2);
                        break;
                    case Keys.NumPad3:
                        _barcodeBuilder.Append(3);
                        break;
                    //and so on for the rest of the numpad keys
                    default:
                        _barcodeBuilder.Append((char)keyData);
                        break;
                }
            }
            else
            {
                MessageBox.Show(this, _barcodeBuilder.ToString());
                //read_scanner(_barcodeBuilder.ToString());
                textBox1.Clear();
                _barcodeBuilder = new StringBuilder();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
