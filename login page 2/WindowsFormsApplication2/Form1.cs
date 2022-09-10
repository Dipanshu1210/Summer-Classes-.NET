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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Dipanshu" && textBox2.Text == "1234")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password");
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Name = "Dipanshu";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Name = "1234";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
