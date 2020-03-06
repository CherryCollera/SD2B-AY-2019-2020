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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void lbl_Lastname_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btn_GetMyProfile_Click(object sender, EventArgs e)
        {
            string first, last;
            first = textBox1.Text;
            last = textBox2.Text;
            MessageBox.Show("Name\t:\t\t Hello "+ first + last +"\n\nDate of Birth\t:\tNovember 14\n\n\tCourse\t\t:\t\tBS computer Science\n\n\tYear\t\t:\t\tII\n\n\tSection\t\t:\t\tSD2B\n\n");
          
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            lbl_Firstname frm = new lbl_Firstname();
            frm.Show();
            this.Hide();
        }
    }
}
