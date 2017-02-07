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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“Family_DataDataSet3.AccountBook”中。您可以根据需要移动或删除它。
            this.AccountBookTableAdapter.Fill(this.Family_DataDataSet3.AccountBook);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FamilyFinance.Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FamilyFinance.Report2.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
