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
    public partial class be_a_donor : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\foisal\foisal\nahid.accdb");
        public be_a_donor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in go = new log_in();
            go.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table1 values('"+ name.Text+ "','" + location.Text + "','" + weight.Text + "','" + b_g.Text + "'," +
                "'" + gender.Text + "','" + email.Text + "','" + password.Text + "','" + phone.Text + "','donor')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("You are successfully registered as a blood donor.");
            this.Hide();
            log_blood_taker go = new log_blood_taker();
            go.Show();
        }

        private void be_a_donor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
