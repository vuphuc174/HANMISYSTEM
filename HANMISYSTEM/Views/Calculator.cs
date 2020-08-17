using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANMISYSTEM.Views
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        Double ResultValue = 0; //Hiện thị kết quả tính toán
        String OperationPerformed = ""; //Các phép toán cộng trừ nhân chia
        bool IsOperationPerformed = false;

        private void button17_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtscreen.Text == "0") || (IsOperationPerformed))
                txtscreen.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtscreen.Text.Contains("."))
                    txtscreen.Text = txtscreen.Text + button.Text;
            }
            else
                txtscreen.Text = txtscreen.Text + button.Text;
        }

        private void tinhtoan_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                btnresult.PerformClick();
            }
            OperationPerformed = button.Text;
            ResultValue = Double.Parse(txtscreen.Text);
            label_HienThi.Text = ResultValue + " " + OperationPerformed;
            IsOperationPerformed = true;
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    txtscreen.Text = (ResultValue + Double.Parse(txtscreen.Text)).ToString();
                    break;
                case "-":
                    txtscreen.Text = (ResultValue - Double.Parse(txtscreen.Text)).ToString();
                    break;
                case "*":
                    txtscreen.Text = (ResultValue * Double.Parse(txtscreen.Text)).ToString();
                    break;
                case "/":
                    txtscreen.Text = (ResultValue / Double.Parse(txtscreen.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
            ResultValue = 0;
            label_HienThi.Text = "";
        }
    }
}
