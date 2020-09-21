using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordJumble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblAnswer.Text = "";
            DrawLeters();
        }

        string checkAnswer = "check";
        void DrawLeters()
        {
            this.SuspendLayout();
            string[] alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(",");

            var pictureLocation = new Point(0, 0);
            for (int i = 0; i < alphabet.Length; i++)
            {
                //Create a picture box
                PictureBox pictureBx = new PictureBox();
                //set the default location of the box (0,0) in this scenario
                pictureBx.Location = pictureLocation;
                //make the box 16 by 16
                pictureBx.Size = new Size(16, 16);
                //set the name of the box to that of the letter it represents
                pictureBx.Name = alphabet[i];
                //assign a click event to the box
                pictureBx.Click += PictureBx_Click;
                //now create the image that will fill the box
                Image img = new Bitmap(16, 16);
                using (Graphics graph = Graphics.FromImage(img))
                {
                    graph.Clear(Color.White);
                    Brush textBrush = new SolidBrush(Color.Black);
                    graph.DrawString(pictureBx.Name, this.Font, textBrush, 0, 0);
                    graph.Save();
                }
                //assign the image to the box
                pictureBx.Image = img;

                //add the box to the form
                this.Controls.Add(pictureBx);

                //change the location for the next box
                pictureLocation.X += 17;
                if (i % 10 == 0 && i > 0)
                {
                    pictureLocation.Y += 17;
                    pictureLocation.X = 0;
                }
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void PictureBx_Click(object sender, EventArgs e)
        {   // assign the clicked value to the answer label
            if (sender is PictureBox pbx)
                lblAnswer.Text += pbx.Name;
        }

        private void checkAnswerBtn_Click(object sender, EventArgs e)
        {
            //check the answer
            if (lblAnswer.Text == checkAnswer)
                lblFeedback.Text = "Correct!!";
            else
                lblFeedback.Text = "NO!!";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clear the answer label
            lblAnswer.Text = "";
        }
    }
}
