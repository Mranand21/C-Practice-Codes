using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime cdt, bdt;
            cdt = DateTime.Now;
            bdt = dateTimePicker1.Value;
            int x = cdt.Year;
            int y = bdt.Year;
            int z = x - y;
            if (z > 17)
            {
                panel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("YOU ARE NOT ELIGIBLE FOR VOTING");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Name" + textBox1.Text + Environment.NewLine + "Address" + textBox2.Text + Environment.NewLine + "Vote-BJP");
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Name--" + textBox1.Text + Environment.NewLine + "Address--" + textBox2.Text + Environment.NewLine + "Vote-AAP");
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("Name--" + textBox1.Text + Environment.NewLine + "Address--" + textBox2.Text + Environment.NewLine + "Vote-TMC");
            }
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("Name--" + textBox1.Text + Environment.NewLine + "Address--" + textBox2.Text + Environment.NewLine + "Vote-BSP");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

    }
}