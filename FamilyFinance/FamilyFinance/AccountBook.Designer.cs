namespace FamilyFinance
{
    partial class AccountBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBook));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.familyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet = new FamilyFinance.Family_DataDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.astateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet3 = new FamilyFinance.Family_DataDataSet3();
            this.accountBookTableAdapter = new FamilyFinance.Family_DataDataSet3TableAdapters.AccountBookTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.familyInfoTableAdapter = new FamilyFinance.Family_DataDataSetTableAdapters.FamilyInfoTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.outMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_DataDataSet1 = new FamilyFinance.Family_DataDataSet1();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.outMenuTableAdapter = new FamilyFinance.Family_DataDataSet1TableAdapters.OutMenuTableAdapter();
            this.family_DataDataSet2 = new FamilyFinance.Family_DataDataSet2();
            this.inMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inMenuTableAdapter = new FamilyFinance.Family_DataDataSet2TableAdapters.InMenuTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.familyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "家庭成员";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.familyInfoBindingSource;
            this.comboBox1.DisplayMember = "fname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 1;
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
            // button1
            // 
            this.button1.Image = global::FamilyFinance.Properties.Resources.SearchButton1;
            this.button1.Location = new System.Drawing.Point(395, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.aidDataGridViewTextBoxColumn,
            this.atimeDataGridViewTextBoxColumn,
            this.alistDataGridViewTextBoxColumn,
            this.auserDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.astateDataGridViewTextBoxColumn,
            this.anoteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(390, 220);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "aid";
            this.aidDataGridViewTextBoxColumn.HeaderText = "aid";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Visible = false;
            // 
            // atimeDataGridViewTextBoxColumn
            // 
            this.atimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.atimeDataGridViewTextBoxColumn.DataPropertyName = "atime";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.atimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.atimeDataGridViewTextBoxColumn.HeaderText = "日期";
            this.atimeDataGridViewTextBoxColumn.Name = "atimeDataGridViewTextBoxColumn";
            this.atimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.atimeDataGridViewTextBoxColumn.Width = 54;
            // 
            // alistDataGridViewTextBoxColumn
            // 
            this.alistDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alistDataGridViewTextBoxColumn.DataPropertyName = "alist";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.alistDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.alistDataGridViewTextBoxColumn.HeaderText = "分类";
            this.alistDataGridViewTextBoxColumn.Name = "alistDataGridViewTextBoxColumn";
            this.alistDataGridViewTextBoxColumn.ReadOnly = true;
            this.alistDataGridViewTextBoxColumn.Width = 54;
            // 
            // auserDataGridViewTextBoxColumn
            // 
            this.auserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.auserDataGridViewTextBoxColumn.DataPropertyName = "auser";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.auserDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.auserDataGridViewTextBoxColumn.HeaderText = "成员";
            this.auserDataGridViewTextBoxColumn.Name = "auserDataGridViewTextBoxColumn";
            this.auserDataGridViewTextBoxColumn.ReadOnly = true;
            this.auserDataGridViewTextBoxColumn.Width = 54;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.amountDataGridViewTextBoxColumn.HeaderText = "金额";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 54;
            // 
            // astateDataGridViewTextBoxColumn
            // 
            this.astateDataGridViewTextBoxColumn.DataPropertyName = "astate";
            this.astateDataGridViewTextBoxColumn.HeaderText = "astate";
            this.astateDataGridViewTextBoxColumn.Name = "astateDataGridViewTextBoxColumn";
            this.astateDataGridViewTextBoxColumn.ReadOnly = true;
            this.astateDataGridViewTextBoxColumn.Visible = false;
            // 
            // anoteDataGridViewTextBoxColumn
            // 
            this.anoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anoteDataGridViewTextBoxColumn.DataPropertyName = "anote";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.anoteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.anoteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.anoteDataGridViewTextBoxColumn.Name = "anoteDataGridViewTextBoxColumn";
            this.anoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoteDataGridViewTextBoxColumn.Width = 54;
            // 
            // accountBookBindingSource
            // 
            this.accountBookBindingSource.DataMember = "AccountBook";
            this.accountBookBindingSource.DataSource = this.family_DataDataSet3;
            // 
            // family_DataDataSet3
            // 
            this.family_DataDataSet3.DataSetName = "Family_DataDataSet3";
            this.family_DataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBookTableAdapter
            // 
            this.accountBookTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "日期";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "分类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "家庭成员";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "备注";
            // 
            // button2
            // 
            this.button2.Image = global::FamilyFinance.Properties.Resources.添加_小_1;
            this.button2.Location = new System.Drawing.Point(419, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "更新";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::FamilyFinance.Properties.Resources.删除_小_1;
            this.button3.Location = new System.Drawing.Point(507, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "删除";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // familyInfoTableAdapter
            // 
            this.familyInfoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(476, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // outMenuBindingSource
            // 
            this.outMenuBindingSource.DataMember = "OutMenu";
            this.outMenuBindingSource.DataSource = this.family_DataDataSet1;
            // 
            // family_DataDataSet1
            // 
            this.family_DataDataSet1.DataSetName = "Family_DataDataSet1";
            this.family_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.familyInfoBindingSource;
            this.comboBox3.DisplayMember = "fname";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(476, 161);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "fname";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(476, 197);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 21);
            this.textBox2.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "查看全部";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // outMenuTableAdapter
            // 
            this.outMenuTableAdapter.ClearBeforeFill = true;
            // 
            // family_DataDataSet2
            // 
            this.family_DataDataSet2.DataSetName = "Family_DataDataSet2";
            this.family_DataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inMenuBindingSource
            // 
            this.inMenuBindingSource.DataMember = "InMenu";
            this.inMenuBindingSource.DataSource = this.family_DataDataSet2;
            // 
            // inMenuTableAdapter
            // 
            this.inMenuTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "支出查看";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "收入查看";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "开始日期";
            // 
            // button7
            // 
            this.button7.Image = global::FamilyFinance.Properties.Resources.SearchButton1;
            this.button7.Location = new System.Drawing.Point(395, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "查询";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "结束日期";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.Value = new System.DateTime(2015, 4, 30, 0, 0, 0, 0);
            // 
            // AccountBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(594, 312);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账簿查看";
            this.Load += new System.EventHandler(this.AccountBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_DataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inMenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Family_DataDataSet3 family_DataDataSet3;
        private System.Windows.Forms.BindingSource accountBookBindingSource;
        private Family_DataDataSet3TableAdapters.AccountBookTableAdapter accountBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn astateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Family_DataDataSet family_DataDataSet;
        private System.Windows.Forms.BindingSource familyInfoBindingSource;
        private Family_DataDataSetTableAdapters.FamilyInfoTableAdapter familyInfoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private Family_DataDataSet1 family_DataDataSet1;
        private System.Windows.Forms.BindingSource outMenuBindingSource;
        private Family_DataDataSet1TableAdapters.OutMenuTableAdapter outMenuTableAdapter;
        private Family_DataDataSet2 family_DataDataSet2;
        private System.Windows.Forms.BindingSource inMenuBindingSource;
        private Family_DataDataSet2TableAdapters.InMenuTableAdapter inMenuTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}