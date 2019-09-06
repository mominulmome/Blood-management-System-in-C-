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
    public partial class log_in : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\foisal\foisal\nahid.accdb");
        int count = 0;
        public log_in()
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
            
            con.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = " select * from Table1 where Email =  '"+ email.Text+"' and Password =  '"+ password.Text +"' and Type =  'admin'";
            OleDbDataReader reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            count = 0;
            while(reader.Read())
            {
                count++;
            }

            if(count == 1)
            {
                MessageBox.Show("Access permitted.");
                con.Close();
                this.Hide();
                Admin_show admin = new Admin_show();
                admin.Show();

            }
            else
            {
                MessageBox.Show("Access denide");
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
