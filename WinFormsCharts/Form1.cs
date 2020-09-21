using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace WinFormsCharts
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resourceStream = typeof(System.Windows.Forms.DataVisualization.Charting.Chart)
                .Assembly.GetManifestResourceStream("System.Windows.Forms.DataVisualization.Charting.Design.resources");
            using (System.Resources.ResourceReader resReader = new ResourceReader(resourceStream))
            {
                var dictEnumerator = resReader.GetEnumerator();
                while (dictEnumerator.MoveNext())
                {
                    var ent = dictEnumerator.Entry;
                    //chartSelector1.Items.Add(new ChartDropDownItem($"{ent.Key}", ent.Value as Bitmap));
                    //imageList1.Images.Add($"{ent.Key}", ent.Value as Bitmap);
                    //listView1.Items.Add(new ListViewItem($"{ent.Key}", $"{ent.Key}"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resourceStream = typeof(Form1)
               .Assembly.GetManifestResourceStream("WinFormsCharts.Form1.resources");
            using (System.Resources.ResourceReader resReader = new ResourceReader(resourceStream))
            {
                var dictEnumerator = resReader.GetEnumerator();
                while (dictEnumerator.MoveNext())
                {
                    var ent = dictEnumerator.Entry;
                    if (ent.Key as string == "$this.Text")
                    {
                        string resFormName = ent.Value as string;
                    }
                    // chartSelector1.Items.Add(new ChartDropDownItem($"{ent.Key}", ent.Value as Bitmap));
                    //imageList1.Images.Add($"{ent.Key}", ent.Value as Bitmap);
                    //listView1.Items.Add(new ListViewItem($"{ent.Key}", $"{ent.Key}"));
                }
            }
        }
    }

    public class ChartDropDownItem
    {
        public string Value { get; set; }

        public Image Image { get; set; }

        public ChartDropDownItem(string val, Bitmap img)
        {
            Value = val;
            Image = img;
        }
    }

    public class ChartSelector : ComboBox
    {
        public ChartSelector()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                ChartDropDownItem item = (ChartDropDownItem)Items[e.Index];

                e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
                e.Graphics.DrawString(item.Value, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width, e.Bounds.Top + 2);
            }

            base.OnDrawItem(e);
        }
    }
}
