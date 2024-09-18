using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANMISYSTEM.Module
{
    internal class SubDbConnect
    {
        static string sn = "192.168.1.243,2500";
        static string uid = "bravosql";
        static string pwd = "Hanmi123@#$";
        static string dbName = "DB_Hanmi_Production";
        //public SqlConnection con = new SqlConnection(@"Data Source=" + sn + ";Initial Catalog=HANMI;Trusted_Connection=no;uid = " + uid + ";pwd= Hanmi@123;  Integrated Security=false ;Connect Timeout=30");
        public SqlConnection con = new SqlConnection(@"Data Source=" + sn + ";Initial Catalog="+dbName+";Trusted_Connection=no;uid = " + uid + ";pwd= " + pwd + ";  Integrated Security=false ;Connect Timeout=30;MultipleActiveResultSets=True");
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
        private async Task ErrorLog(string filePath, string message)
        {
            try
            {
                // Check if the file exists.
                if (!File.Exists(filePath))
                {
                    // If the file doesn't exist, create it.
                    using (FileStream fs = File.Create(filePath))
                    {
                        // Optionally, you can add an initial message or header to the file.
                        byte[] initialMessage = new UTF8Encoding(true).GetBytes("Log File Created\n");
                        await fs.WriteAsync(initialMessage, 0, initialMessage.Length);
                    }
                }

                // Open the file in append mode and write the message.
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}";
                    await writer.WriteLineAsync(logLine);
                }
            }
            catch
            {

            }
        }
        public async Task<bool> ExeDataAsync(string cmd)
        {
            if (con.State != ConnectionState.Open)
            {
                await con.OpenAsync();
            }


            using (var command = new SqlCommand(cmd, con))
            {
                try
                {
                    await command.ExecuteNonQueryAsync();
                    closeconnect();
                    return true;
                }
                catch (Exception ex)
                {
                    await ErrorLog("errorlog.txt", "Command: " + cmd + ".Details: " + ex.Message);
                    return false;
                }
            }


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
        public async Task<DataTable> ReadDataAsync(string cmd)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    await con.OpenAsync();
                }
                DataTable dt = new DataTable();
                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    var reader = await command.ExecuteReaderAsync();
                    dt.Load(reader);
                }
                //bat len bi loi
                //closeconnect();
                return dt;
            }
            catch (Exception ex)
            {
                await ErrorLog("errorlog.txt", "Command: " + cmd + ".Details: " + ex.Message);
                return null;
            }
        }
        
    }
}
