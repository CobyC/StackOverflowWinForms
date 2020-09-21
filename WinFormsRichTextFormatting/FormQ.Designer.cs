namespace WinFormsRichTextFormatting
{
    partial class FormQ
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
            this.ScriptRichTextBox.Size = new System.Drawing.Size(323, 269);
            this.ScriptRichTextBox.TabIndex = 0;
            this.ScriptRichTextBox.Text = "";
            this.ScriptRichTextBox.TextChanged += new System.EventHandler(this.ScriptRichTextBox_TextChanged);
            // 
            // FormQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 291);
            this.Controls.Add(this.ScriptRichTextBox);
            this.Name = "FormQ";
            this.Text = "FormQ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ScriptRichTextBox;
    }
}