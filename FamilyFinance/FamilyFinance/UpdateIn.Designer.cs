namespace FamilyFinance
{
    partial class UpdateIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateIn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet2 = new FamilyFinance.Family_DataDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inMenuTableAdapter = new FamilyFinance.Family_DataDataSet2TableAdapters.InMenuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet2)).BeginInit();
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
            this.inidDataGridViewTextBoxColumn,
            this.inlistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inMenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // inidDataGridViewTextBoxColumn
            // 
            this.inidDataGridViewTextBoxColumn.DataPropertyName = "inid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.inidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.inidDataGridViewTextBoxColumn.HeaderText = "编号";
            this.inidDataGridViewTextBoxColumn.Name = "inidDataGridViewTextBoxColumn";
            this.inidDataGridViewTextBoxColumn.ReadOnly = true;
            this.inidDataGridViewTextBoxColumn.Width = 70;
            // 
            // inlistDataGridViewTextBoxColumn
            // 
            this.inlistDataGridViewTextBoxColumn.DataPropertyName = "inlist";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.inlistDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.inlistDataGridViewTextBoxColumn.HeaderText = "收入分类";
            this.inlistDataGridViewTextBoxColumn.Name = "inlistDataGridViewTextBoxColumn";
            this.inlistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inMenuBindingSource
            // 
            this.inMenuBindingSource.DataMember = "InMenu";
            this.inMenuBindingSource.DataSource = this.family_DataDataSet2;
            // 
            // family_DataDataSet2
            // 
            this.family_DataDataSet2.DataSetName = "Family_DataDataSet2";
            this.family_DataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Image = global::FamilyFinance.Properties.Resources.添加2;
            this.button1.Location = new System.Drawing.Point(297, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::FamilyFinance.Properties.Resources.删除_小_;
            this.button2.Location = new System.Drawing.Point(297, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "分类名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // inMenuTableAdapter
            // 
            this.inMenuTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收入分类管理";
            this.Load += new System.EventHandler(this.UpdateIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Family_DataDataSet2 family_DataDataSet2;
        private System.Windows.Forms.BindingSource inMenuBindingSource;
        private Family_DataDataSet2TableAdapters.InMenuTableAdapter inMenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inlistDataGridViewTextBoxColumn;
    }
}