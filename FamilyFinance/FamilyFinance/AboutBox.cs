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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = Text;
            this.labelProductName.Text = labelProductName.Text;
            this.labelVersion.Text = labelVersion.Text;
            this.labelCopyright.Text = labelCopyright.Text;
            this.labelCompanyName.Text = labelCompanyName.Text;
            this.textBoxDescription.Text = textBoxDescription.Text;
        }
    }
}
