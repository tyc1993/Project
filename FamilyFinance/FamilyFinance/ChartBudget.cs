using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FamilyFinance
{
    public partial class ChartBudget : Form
    {
        public ChartBudget()
        {
            InitializeComponent();
        }

        private void ChartBudget_Load(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select distinct alist ,(select budget from OutMenu where outlist =A.alist) as planmoney,(select sum(amount) from AccountBook where alist =A.alist )as factmoney from AccountBook as A where astate=0");
            this.chart1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select distinct alist ,(select budget from OutMenu where outlist =A.alist) as planmoney,(select sum(amount) from AccountBook where alist =A.alist and atime>='{0}'and atime <= '{1}')as factmoney from AccountBook as A where astate=0 and atime>='{0}'and atime <= '{1}'", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            DataSet ds = DataAccess.GetDataSetBySql(sql);
            this.chart1.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart1.Series[1];
            this.chart1.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select distinct alist ,(select budget from OutMenu where outlist =A.alist) as planmoney,(select sum(amount) from AccountBook where alist =A.alist )as factmoney from AccountBook as A where astate=0");
            this.chart1.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart1.Series[1];
            this.chart1.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
        }
    }
}
