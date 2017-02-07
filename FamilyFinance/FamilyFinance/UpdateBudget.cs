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
    public partial class UpdateBudget : Form
    {
        public UpdateBudget()
        {
            InitializeComponent();
        }

        private void UpdateBudget_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“family_DataDataSet1.OutMenu”中。您可以根据需要移动或删除它。
            this.outMenuTableAdapter.Fill(this.family_DataDataSet1.OutMenu);

            this.textBox3.Text = DataAccess.GetBudget();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dataGridView1.CurrentCell.RowIndex;
            //通过索引号获得值并赋予相应的文本框显示
            this.textBox1.Text = this.dataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
            this.numericUpDown1.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!numericUpDown1.Value.Equals(0))
            {
                string list = this.textBox1.Text.ToString().Trim();
                string sql = string.Format("update OutMenu set budget='{1}' where outlist='{0}'", list, numericUpDown1.Value);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                    DataSet ds = DataAccess.GetDataSetBySql("select * from OutMenu");
                    this.dataGridView1.DataSource = ds.Tables[0];
                    this.textBox3.Text = DataAccess.GetBudget();
                }
                else
                    MessageBox.Show("更新失败", "提示");
            }
            else
                MessageBox.Show("请输入预算的数值");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
