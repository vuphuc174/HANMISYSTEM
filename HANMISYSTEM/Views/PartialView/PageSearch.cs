using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views.PartialView
{
    public partial class PageSearch : Form
    {
        public PageSearch()
        {
            InitializeComponent();
        }
        public int totalPage;
        public int page;
        public int SendPageIndex()
        {
            return page ;
        }
        private void btnGoPage_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value>0 && numericUpDown1.Value <=totalPage)
            {
                page = Convert.ToInt32(numericUpDown1.Value);
            }
            this.Close();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
