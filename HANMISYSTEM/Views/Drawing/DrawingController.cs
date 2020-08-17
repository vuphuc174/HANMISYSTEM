using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Drawing
{
    public partial class DrawingController : Form
    {
        public DrawingController()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtpath.Text = openFileDialog1.FileName;
                axAcroPDF1.src = openFileDialog1.FileName;
                
            }
        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {
            lbsearch.Items.Clear();
            DataTable dtprod = connect.readdata("select top 20 partno from cargo where partno like '%" + txtmodel.Text + "%'");
            for (int i = 0; i < dtprod.Rows.Count; i++)
            {
                lbsearch.Items.Add(dtprod.Rows[i]["PartNo"].ToString());
            }
            lbsearch.Visible = true;
        }

        private void lbsearch_Click(object sender, EventArgs e)
        {
            if (lbsearch.SelectedItem != null)
            {
                txtmodel.Text = lbsearch.SelectedItem.ToString();
                if(connect.countdata("select count(partno) from DrawingVersion")!=0)
                {
                    DataTable dtdraw = connect.readdata("select PDF from DrawingVersion where partno ='"+txtmodel.Text+"'");
                    if(dtdraw.Rows.Count>0)
                    {
                        byte[] ap = (byte[])dtdraw.Rows[0]["PDF"];
                        string tempName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".pdf");
                        File.WriteAllBytes(tempName, ap);
                        axAcroPDF1.src = tempName;
                    }
                    
                }
                lbsearch.Visible = false;
            }

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "" || txtversion.Text == "" || txtpath.Text == "")
            {
                MessageBox.Show("Thêm đầy đủ thông tin trước ");
            }
            else
            {
                databaseFilePut(txtpath.Text);
            }
        }
        public  void databaseFilePut(string varFilePath)
        {
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            SqlConnection varConnection = connect.con;
            varConnection.Open();
            using (var sqlWrite = new SqlCommand("INSERT INTO DrawingVersion (Partno,Name,PDF,UploadDate) Values('" + txtmodel.Text + "','" + txtversion.Text + "',@File,'" + DateTime.UtcNow + "')", varConnection))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
                varConnection.Close();
            }
        }
        public  void databaseFileRead(string varID, string varPathToNewLocation)
        {
            SqlConnection varConnection = connect.con;
            using (var sqlQuery = new SqlCommand(@"SELECT [RaportPlik] FROM [dbo].[Raporty] WHERE [RaportID] = @varID", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
        }
    }
}
