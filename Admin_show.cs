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
    public partial class Admin_show : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\foisal\foisal\nahid.accdb");
        int count = 0;
        public Admin_show()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Table1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int next = this.dataGridView1.CurrentRow.Index + 1;
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[next].Cells[this.dataGridView1.CurrentCell.ColumnIndex];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int prev = this.dataGridView1.CurrentRow.Index - 1;
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[prev].Cells[this.dataGridView1.CurrentCell.ColumnIndex];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            operation ope = new operation();
            ope.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CloseSockets();
            this.Close();
            log_in login = new log_in();
            login.Show();
        }
    }
}
