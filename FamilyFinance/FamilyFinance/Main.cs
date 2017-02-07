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
    public partial class Main : Form
    {
        public static string name;
        public static DialogResult result;
        public Main()
        {
            InitializeComponent();
        }
        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)
            {
                if (childFrm.Name == childfrmname)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        //窗体载入时事件处理
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“family_DataDataSet3.AccountBook”中。您可以根据需要移动或删除它。
            this.accountBookTableAdapter.Fill(this.family_DataDataSet3.AccountBook);
            // TODO: 这行代码将数据加载到表“family_DataDataSet2.InMenu”中。您可以根据需要移动或删除它。
            this.inMenuTableAdapter.Fill(this.family_DataDataSet2.InMenu);
            // TODO: 这行代码将数据加载到表“family_DataDataSet1.OutMenu”中。您可以根据需要移动或删除它。
            this.outMenuTableAdapter.Fill(this.family_DataDataSet1.OutMenu);
            // TODO: 这行代码将数据加载到表“family_DataDataSet.FamilyInfo”中。您可以根据需要移动或删除它。
            this.familyInfoTableAdapter.Fill(this.family_DataDataSet.FamilyInfo);
            this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            string strFilter = String.Format("auser = '{0}'", name);
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
            if (result == DialogResult.OK)
            {
                this.成员管理ToolStripMenuItem.Enabled = true;
                this.资产情况ToolStripMenuItem1.Enabled = true;
                this.预算管理ToolStripMenuItem.Enabled = true;
                this.家庭理财ToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.成员管理ToolStripMenuItem.Enabled = false;
                this.资产情况ToolStripMenuItem1.Enabled = false;
                this.预算管理ToolStripMenuItem.Enabled = false;
                this.家庭理财ToolStripMenuItem.Enabled = false;
            }
            if (DataAccess.GetPicByname(name) != string.Empty)
            {
                this.pictureBox1.Image = Image.FromFile(DataAccess.GetPicByname(name));
            }
            this.comboBox1.Text = name;
            this.dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //检测该窗口是否处于打开状态
            if (this.checkchildfrm("Login") == true)
                return;    //窗口已经打开,返回
            this.Hide();
            Login user = new Login();//实例化登录窗体
            user.ShowDialog();
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void 问题反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problem Dialog = new Problem();
            Dialog.ShowDialog();
        }

        private void 成员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFamily Dialog = new UpdateFamily();
            Dialog.ShowDialog();
            DataSet ds = DataAccess.GetDataSetBySql("select * from FamilyInfo");
            this.comboBox1.DataSource = ds.Tables[0];
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePwd Dialog = new UpdatePwd();
            Dialog.ShowDialog();
        }

        private void 封面管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePic Dialog = new UpdatePic();
            Dialog.ShowDialog();
            if (DataAccess.GetPicByname(name) != string.Empty)
            {
                this.pictureBox1.Image = Image.FromFile(DataAccess.GetPicByname(name));
            }
            this.pictureBox1.Visible = true;
        }

        private void 支出分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOut Dialog = new UpdateOut();
            Dialog.ShowDialog();
            DataSet ds = DataAccess.GetDataSetBySql("select * from OutMenu");
            this.listBox1.DataSource = ds.Tables[0];
        }

        private void 收入分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateIn Dialog = new UpdateIn();
            Dialog.ShowDialog();
            DataSet ds = DataAccess.GetDataSetBySql("select * from InMenu");
            this.listBox2.DataSource = ds.Tables[0];
        }

        private void 检查新版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
            for (int i = 0; i < 10; i++)//循环
            {
                System.Threading.Thread.Sleep(100);//暂停1秒
                progressBar1.Value += progressBar1.Step;//让进度条增加一次

            }
            MessageBox.Show("当前已是最新版本", "提示");
            this.progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        private void 预算管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBudget Dialog = new UpdateBudget();
            Dialog.ShowDialog();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.listBox1.Enabled = true;
            this.listBox2.Enabled = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this.listBox2.Enabled = true;
            this.listBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value.Equals(0))
                MessageBox.Show("请输入金额");
            else
            {
                int id = DataAccess.GetNumber() + 1;
                string user = this.comboBox1.Text.ToString().Trim();
                string note = this.textBox1.Text.ToString().Trim();
                string list = "";
                int state = -1;
                if (this.radioButton1.Checked == true)
                {
                    list = this.listBox1.Text.ToString().Trim();
                    state = 0;
                }
                else
                {
                    list = this.listBox2.Text.ToString().Trim();
                    state = 1;
                }
                string sql = string.Format("insert into AccountBook values({0},'{1}','{2}','{3}',{4},{5},'{6}')", id, dateTimePicker1.Value.Date, list, user, numericUpDown1.Value, state, note);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                    if (user == name)
                    {
                        DataSet ds = DataAccess.GetDataSetBySql("select * from AccountBook");
                        this.accountBookBindingSource.DataSource = ds.Tables[0];
                        this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
                        string strFilter = String.Format("auser = '{0}'", name);
                        this.accountBookBindingSource.Filter = strFilter;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
        }

        private void 账簿查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountBook Dialog = new AccountBook();
            Dialog.ShowDialog();
            DataSet ds = DataAccess.GetDataSetBySql("select * from AccountBook");
            this.accountBookBindingSource.DataSource = ds.Tables[0];
            this.dataGridView1.Sort(this.dataGridView1.Columns["atimeDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            string strFilter = String.Format("auser = '{0}'", name);
            this.accountBookBindingSource.Filter = strFilter;
            this.dataGridView1.Refresh();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
            }
        }

        private void 支出图表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartOut Dialog = new ChartOut();
            Dialog.ShowDialog();
        }

        private void 收入图表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartIn Dialog = new ChartIn();
            Dialog.ShowDialog();
        }

        private void 成员图表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartFamily Dialog = new ChartFamily();
            Dialog.ShowDialog();
        }

        private void 预算图表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartBudget Dialog = new ChartBudget();
            Dialog.ShowDialog();
        }

        private void 打开记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void 打开计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void 家庭理财ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance Dialog = new Finance();
            Dialog.ShowDialog();
        }

        private void 信息提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note Dialog = new Note();
            Dialog.ShowDialog();
        }

        private void 资产情况ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Assets Dialog = new Assets();
            Dialog.ShowDialog();
        }

        private void 报表查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report Dialog = new Report();
            Dialog.ShowDialog();
        }
    }
}
