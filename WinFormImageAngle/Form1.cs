using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormImageAngle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _Image = imageList1.Images[0];
        }
        Image _Image; //Image.FromFile(@"S:\Images\next.png");

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            ////get the direction of the mouse by looking at the position of the picture box in relation to the mouse pointer
            //Vector2 pictureBoxMtxPlane = new Vector2(e.X - pictureBoxMtx.Location.X, e.Y - pictureBoxMtx.Location.Y);
            //Vector2 pictureBoxCalcPlane = new Vector2(e.X - pictureBoxCalc.Location.X, e.Y - pictureBoxCalc.Location.Y);

            ////https://en.wikipedia.org/wiki/Atan2
            ////atan2 - calculates the angle between the x axis and the ray line to a point. gt 0
            ////57.2978 is a constant used for radians to degrees conversion (One radian is equal 57.295779513 degrees)
            ////https://en.wikipedia.org/wiki/Radian
            //double convertToDeg = (180 / Math.PI);
            //double angleMtx = Math.Atan2(pictureBoxMtxPlane.Y, pictureBoxMtxPlane.X) * convertToDeg;
            //double angleCalc = Math.Atan2(pictureBoxCalcPlane.Y, pictureBoxCalcPlane.X) * convertToDeg;

            ////the source image
            //lblMtxDeg.Text = angleMtx.ToString();
            //lblCalcDeg.Text = angleCalc.ToString();

            //pictureBoxMtx.Image?.Dispose();
            //Bitmap mtxBitmap = new Bitmap(_Image, pictureBoxMtx.Size.Width, pictureBoxMtx.Size.Height);

            //pictureBoxCalc.Image?.Dispose();
            //Bitmap calcBitmap = new Bitmap(_Image, pictureBoxCalc.Size.Width, pictureBoxCalc.Size.Height);


            //set picture box 2 to the rotated source image.
            //pictureBoxMtx.Image = RotateImageMatrix(mtxBitmap, angleMtx);
            //pictureBoxCalc.Image = RotateImage(calcBitmap, angleCalc);

        }

        //public Bitmap RotateImageMatrix(Bitmap mtxBitmap, double angle)
        //{
        //    using (Graphics g = Graphics.FromImage(mtxBitmap))
        //    {
        //        float a = (float)angle;
        //        g.Transform.Rotate(a,System.Drawing.Drawing2D.MatrixOrder.Append);
        //        //draw passed in image onto graphics object
        //        g.DrawImage(mtxBitmap, new PointF(0, 0));
        //    }
        //    return mtxBitmap;
        //}

        //public Bitmap RotateImage(Bitmap calcBitMap, double angle)
        //{
        //    using (Graphics g = Graphics.FromImage(calcBitMap))
        //    {
        //        //move rotation point to center of image
        //        g.TranslateTransform((float)calcBitMap.Width / 2, (float)calcBitMap.Height / 2);
        //        //rotate
        //        g.RotateTransform((float)angle);
        //        //move image back
        //        g.TranslateTransform(-(float)calcBitMap.Width / 2, -(float)calcBitMap.Height / 2);
        //        //draw passed in image onto graphics object
        //        g.DrawImage(calcBitMap, new PointF(0, 0));
        //    }
        //    return calcBitMap;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //this.ShowIcon = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;            
            this.Size = new Size(8, 100);
            //var fd = new SaveFileDialog();
            //fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg";
             
            //if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    switch (Path.GetExtension(fd.FileName).ToLower())
            //    {
            //        case ".bmp":
            //            pictureBoxCalc.Image?.Save(fd.FileName, ImageFormat.Bmp);
            //            break;
            //        case ".jpg":
            //            pictureBoxCalc.Image?.Save(fd.FileName, ImageFormat.Jpeg);
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
    }
}
