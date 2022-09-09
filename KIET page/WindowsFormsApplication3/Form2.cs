using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Name = "Dipanshu";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Name = "1234";
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
