﻿namespace RowOfBalls
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
            this.pictureBoxBowl = new System.Windows.Forms.PictureBox();
            this.textBoxNumSeeds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowl)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBowl
            // 
            this.pictureBoxBowl.Location = new System.Drawing.Point(44, 42);
            this.pictureBoxBowl.Name = "pictureBoxBowl";
            this.pictureBoxBowl.Size = new System.Drawing.Size(229, 146);
            this.pictureBoxBowl.TabIndex = 0;
            this.pictureBoxBowl.TabStop = false;
            this.pictureBoxBowl.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBowl_Paint);
            // 
            // textBoxNumSeeds
            // 
            this.textBoxNumSeeds.Location = new System.Drawing.Point(44, 12);
            this.textBoxNumSeeds.Name = "textBoxNumSeeds";
            this.textBoxNumSeeds.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumSeeds.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumSeeds);
            this.Controls.Add(this.pictureBoxBowl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBowl;
        private System.Windows.Forms.TextBox textBoxNumSeeds;
        private System.Windows.Forms.Button button1;
    }
}

