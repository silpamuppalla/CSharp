using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "SILPA";
            txtLastName.Text = "MUPPALLA";
            txtAddressOne.Text = "NJIT";
            txtAddress2.Text = "NEWARK";
            txtCity.Text = "NEWARK";
            txtCountry.Text = "USA";
            txtState.Text = "NEW JERSEY";
            txtSsn.Text= 11223344.ToString();
            txtPhone.Text = 1234567890.ToString();
        }
    } 
}
