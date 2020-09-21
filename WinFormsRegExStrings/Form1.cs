using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRegExStrings
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Document document = rtbox.Document;
            //var regex = @"<<.+>>";
            var regex = @"<<[\w\s\#\:\,\|]+\>>";
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"<<[\w\s\#\:\,\|]+\>>");
            DocumentRange[] pTokenRangeList = document.FindAll(expr, document.Range);            
            var mtch = expr.Matches(document.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = Properties.Resources.ResourceManager.GetString("Report.Text");

            ResourceManager resMan = new ResourceManager("Report",typeof(Report).Assembly);

            var formText = resMan.GetString("Report.Text");

        }
    }
}
