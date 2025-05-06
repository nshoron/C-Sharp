using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);
                int Result = Num1 + Num2;
                label10.Text = "Result is : " + Result;
                label10.Visible = true;
            }
            else
            {
                label10.Text = "Invalid Input";
                label10.Visible = true;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);
                int Result = Num1 - Num2;
                label10.Text = "Result is : " + Result;
                label10.Visible = true;
            }
            else
            {
                label10.Text = "Invalid Input";
                label10.Visible = true;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);
                int Result = Num1 * Num2;
                label10.Text = "Result is : " + Result;
                label10.Visible = true;
            }
            else
            {
                label10.Text = "Invalid Input";
                label10.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);
                int Result = Num1 / Num2;
                label10.Text = "Result is : " + Result;
                label10.Visible = true;
            }
            else
            {
                label10.Text = "Invalid Input";
                label10.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
