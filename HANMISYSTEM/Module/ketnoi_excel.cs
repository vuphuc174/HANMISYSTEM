using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;
using System.Threading;
using System.Configuration;

namespace HANMISYSTEM
{
    class ketnoi_excel
    {
        public static OleDbConnection _con;
        public static OleDbCommand _cmd;
        public static DataTable dt;
        public static OleDbDataAdapter _da;
        String pathfile;
        public ketnoi_excel(String pathfile)
        {
            this.pathfile = pathfile;
        }
        public void connection()
        {
            if (pathfile.Contains("xlsx"))
            {
                _con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+pathfile+";"+"Extended Properties=Excel 12.0 ;");
                _con.Open();
            }
            else
            {
                _con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+pathfile+";"+"Extended Properties=Excel 8.0;");
                _con.Open();
            }
        }
        public DataTable getdatatable(String sql)
        {
            dt = new DataTable();
            try
            {
                connection();
                _da = new OleDbDataAdapter(sql, _con);
                _da.Fill(dt);
                _con.Close();
                return dt;
            }
            catch (OleDbException ex)
            {
                _con.Close();
                MessageBox.Show("Error : " + ex.ToString());
                return dt;
            }
        }
        public int executenonquery(String sql)
        {
            int re = 0;
            try
            {
                connection();
                _cmd = new OleDbCommand(sql, _con);
                _cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch (OleDbException ex)
            {
                _con.Close();
                MessageBox.Show("Error" + ex.ToString());
            }
            return re;
        }
    }
}
