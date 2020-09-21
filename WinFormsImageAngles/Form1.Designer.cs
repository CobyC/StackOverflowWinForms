namespace WinFormsImageAngles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMtx = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMtxDeg = new System.Windows.Forms.Label();
            this.lblCalcDeg = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMtx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMtx
            // 
            this.pictureBoxMtx.Location = new System.Drawing.Point(43, 41);
            this.pictureBoxMtx.Name = "pictureBoxMtx";
            this.pictureBoxMtx.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMtx.TabIndex = 0;
            this.pictureBoxMtx.TabStop = false;
            // 
            // pictureBoxCalc
            // 
            this.pictureBoxCalc.Location = new System.Drawing.Point(162, 125);
            this.pictureBoxCalc.Name = "pictureBoxCalc";
            this.pictureBoxCalc.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCalc.TabIndex = 1;
            this.pictureBoxCalc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calc";
            // 
            // lblMtxDeg
            // 
            this.lblMtxDeg.AutoSize = true;
            this.lblMtxDeg.Location = new System.Drawing.Point(43, 94);
            this.lblMtxDeg.Name = "lblMtxDeg";
            this.lblMtxDeg.Size = new System.Drawing.Size(28, 15);
            this.lblMtxDeg.TabIndex = 2;
            this.lblMtxDeg.Text = "Deg";
            // 
            // lblCalcDeg
            // 
            this.lblCalcDeg.AutoSize = true;
            this.lblCalcDeg.Location = new System.Drawing.Point(162, 178);
            this.lblCalcDeg.Name = "lblCalcDeg";
            this.lblCalcDeg.Size = new System.Drawing.Size(31, 15);
            this.lblCalcDeg.TabIndex = 2;
            this.lblCalcDeg.Text = "Dwg";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "next.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 225);
            this.Controls.Add(this.lblCalcDeg);
            this.Controls.Add(this.lblMtxDeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCalc);
            this.Controls.Add(this.pictureBoxMtx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMtx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMtx;
        private System.Windows.Forms.PictureBox pictureBoxCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMtxDeg;
        private System.Windows.Forms.Label lblCalcDeg;
        private System.Windows.Forms.ImageList imageList1;
    }
}

