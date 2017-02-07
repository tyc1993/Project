namespace FamilyFinance
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet4 = new FamilyFinance.Family_DataDataSet4();
            this.noteBookTableAdapter = new FamilyFinance.Family_DataDataSet4TableAdapters.NoteBookTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.familyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet = new FamilyFinance.Family_DataDataSet();
            this.familyInfoTableAdapter = new FamilyFinance.Family_DataDataSetTableAdapters.FamilyInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nidDataGridViewTextBoxColumn,
            this.nuserDataGridViewTextBoxColumn,
            this.nlistDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noteBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(322, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // nidDataGridViewTextBoxColumn
            // 
            this.nidDataGridViewTextBoxColumn.DataPropertyName = "nid";
            this.nidDataGridViewTextBoxColumn.HeaderText = "nid";
            this.nidDataGridViewTextBoxColumn.Name = "nidDataGridViewTextBoxColumn";
            this.nidDataGridViewTextBoxColumn.ReadOnly = true;
            this.nidDataGridViewTextBoxColumn.Visible = false;
            this.nidDataGridViewTextBoxColumn.Width = 70;
            // 
            // nuserDataGridViewTextBoxColumn
            // 
            this.nuserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nuserDataGridViewTextBoxColumn.DataPropertyName = "nuser";
            this.nuserDataGridViewTextBoxColumn.HeaderText = "成员";
            this.nuserDataGridViewTextBoxColumn.Name = "nuserDataGridViewTextBoxColumn";
            this.nuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nuserDataGridViewTextBoxColumn.Width = 54;
            // 
            // nlistDataGridViewTextBoxColumn
            // 
            this.nlistDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nlistDataGridViewTextBoxColumn.DataPropertyName = "nlist";
            this.nlistDataGridViewTextBoxColumn.HeaderText = "标题";
            this.nlistDataGridViewTextBoxColumn.Name = "nlistDataGridViewTextBoxColumn";
            this.nlistDataGridViewTextBoxColumn.ReadOnly = true;
            this.nlistDataGridViewTextBoxColumn.Width = 54;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "内容";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 54;
            // 
            // noteBookBindingSource
            // 
            this.noteBookBindingSource.DataMember = "NoteBook";
            this.noteBookBindingSource.DataSource = this.family_DataDataSet4;
            // 
            // family_DataDataSet4
            // 
            this.family_DataDataSet4.DataSetName = "Family_DataDataSet4";
            this.family_DataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteBookTableAdapter
            // 
            this.noteBookTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "标题";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "内容";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 100);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = global::FamilyFinance.Properties.Resources.添加2;
            this.button1.Location = new System.Drawing.Point(359, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::FamilyFinance.Properties.Resources.删除_小_;
            this.button2.Location = new System.Drawing.Point(447, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "删除";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "家庭成员";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.familyInfoBindingSource;
            this.comboBox1.DisplayMember = "fname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "fname";
            // 
            // familyInfoBindingSource
            // 
            this.familyInfoBindingSource.DataMember = "FamilyInfo";
            this.familyInfoBindingSource.DataSource = this.family_DataDataSet;
            // 
            // family_DataDataSet
            // 
            this.family_DataDataSet.DataSetName = "Family_DataDataSet";
            this.family_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyInfoTableAdapter
            // 
            this.familyInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(534, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息备忘";
            this.Load += new System.EventHandler(this.Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Family_DataDataSet4 family_DataDataSet4;
        private System.Windows.Forms.BindingSource noteBookBindingSource;
        private Family_DataDataSet4TableAdapters.NoteBookTableAdapter noteBookTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private Family_DataDataSet family_DataDataSet;
        private System.Windows.Forms.BindingSource familyInfoBindingSource;
        private Family_DataDataSetTableAdapters.FamilyInfoTableAdapter familyInfoTableAdapter;
    }
}