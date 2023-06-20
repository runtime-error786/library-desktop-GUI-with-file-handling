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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            node_list l1 = new node_list();
            string author, name, isbn, copies;
            author = textBox6.Text;
            name = textBox3.Text;
            isbn = textBox5.Text;
            copies = textBox4.Text;
            Lib_rary l2 = new Lib_rary();
            l2.author = author;
            l2.title = name;
            l2.isbn = isbn;
            l2.number_copies = copies;
            l1.update(l2);
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
