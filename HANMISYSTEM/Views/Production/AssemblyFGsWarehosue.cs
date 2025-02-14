using HANMISYSTEM.DAO;
using HANMISYSTEM.Views.Production.AssemblyFGsWarehosues;
using HANMISYSTEM.Views.Production.BravoWorkOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.Production
{
    public partial class AssemblyFGsWarehosue : Form
    {
        DAO_AssemblyFGsWarehouse dAO_AssemblyFGsWarehouse = new DAO_AssemblyFGsWarehouse();
        DAO_Line dAO_Line = new DAO_Line();
        DAO_Credential dAO_Credential = new DAO_Credential();
        public AssemblyFGsWarehosue()
        {
            InitializeComponent();
        }
        public async Task Loaddata()
        {
            try
            {
                dataGridView1.DataSource = await dAO_AssemblyFGsWarehouse.Filter(txtPartno.Text, cbbLine.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await Loaddata();
        }

        private async void BravoWorkOrderManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cbbLine.DataSource =await dAO_Line.GetLines();
                cbbLine.DisplayMember = "namelocation1";
                cbbLine.ValueMember = "idlocation";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the column is the checkbox column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Select_col" && e.RowIndex >= 0)
            {
                // Deselect all other checkboxes
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        row.Cells["Select_col"].Value = false;
                    }
                }
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            if (await dAO_Credential.CheckCredential("UPDATE_ASSEMBLY_WAREHOUSE"))
            {
                dataGridView1.EndEdit();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Check if the checkbox is selected
                    if (Convert.ToBoolean(row.Cells["Select_col"].Value) == true)
                    {
                        // Retrieve the value from another column, if needed
                        var dataValue = row.Cells["partno_col"].Value?.ToString();
                        using (Edit frm = new Edit())
                        {
                            frm._partno = dataValue;
                            frm._lineID = row.Cells["lineid_col"].Value?.ToString();
                            frm.ShowDialog();
                            await Loaddata();
                        }
                        return; // Exit after finding the selected row
                    }
                }
                MessageBox.Show("No row selected.");
            }

              
        }

        private async void btnCreateWO_Click(object sender, EventArgs e)
        {
            if (await dAO_Credential.CheckCredential("CREATE_BRAVO_WO"))
            {
                dataGridView1.EndEdit();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Check if the checkbox is selected
                    if (Convert.ToBoolean(row.Cells["Select_col"].Value) == true)
                    {
                        // Retrieve the value from another column, if needed
                        var dataValue = row.Cells["partno_col"].Value?.ToString();
                        using (AddBravoWorkOrder frm = new AddBravoWorkOrder())
                        {
                            frm._partno = dataValue;
                            frm._lineID = row.Cells["lineid_col"].Value?.ToString();
                            frm.ShowDialog();
                            await Loaddata();
                        }
                        return; // Exit after finding the selected row
                    }
                }
                MessageBox.Show("No row selected.");
            }
        }
    }
}
