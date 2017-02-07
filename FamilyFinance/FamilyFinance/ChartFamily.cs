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
    public partial class ChartFamily : Form
    {
        public ChartFamily()
        {
            InitializeComponent();
        }

        private void ChartFamily_Load(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select distinct auser ,(select sum(amount) from AccountBook where astate=1 and auser =A.auser ) as moneyin,(select sum(amount) from AccountBook where astate=0 and auser =A.auser )as moneyout from AccountBook as A");
            this.chart1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select distinct auser ,(select sum(amount) from AccountBook where astate=1 and auser =A.auser and atime>='{0}'and atime <= '{1}') as moneyin,(select sum(amount) from AccountBook where astate=0 and auser =A.auser and atime>='{0}'and atime <= '{1}')as moneyout from AccountBook as A where atime>='{0}'and atime <= '{1}'", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
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
            DataSet ds = DataAccess.GetDataSetBySql("select distinct auser ,(select sum(amount) from AccountBook where astate=1 and auser =A.auser ) as moneyin,(select sum(amount) from AccountBook where astate=0 and auser =A.auser )as moneyout from AccountBook as A");
            this.chart1.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart1.Series[1];
            this.chart1.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
        }
    }
}
