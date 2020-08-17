using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HANMISYSTEM
{
    public class Dbconnect
    {
        static string sn = HANMISYSTEM.Properties.Settings.Default.servername;
        static string uid = HANMISYSTEM.Properties.Settings.Default.uid;
        static string pwd = HANMISYSTEM.Properties.Settings.Default.pwd;
        public SqlConnection con = new SqlConnection(@"Data Source=" + sn + ";Initial Catalog=HANMI;Trusted_Connection=no;uid = " + uid + ";pwd= " + pwd + ";  Integrated Security=false ;Connect Timeout=30");
        public void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        public int countdata(string cmd)
        {
            int c;
            openconnect();
            SqlCommand bo_lenh = new SqlCommand(cmd, con);
            c = (int)bo_lenh.ExecuteScalar();
            closeconnect();
            return c;
        }
        public double countdatafloat(string cmd)
        {
            string c;
            openconnect();
            SqlCommand bo_lenh = new SqlCommand(cmd, con);
            try
            {
                SqlDataReader r = bo_lenh.ExecuteReader();
                c = r["lastesttarget"].ToString();
            }
            catch
            {
                c = "0";
            }
            closeconnect();
            return Convert.ToDouble(c);
        }
        public DateTime returndate(string cmd)
        {
            DateTime c;
            openconnect();
            SqlCommand bo_lenh = new SqlCommand(cmd, con);
            try
            {
                c = (DateTime)bo_lenh.ExecuteScalar();
            }
            catch
            {
                c = DateTime.MinValue;
            }
            closeconnect();
            return c;
        }
        public DataTable readdata(string cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }
        public SqlDataReader readerdata(string sql)
        {
            openconnect();
            SqlDataReader re;
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                re = com.ExecuteReader();
            }
            catch
            {
                re = null;
            }
            closeconnect();
            return re;
        }
    }
}

