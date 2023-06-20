using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string author = textBox3.Text;
            string isbn = textBox4.Text;
            string copies = textBox2.Text;
            Lib_rary l1 = new Lib_rary();
            l1.author = author;
            l1.isbn = isbn;
            l1.title = name;
            l1.number_copies = copies;
            bool f33 = false;
            if (name != "" && author != "" && isbn != "" && copies != "")
            {
                node_list n1 = new node_list();
                n1.create(l1, ref f33);
            }
            if (f33==true)
            {
                MessageBox.Show("enter successfully");
            }
            else
            {
                MessageBox.Show("not enter");
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
