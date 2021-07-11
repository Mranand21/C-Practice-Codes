using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
            double Fn;
            string Op;
            public Form1()
            {
         
                InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            { 
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            { 
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else 
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) 
            {
                textBox1.Text = "4";
            }
            else 
            {
                textBox1.Text = textBox1.Text + "4"; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else 
            {
                textBox1.Text = textBox1.Text + "5"; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7"; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) 
            {
                textBox1.Text = "8"; 
            }
            else
            {
                textBox1.Text = textBox1.Text + "8"; 
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) 
            { 
                textBox1.Text = "0";
            } 
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0"; 
            Op = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text); 
            textBox1.Text = "0";
            Op = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double Sn;
            double Res;
            Sn = Convert.ToDouble(textBox1.Text);
            if (Op == "+")
            {
                Res = (Fn + Sn);
                textBox1.Text = Convert.ToString(Res);
                Fn = Res;
            }
            if (Op == "-")
            {
                Res = (Fn -Sn);
                textBox1.Text = Convert.ToString(Res); Fn = Res;
            } 
            if (Op == "*") 
            {
                Res = (Fn * Sn);
                textBox1.Text = Convert.ToString(Res);
                Fn = Res; 
            }
            if (Op == "/") 
            {
                if (Sn == 0) 
                {
                    textBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    Res = (Fn / Sn);
                    textBox1.Text = Convert.ToString(Res); 
                    Fn = Res; 
                }
            }
        }

     }
}
