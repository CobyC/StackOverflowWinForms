namespace SaveToDatabase
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BelPosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sOQuestionsDataSet = new SaveToDatabase.SOQuestionsDataSet();
            this.belegePositionenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belegePositionenTableAdapter = new SaveToDatabase.SOQuestionsDataSetTableAdapters.BelegePositionenTableAdapter();
            this.belIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belPosIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOQuestionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belegePositionenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BelPosId,
            this.Artikelnummer,
            this.Menge,
            this.Preis,
            this.belIdDataGridViewTextBoxColumn,
            this.belPosIdDataGridViewTextBoxColumn,
            this.artikelnummerDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.belegePositionenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // BelPosId
            // 
            this.BelPosId.HeaderText = "BelPosId";
            this.BelPosId.Name = "BelPosId";
            this.BelPosId.ReadOnly = true;
            this.BelPosId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            this.Artikelnummer.ReadOnly = true;
            // 
            // Menge
            // 
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.ReadOnly = true;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "upd";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sOQuestionsDataSet
            // 
            this.sOQuestionsDataSet.DataSetName = "SOQuestionsDataSet";
            this.sOQuestionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // belegePositionenBindingSource
            // 
            this.belegePositionenBindingSource.DataMember = "BelegePositionen";
            this.belegePositionenBindingSource.DataSource = this.sOQuestionsDataSet;
            // 
            // belegePositionenTableAdapter
            // 
            this.belegePositionenTableAdapter.ClearBeforeFill = true;
            // 
            // belIdDataGridViewTextBoxColumn
            // 
            this.belIdDataGridViewTextBoxColumn.DataPropertyName = "BelId";
            this.belIdDataGridViewTextBoxColumn.HeaderText = "BelId";
            this.belIdDataGridViewTextBoxColumn.Name = "belIdDataGridViewTextBoxColumn";
            // 
            // belPosIdDataGridViewTextBoxColumn
            // 
            this.belPosIdDataGridViewTextBoxColumn.DataPropertyName = "BelPosId";
            this.belPosIdDataGridViewTextBoxColumn.HeaderText = "BelPosId";
            this.belPosIdDataGridViewTextBoxColumn.Name = "belPosIdDataGridViewTextBoxColumn";
            // 
            // artikelnummerDataGridViewTextBoxColumn
            // 
            this.artikelnummerDataGridViewTextBoxColumn.DataPropertyName = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.HeaderText = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.Name = "artikelnummerDataGridViewTextBoxColumn";
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(66, 277);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(229, 140);
            this.textBox1.TabIndex = 4;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(567, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 97);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOQuestionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belegePositionenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelPosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SOQuestionsDataSet sOQuestionsDataSet;
        private System.Windows.Forms.BindingSource belegePositionenBindingSource;
        private SOQuestionsDataSetTableAdapters.BelegePositionenTableAdapter belegePositionenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belPosIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

