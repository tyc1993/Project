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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }
        private int id;
        private void Note_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“family_DataDataSet.FamilyInfo”中。您可以根据需要移动或删除它。
            this.familyInfoTableAdapter.Fill(this.family_DataDataSet.FamilyInfo);
            // TODO: 这行代码将数据加载到表“family_DataDataSet4.NoteBook”中。您可以根据需要移动或删除它。
            this.noteBookTableAdapter.Fill(this.family_DataDataSet4.NoteBook);
            string strFilter = String.Format("nuser = '{0}'or nlist='生日'", Main.name);
            this.noteBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
            this.comboBox1.Text = Main.name;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前鼠标单击时的行索引号
            int index = this.dataGridView1.CurrentCell.RowIndex;
            //通过索引号获得值并赋予相应的文本框显示
            this.comboBox1.Text = this.dataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
            this.textBox1.Text = this.dataGridView1.Rows[index].Cells[3].Value.ToString().Trim();
            this.textBox2.Text = this.dataGridView1.Rows[index].Cells[4].Value.ToString().Trim();
            id = Convert.ToInt32(this.dataGridView1.Rows[index].Cells[1].Value.ToString().Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                id = DataAccess.GetNoteNumber() + 1;
                string user = this.comboBox1.Text.ToString().Trim();
                string list = this.textBox1.Text.ToString().Trim();
                string note = this.textBox2.Text.ToString().Trim();
                string sql = string.Format("insert into NoteBook values({0},'{1}','{2}','{3}')", id, user, list, note);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                    if (user == Main.name || list == "生日")
                    {
                        DataSet ds = DataAccess.GetDataSetBySql("select * from NoteBook");
                        this.noteBookBindingSource.DataSource = ds.Tables[0];
                        string strFilter = String.Format("nuser = '{0}'or nlist='生日'", Main.name);
                        this.noteBookBindingSource.Filter = strFilter;
                        this.dataGridView1.Refresh();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                        }
                    }
                }
                else
                    MessageBox.Show("更新失败", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {  
                string sql1 = "delete from NoteBook where nid=" + id + "";
                string sql2 = string.Format("update NoteBook set nid='{0}' where nid=(select max(nid) from NoteBook)", id);
                if (DataAccess.UpdateDataTable(sql1) && DataAccess.UpdateDataTable(sql2))
                {
                    MessageBox.Show("删除成功", "提示");
                    if (this.comboBox1.Text == Main.name || this.textBox1.Text == "生日")
                    {
                        DataSet ds = DataAccess.GetDataSetBySql("select * from NoteBook");
                        this.noteBookBindingSource.DataSource = ds.Tables[0];
                        string strFilter = String.Format("nuser = '{0}'or nlist='生日'", Main.name);
                        this.noteBookBindingSource.Filter = strFilter;
                        this.dataGridView1.Refresh();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("删除失败", "提示");
                }
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.comboBox1.Text = "";
            }
        }

        //数据验证
        private bool Validate()
        {
            if (this.comboBox1.Text != string.Empty && this.textBox1.Text != string.Empty )
                return true;
            else
                MessageBox.Show("请输入完整的信息");

            return false;
        }    
    }
}
