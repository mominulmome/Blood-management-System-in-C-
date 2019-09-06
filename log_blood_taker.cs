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
    public partial class log_blood_taker : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\foisal\foisal\nahid.accdb");
        int count = 0;
        public log_blood_taker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = " select * from Table1 where Email =  '" + email.Text + "' and Password =  '" + password.Text + "' and Type =  'donor'";
            OleDbDataReader reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Access permitted.");
                con.Close();
                this.Hide();
                find_donor find = new find_donor();
                find.Show();

            }
            else
            {
                MessageBox.Show("Access denide");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            be_a_donor donor = new be_a_donor();
            donor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
