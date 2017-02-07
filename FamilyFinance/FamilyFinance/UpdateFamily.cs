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
    public partial class UpdateFamily : Form
    {
        public UpdateFamily()
        {
            InitializeComponent();
        }

        private void UpdateFamily_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“family_DataDataSet.FamilyInfo”中。您可以根据需要移动或删除它。
            this.familyInfoTableAdapter.Fill(this.family_DataDataSet.FamilyInfo);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dataGridView1.CurrentCell.RowIndex;
            //通过索引号获得值并赋予相应的文本框显示
            this.textBox1.Text = this.dataGridView1.Rows[index].Cells[0].Value.ToString().Trim();
            this.textBox2.Text = this.dataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.textBox3.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.textBox4.Text = this.dataGridView1.Rows[index].Cells[3].Value.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string sql = "delete from FamilyInfo where fid=" + this.textBox1.Text + "";
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("删除成功", "提示");
                    DataSet ds = DataAccess.GetDataSetBySql("select * from FamilyInfo");
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("删除失败", "提示");
                }
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                int id = Convert.ToInt32(this.textBox1.Text.Trim());
                string name = this.textBox2.Text.ToString().Trim();
                string password = this.textBox3.Text.ToString().Trim();
                string state = this.textBox4.Text.ToString().Trim(); 
                string sql = string.Format("insert into FamilyInfo(fid, fname, fpwd, fstate) values( {0},'{1}','{2}','{3}')", id, name, password, state);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                    DataSet ds = DataAccess.GetDataSetBySql("select * from FamilyInfo");
                    this.dataGridView1.DataSource = ds.Tables[0];
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("更新失败", "提示");
                }
            }
        }
        //数据验证
        private bool Validate()
        {
            if (this.textBox1.Text != string.Empty && this.textBox2.Text != string.Empty && this.textBox3.Text != string.Empty && this.textBox4.Text != string.Empty)
                return true;
            else
                MessageBox.Show("请输入完整的信息");

            return false;
        }
    }
}
