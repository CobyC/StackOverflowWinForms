namespace WinFormsRichTextFormatting
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
            this.ScriptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ScriptRichTextBox
            // 
            this.ScriptRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.ScriptRichTextBox.Name = "ScriptRichTextBox";
            this.ScriptRichTextBox.Size = new System.Drawing.Size(321, 194);
            this.ScriptRichTextBox.TabIndex = 0;
            this.ScriptRichTextBox.Text = "";
            this.ScriptRichTextBox.TextChanged += new System.EventHandler(this.ScriptRichTextBox_TextChanged);
            this.ScriptRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScriptRichTextBox_KeyDown);
            this.ScriptRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScriptRichTextBox_KeyPress);
            this.ScriptRichTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScriptRichTextBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 231);
            this.Controls.Add(this.ScriptRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ScriptRichTextBox;
    }
}

