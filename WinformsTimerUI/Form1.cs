using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace WinformsTimerUI
{
    public partial class Form1 : Form
    {
        Series Series1 { get; set; }
        int val = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            chart1.Series.Clear();

            Series1 = new Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
            };
            this.chart1.Series.Add(Series1);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await ExecuteCommand("r 1\n", tBoxPosition.Text, false, false);

        }

        //not sure what you are doing her but lets say its something that takes some time..maybe a data fetch of some kind
        async Task ExecuteCommand(string str, string text, bool value1, bool value2)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);

                Series1.Points.AddXY(i, (i + i + i));
                tBoxPosition.Text += $"value : {val++} {Environment.NewLine}";
                tBoxPosition.Select(tBoxPosition.Text.Length - 1, 0);
                tBoxPosition.ScrollToCaret();
            }
        }

        private void chkBoxPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPosition.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        //bool isBusy = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex == -1) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.IsInEditMode)
            {
                double amountOfDay = 123;// employeeOperations.comissionsEmployeeGetAmount(row.Cells[3].Value.ToString(), (e.ColumnIndex - 3).ToString());

                double amount = 0;
                try
                {
                    double.TryParse(string.Format($"{row.Cells[35].Value}", "{0:F}"), out amount);
                    //amount = amountOut;
                }
                catch
                { amount = 0; }

                if (cell.Value is bool val && val == true)
                {
                    amount += amountOfDay;
                    row.Cells[35].Value = amount;
                }
                else
                {
                    amount -= amountOfDay;
                    if (amount < 0) //Decimals handle
                        amount = 0;
                    row.Cells[35].Value = amount;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string oldText = this.Text; //oldText will be 'Report' or 'Form1'
            this.Text = "whatever you want it to be";
        }
       
    }


    //extension method for invoking the control on the UI thread.
    public static class WinFormControlsExtensions
    {
        /// <summary>
        /// Use this to create a method that needs to update UI if it might be executed on another thread.
        /// Executes on the UI thread, but calling thread waits for completion before continuing.
        /// This is the the method that returns the object and wraps the Invoke() method
        /// </summary>
        /// <param name="c">The current control</param>
        /// <param name="action">The method/code to execute</param>
        public static void InvokeIfRequired<T>(this T c, Action<T> action) where T : Control
        {
            if (c.InvokeRequired)
                c.Invoke(new Action(() => action(c)));
            else
                action(c);
        }
    }
}
