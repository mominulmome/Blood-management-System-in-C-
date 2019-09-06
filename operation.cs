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
    
    public partial class operation : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\foisal\foisal\nahid.accdb");
        int count = 0;
        public operation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_show a_s = new Admin_show();
            a_s.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {

            count = 0;
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select Name, Location, Weight, Bgroup, Gender, Email, Phone from Table1 where Phone =  '" + pnumber.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            con.Close();

            if (count == 0)
            {
                MessageBox.Show("Record is not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Table1 where Phone = '"+ pnumber.Text +"' ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Donor deletion successful.");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            //MessageBox.Show(u_n.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

                cmd.CommandText = " update Table1 set Name = '" + u_n.Text + "', Location = '" + u_l.Text + "', Email = '" + u_e.Text + "', Weight = '" + u_w.Text + "', Phone = '" + u_p.Text + "' where Phone = '" + pnumber.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donor information updated successful.");
                con.Close();
            u_n.Text = "";
            u_l.Text = "";
            u_e.Text = "";
            u_w.Text = "";
            u_p.Text = "";
        }

        private void u_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void u_n_Validating(object sender, CancelEventArgs e)
        {
            /*
            if(string.IsNullOrEmpty(u_n.Text))
            {
                e.Cancel = true;
                u_n.Focus();
                errorProviderName.SetError(u_n, "Please enter the name");

            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(u_n, null);
            }
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_show a_s = new Admin_show();
            a_s.Show();
        }
    }
}
