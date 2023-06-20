using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                string author, name, isbn, copies;
                StreamReader sr = new StreamReader(@"C:\Users\musta\OneDrive\Desktop\WinFormsApp1\WinFormsApp1\like.txt");
                while (!sr.EndOfStream)
                {
                    author = sr.ReadLine();
                    name = sr.ReadLine();
                    isbn = sr.ReadLine();
                    copies = sr.ReadLine();
                    dataGridView1.Rows.Add(author, name, isbn, copies);
                }
                sr.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
