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
    public partial class ChartOut : Form
    {
        private int a=0;
        private string sql;
        public ChartOut()
        {
            InitializeComponent();
        }

        private void ChartOut_Load(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select alist as kind,sum(amount) as money from AccountBook where astate=0 group by alist");
            this.chart1.DataSource = ds.Tables[0];
            this.chart2.DataSource = ds.Tables[0]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Visible = true; 
            this.chart2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart2.Visible = true;
            this.chart1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select alist as kind,sum(amount) as money from AccountBook where astate=0 group by alist");
            this.chart1.DataSource = ds.Tables[0];
            this.chart2.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart2.Series[0];
            this.chart1.Series.Clear();
            this.chart2.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart2.Series.Add(series4);
            a = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select auser as kind,sum(amount) as money from AccountBook where astate=0 group by auser");
            this.chart1.DataSource = ds.Tables[0];
            this.chart2.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart2.Series[0];
            this.chart1.Series.Clear(); 
            this.chart2.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart2.Series.Add(series4);
            a = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 0)
                sql = string.Format("select alist as kind,sum(amount) as money from AccountBook where astate=0 and atime>='{0}'and atime <= '{1}' group by alist", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            else if (a == 1)
                sql = string.Format("select auser as kind,sum(amount) as money from AccountBook where astate=0 and atime>='{0}'and atime <= '{1}' group by auser", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            DataSet ds = DataAccess.GetDataSetBySql(sql);
            this.chart1.DataSource = ds.Tables[0];
            this.chart2.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart2.Series[0];
            this.chart1.Series.Clear();
            this.chart2.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart2.Series.Add(series4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 0)
                sql = "select alist as kind,sum(amount) as money from AccountBook where astate=0 group by alist";
            else if (a == 1)
                sql = "select auser as kind,sum(amount) as money from AccountBook where astate=0 group by auser";
            DataSet ds = DataAccess.GetDataSetBySql(sql);
            this.chart1.DataSource = ds.Tables[0];
            this.chart2.DataSource = ds.Tables[0];
            Series series3 = this.chart1.Series[0];
            Series series4 = this.chart2.Series[0];
            this.chart1.Series.Clear();
            this.chart2.Series.Clear();
            this.chart1.Series.Add(series3);
            this.chart2.Series.Add(series4);
        }
    }
}
