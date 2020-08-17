using HANMISYSTEM.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM
{
    public partial class bomdaiban : Form
    {
        public bomdaiban()
        {
            InitializeComponent();
        }
        Dbconnect connect = new Dbconnect();
        private void bomdaiban_Load(object sender, EventArgs e)
        {
            cbloaihang.SelectedIndex = 2;
            DataTable dtthanhpham = connect.readdata("select partno,partname,(select count(rawpartno) from bomdaiban b where b.partno= c.partno ) as rawqty from cargo c where idcategory=3");
            dataGridView1.DataSource = dtthanhpham;
        }
        int _result;
        private int mahoa(string s)
        {
            switch (s)
            {
                case "Nguyên Vật Liệu":
                    _result = 1;
                    break;
                case "Bán Thành Phẩm":
                    _result = 2;
                    break;
                case "Thành Phẩm":
                    _result = 3;
                    break;
            }
            return _result;
        }
        private void cbloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtcargo = connect.readdata("select partno,partname,(select count(rawpartno) from bomdaiban b where b.partno= c.partno ) as rawqty from cargo c where idcategory='"+mahoa(cbloaihang.Text)+"'");
            dataGridView1.DataSource = dtcargo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dtcargo = connect.readdata("select partno,partname,(select count(rawpartno) from bomdaiban b where b.partno= c.partno ) as rawqty from cargo c where idcategory='" + mahoa(cbloaihang.Text) + "' and partno like '%" + txtpartno.Text + "%' or idcategory='" + mahoa(cbloaihang.Text) + "' and partname like '%" + txtpartno.Text + "%' ");
            dataGridView1.DataSource = dtcargo;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
        }
        private string sql;
        private void btnexcel_Click(object sender, EventArgs e)
        {

            sql = "";
            ExportToExcel _excel = new ExportToExcel();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(Convert.ToBoolean(row.Cells[0].Value))
                {
                    if(sql=="")
                    {
                        sql =sql+"'"+ row.Cells["partno"].Value.ToString()+"'";
                    }
                    else
                    {
                        sql =sql+ "or partno= '" + row.Cells["partno"].Value.ToString() +"'"; 
                    }
                }
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dtplan = connect.readdata("with temp(partno,rawpartno,quantity) as(select partno,rawpartno,quantity from bomdaiban where partno ="+sql+" union all select a.partno,b.rawpartno,a.quantity*b.quantity from temp as a, bomdaiban as b where a.rawpartno=b.partno ) select distinct temp1.partno,(select partname from cargo c where c.partno =temp1.partno) as partname,rawpartno,(select partname from cargo c where c.partno =temp1.rawpartno) as rawpartname,(select nameunit from unit inner join cargo on unit.idunit=cargo.idunit where cargo.partno=temp1.rawpartno) as unit,SUM(quantity) as qty  from (select   * from temp t1  where (select count(rawpartno) from  bomdaiban b1 where t1.rawpartno=b1.partno ) =0) as temp1  inner join cargo c1 on temp1.partno=c1.partno group by temp1.partno,rawpartno order by temp1.partno asc");
                _excel.ExportToExcelFunction(dtplan, saveFileDialog1.FileName.ToString());
            }
        
        }
    }
}
