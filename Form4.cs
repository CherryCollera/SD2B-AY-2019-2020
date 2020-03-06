using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetMe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void lbl_firstnum_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_SecondNum_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Double firstnum, Secondnum;
            firstnum = Convert.ToDouble(textBox1.Text);
            Secondnum = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (firstnum + Secondnum).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            Double firstnum;
            firstnum = Convert.ToDouble(textBox1.Text);
            Double Secondnum;
            Secondnum = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (firstnum * Secondnum).ToString();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            Double firstnum, Secondnum;
            firstnum = Convert.ToDouble(textBox1.Text);
            Secondnum = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (firstnum - Secondnum).ToString();
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            Double firstnum, Secondnum, Quotient;

            firstnum = Convert.ToDouble(textBox1.Text);
            Secondnum = Convert.ToDouble(textBox2.Text);
            Quotient = Math.Round(firstnum / Secondnum, 2);
            textBox3.Text = (Quotient).ToString();
            
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            Double firstnum, Secondnum;
            firstnum = Convert.ToDouble(textBox1.Text);
            Secondnum = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (firstnum % Secondnum).ToString();

        
    }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
