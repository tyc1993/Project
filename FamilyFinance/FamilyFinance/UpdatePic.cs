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
    public partial class UpdatePic : Form
    {
        public static string name;
        public UpdatePic()
        {
            InitializeComponent();
        }

         private void UpdatePic_Load(object sender, EventArgs e)
        {
            this.txtPic.Text = DataAccess.GetPicByname(name);
            if (this.txtPic.Text != string.Empty)
            {
                this.picbox.Image = Image.FromFile(this.txtPic.Text);
            }
        }

        private void btnPic_Click_1(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog()== DialogResult.OK)
            {
                this.txtPic.Text = ofdFile.FileName;
                this.picbox.Image = Image.FromFile(txtPic.Text);
            }
        }

        private void btnUpdatePic_Click_1(object sender, EventArgs e)
        {
            if (this.txtPic.Text != string.Empty)
            {
                string sql = string.Format("update FamilyInfo set fpic='{0}' where fname='{1}'", txtPic.Text, name);
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("更新成功", "提示");
                }
                else
                {
                    MessageBox.Show("更新失败", "提示");
                }
            }
            else MessageBox.Show("请选择一张图片");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}