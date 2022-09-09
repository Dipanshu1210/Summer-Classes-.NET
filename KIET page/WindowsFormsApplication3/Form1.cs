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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       

       
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm1 = new Form4();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm1 = new Form5();
            frm1.MdiParent = this;
            frm1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
