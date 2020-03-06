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
    public partial class lbl_Firstname : Form
    {
        public lbl_Firstname()
        {
            InitializeComponent();
        }

        

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
        private void lbl_Firstname_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            string fn, ln;
            fn = txtBox1.Text;
            ln = txtBox2.Text;
            MessageBox.Show("Happy Birthday" + txtBox1.Text + txtBox2.Text);
            
        }
    }
}
