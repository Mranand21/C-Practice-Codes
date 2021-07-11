using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataRow dr;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\anmri\Database1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from [Day]", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new object[]{0, "-Select Day-"};
            dt.Rows.InsertAt(dr, 0);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Day";
            comboBox1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
            if(comboBox1.Text == "Wednesday")
            {
                button1.ForeColor = Color.Orange;
            }
            else if(comboBox1.Text == "Sunday")
            {
                button1.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Mrinal!");
        }
    }
}
