using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyFinance
{
    public partial class AccountBook : Form
    {
        private int id;
        public AccountBook()
        {
            InitializeComponent();
        }

        private void AccountBook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“family_DataDataSet2.InMenu”中。您可以根据需要移动或删除它。
            this.inMenuTableAdapter.Fill(this.family_DataDataSet2.InMenu);
            // TODO: 这行代码将数据加载到表“family_DataDataSet1.OutMenu”中。您可以根据需要移动或删除它。
            this.outMenuTableAdapter.Fill(this.family_DataDataSet1.OutMenu);
            // TODO: 这行代码将数据加载到表“family_DataDataSet.FamilyInfo”中。您可以根据需要移动或删除它。
            this.familyInfoTableAdapter.Fill(this.family_DataDataSet.FamilyInfo);
            // TODO: 这行代码将数据加载到表“family_DataDataSet3.AccountBook”中。您可以根据需要移动或删除它。
            this.accountBookTableAdapter.Fill(this.family_DataDataSet3.AccountBook);
            this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
            this.comboBox2.Text = "";
            this.comboBox3.Text = "";
            this.numericUpDown1.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dataGridView1.CurrentCell.RowIndex;
            //通过索引号获得值并赋予相应的文本框显示
            int state=Convert.ToInt32(this.dataGridView1.Rows[index].Cells[6].Value.ToString().Trim());
            if (state == 0)
            {
                this.comboBox2.DataSource = this.outMenuBindingSource;
                this.comboBox2.DisplayMember = "outlist";
                this.comboBox2.ValueMember = "outlist";
            }
            if (state == 1)
            {
                this.comboBox2.DataSource = this.inMenuBindingSource;
                this.comboBox2.DisplayMember = "inlist";
                this.comboBox2.ValueMember = "inlist";
            }
            this.textBox2.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.comboBox2.Text = this.dataGridView1.Rows[index].Cells[3].Value.ToString().Trim();
            this.comboBox3.Text = this.dataGridView1.Rows[index].Cells[4].Value.ToString().Trim();
            this.numericUpDown1.Text = this.dataGridView1.Rows[index].Cells[5].Value.ToString().Trim();
            this.textBox1.Text = this.dataGridView1.Rows[index].Cells[7].Value.ToString().Trim();
            id = Convert.ToInt32(this.dataGridView1.Rows[index].Cells[1].Value.ToString().Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFilter = String.Format("auser = '{0}'", this.comboBox1.Text); 
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.accountBookBindingSource.Filter = "";
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string sql1 = "delete from AccountBook where aid=" + id + "";
                string sql2 = string.Format("update AccountBook set aid='{0}' where aid=(select max(aid) from AccountBook)", id);
                if (DataAccess.UpdateDataTable(sql1) && DataAccess.UpdateDataTable(sql2))
                {
                    MessageBox.Show("删除成功", "提示");
                    DataSet ds = DataAccess.GetDataSetBySql("select * from AccountBook");
                    this.accountBookBindingSource.DataSource = ds.Tables[0];
                    this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                    }
                }
                else
                {
                    MessageBox.Show("删除失败", "提示");
                }
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.comboBox2.Text = "";
                this.comboBox3.Text = "";
                this.numericUpDown1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string list = this.comboBox2.Text.ToString().Trim();
                string user = this.comboBox3.Text.ToString().Trim();
                string note = this.textBox1.Text.ToString().Trim();
                string sql = string.Format("update AccountBook set alist='{1}',auser='{2}',amount={3},anote='{4}' where aid={0}", id, list,user,numericUpDown1.Value,note);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                    DataSet ds = DataAccess.GetDataSetBySql("select * from AccountBook");
                    this.dataGridView1.DataSource = ds.Tables[0];
                    this.accountBookBindingSource.DataSource = ds.Tables[0];
                    this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                    }
                }
                else
                    MessageBox.Show("更新失败", "提示");
            }
        }        
        private bool Validate()
        {
            if (this.textBox2.Text != string.Empty && this.comboBox2.Text != string.Empty && this.comboBox3.Text != string.Empty && !this.numericUpDown1.Value.Equals(0))
                return true;
            else
                MessageBox.Show("请输入完整的信息");

            return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strFilter = String.Format("astate = 0");
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strFilter = String.Format("astate = 1");
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strFilter = String.Format("atime>='{0}'and atime <= '{1}'", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }
    }
}
