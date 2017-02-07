using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FamilyFinance
{
    class DataAccess
    {
        private static string ConnectString = "server=.\\SQLExpress;database=Family_Data;Integrated Security=true";//数据库连接字符串
        /// <summary>
        /// 根据Sql语句获取数据集对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSetBySql(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))//创建数据库连接对象
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);//创建适配器对象
                DataSet ds = new DataSet();//创建数据集对象
                try
                {
                    adapter.Fill(ds);//填充数据集
                    return ds;//返回数据集
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 根据nane值获取pic值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetPicByname(string name)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select * from FamilyInfo where fname='{0}'",name) ;//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader["fpic"].ToString();//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static string GetBudget()
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select sum(budget) as sum_budget from OutMenu");//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader["sum_budget"].ToString();//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static string GetIn()
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select sum(amount) as sum_in from AccountBook where astate = 1");//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader["sum_in"].ToString();//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static string GetOut()
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select sum(amount) as sum_out from AccountBook where astate = 0");//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return reader["sum_out"].ToString();//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static int GetNumber()
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select count(*) as number from AccountBook");//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return Convert.ToInt32(reader["number"]);//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static int GetNoteNumber()
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                string sql = string.Format("select count(*) as number from NoteBook");//sql语句
                try
                {
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    con.Open();//打开连接
                    SqlDataReader reader = comm.ExecuteReader();//创建DataReader对象
                    reader.Read();//读取数据
                    return Convert.ToInt32(reader["number"]);//返回DataReader
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool UpdateDataTable(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                try
                {
                    con.Open();//打开连接
                    SqlCommand comm = new SqlCommand(sql, con);//创建Command对象
                    if (comm.ExecuteNonQuery() > 0) //执行更新
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
