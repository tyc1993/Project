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
    public partial class UpdatePwd : Form
    {
        public static string name;

        public UpdatePwd()
        {
            InitializeComponent();
        }
        private void Updatepwd_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    string sql = string.Format("update FamilyInfo set fpwd='{1}' where fname='{0}'", name, textBox3.Text);
                    if (DataAccess.UpdateDataTable(sql))
                    {
                        MessageBox.Show("更新成功", "提示");
                        this.Close();
                    }
                    else
                        MessageBox.Show("更新失败", "提示");
                }
                else
                    MessageBox.Show("两次密码不一致", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //数据验证
        private bool Validate()
        {
            if (this.textBox2.Text != string.Empty && this.textBox3.Text != string.Empty)
                return true;
            else
                MessageBox.Show("请输入完整的信息");

            return false;
        }
    }
}
