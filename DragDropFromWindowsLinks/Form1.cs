using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DragDropFromWindowsLinks
{
    public partial class Form1 : Form
    {
        /*
          COULD NOT GET THIS TO WORK!!!! 
          */
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var names = e.Data.GetData("Shell IDList Array");
            var oleConverter = typeof(System.Windows.Forms.DataObject).GetField("innerData", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(e.Data);
            var dataObject = oleConverter.GetType().GetProperty("OleDataObject").GetValue(oleConverter, null);

            var map = dataObject.GetType().GetProperty("ResourceMap").GetValue(dataObject);

            var dataP = dataObject as System.Windows.DataObject;
            //if (e.Data is DataObject dob)
            //{
            //    //return ((OleConverter)dob.GetData(DataFormats.FileDrop)).OleDataObject.EnumFormatEtc(dwDirection);
            //}
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }
    }
}
