using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double a = 0;
        String operation = "";
        bool operationperf = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (operationperf))
                txtDisplay.Clear();
            operationperf = false;
            Button buttonOne = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + buttonOne.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            a = Double.Parse(txtDisplay.Text);
            operationperf = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void equal(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (a + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (a - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (a * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (a / Double.Parse(txtDisplay.Text)).ToString();
                    break; 
                default:
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

    }
}
