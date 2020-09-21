using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RowOfBalls
{
    public partial class Form1 : Form
    {
        int HEIGHT = 5;
        int SIZE = 10;
        int GAP = 2;
        int LEFT = 0;
        int TOP = 0;
        Rectangle _recCircle;
        int ballAmount = 0;
        Random _rand;

        public Form1()
        {
            InitializeComponent();
            _recCircle = new Rectangle(LEFT, TOP, SIZE, SIZE);
            _rand = new Random(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //changes text value to interger
                ballAmount = int.Parse(textBoxNumSeeds.Text);
            }
            catch (Exception ex)
            {
                //tells user of error and clears and focuses the textbox
                MessageBox.Show("invalid numeric input try again");
                textBoxNumSeeds.Clear();
                textBoxNumSeeds.Focus();
                return;
            }
            pictureBoxBowl.Invalidate();
        }

        private void pictureBoxBowl_Paint(object sender, PaintEventArgs e)
        {
            //makes y position for the circle rows
            int yPos = TOP;
            int xPos = LEFT;
            int xNext = 0;

            //creates new row under previous row  
            for (int cols = 0; cols < ballAmount; cols++)
            {
                SolidBrush SeedColour = null;
                SeedColour = new SolidBrush(Color.FromArgb(_rand.Next(255), _rand.Next(255), _rand.Next(255)));
                //changes new circle location by changing y position and adding gap and radius to it
                _recCircle.Location = new Point(xPos, yPos);
                //displays the circles based on recCircle dimensions
                e.Graphics.FillEllipse(SeedColour, _recCircle);
                e.Graphics.DrawEllipse(new Pen(SeedColour), _recCircle);
                //updates the xposition of the columns
                xPos = xPos + SIZE + GAP;

                //test if a new row is required
                xNext = xPos + SIZE + GAP;
                if (xNext > e.ClipRectangle.Width)
                {
                    yPos = yPos + SIZE;
                    xPos = 0;
                }
            }
        }
    }
}
