using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace foisal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            be_a_donor donor = new be_a_donor();
            donor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            log_blood_taker taker = new log_blood_taker();
            taker.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_show admin = new Admin_show();
            admin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
