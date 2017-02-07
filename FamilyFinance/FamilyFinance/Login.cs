using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FamilyFinance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string sql = string.Format("select * from FamilyInfo where fname='{0}'and fpwd='{1}'",this.username.Text.Trim(),this.password.Text.Trim());
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("登录成功","Success");
                    UpdatePwd.name = this.username.Text.Trim();
                    UpdatePic.name = this.username.Text.Trim();
                    Main.name = this.username.Text.Trim();
                    if (this.state.Text.Trim() == "爸爸" || this.state.Text.Trim() == "妈妈")
                    { Main.result = DialogResult.OK; }
                    else Main.result =0;
                    Main dialog = new Main();
                    dialog.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("密码错误","Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (this.username.Text != string.Empty)
            {
                string sql = string.Format("select fstate from FamilyInfo where fname='{0}'", this.username.Text.Trim());
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                    this.state.Text = ds.Tables[0].Rows[0][0].ToString();
                else
                {
                    MessageBox.Show("该用户不存在", "Error");
                    this.state.Text = "";
                }
            }
            else
                this.state.Text = "";
        }
        private bool Validate()
        {
            if (this.username.Text != string.Empty && this.password.Text != string.Empty)
                return true;
            else
                MessageBox.Show("用户名或密码不能为空","Error");
            return false;
        }
    }
}
