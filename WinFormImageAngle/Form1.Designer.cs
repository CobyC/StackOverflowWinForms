﻿namespace WinFormImageAngle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxMtx = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMtxDeg = new System.Windows.Forms.Label();
            this.lblCalcDeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMtx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBoxMtx.Location = new System.Drawing.Point(52, 42);
            this.pictureBoxMtx.Name = "pictureBox1";
            this.pictureBoxMtx.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxMtx.TabIndex = 0;
            this.pictureBoxMtx.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBoxCalc.Location = new System.Drawing.Point(212, 141);
            this.pictureBoxCalc.Name = "pictureBox2";
            this.pictureBoxCalc.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxCalc.TabIndex = 1;
            this.pictureBoxCalc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calculate";
            // 
            // lblMtxDeg
            // 
            this.lblMtxDeg.AutoSize = true;
            this.lblMtxDeg.Location = new System.Drawing.Point(49, 141);
            this.lblMtxDeg.Name = "lblMtxDeg";
            this.lblMtxDeg.Size = new System.Drawing.Size(25, 13);
            this.lblMtxDeg.TabIndex = 4;
            this.lblMtxDeg.Text = "deg";
            // 
            // lblCalcDeg
            // 
            this.lblCalcDeg.AutoSize = true;
            this.lblCalcDeg.Location = new System.Drawing.Point(209, 240);
            this.lblCalcDeg.Name = "lblCalcDeg";
            this.lblCalcDeg.Size = new System.Drawing.Size(25, 13);
            this.lblCalcDeg.TabIndex = 5;
            this.lblCalcDeg.Text = "deg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 274);
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
    }
}

