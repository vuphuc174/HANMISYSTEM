using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace HANMISYSTEM
{
    public class Dbconnect
    {
        static string sn = HANMISYSTEM.Properties.Settings.Default.servername;
        static string uid = HANMISYSTEM.Properties.Settings.Default.uid;
        static string pwd = HANMISYSTEM.Properties.Settings.Default.pwd;
        //public SqlConnection con = new SqlConnection(@"Data Source=" + sn + ";Initial Catalog=HANMI;Trusted_Connection=no;uid = " + uid + ";pwd= Hanmi@123;  Integrated Security=false ;Connect Timeout=30");
        public SqlConnection con = new SqlConnection(@"Data Source=192.168.1.252,1434;Initial Catalog=HANMI;Trusted_Connection=no;uid = sa;pwd= Hanmi@123;  Integrated Security=false ;Connect Timeout=30;MultipleActiveResultSets=True");
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
        public bool StoreImage(string pn, byte[] imageBytes)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand($"Update cargo set Image =@Image where partno ='{pn}'", con);

                // Add image parameter to command object
                SqlParameter parameter = new SqlParameter("@Image", System.Data.SqlDbType.VarBinary, -1);
                parameter.Value = imageBytes;
                command.Parameters.Add(parameter);

                // Execute command

                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Image GetImage(string id)
        {
            openconnect();
            SqlCommand cmd = new SqlCommand($"SELECT Image FROM cargo WHERE partno = '{id}'", con);
            byte[] imageData = (byte[])cmd.ExecuteScalar();
            closeconnect();

            MemoryStream ms = new MemoryStream(imageData);
            Image image = Image.FromStream(ms);

            return image;
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
        public async Task ExeDataAsync(string cmd)
        {
            await con.OpenAsync();

            using (var command = new SqlCommand(cmd, con))
            {
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch(Exception ex)
                {
                    await ErrorLog("errorlog.txt", "Command: " + cmd + ".Details: " + ex.Message);
                }
            }
            con.Close();

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
        public async Task<DataTable> ReadDataAsync(string cmd)
        {
            DataTable dt = new DataTable();
            openconnect();

            using (SqlCommand command = new SqlCommand(cmd, con))
            {
                var reader = await command.ExecuteReaderAsync();
                dt.Load(reader);
            }

            closeconnect();

            return dt;
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

