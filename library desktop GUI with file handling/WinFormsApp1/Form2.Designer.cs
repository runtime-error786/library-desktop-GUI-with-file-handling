
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
class var
{
    public static int a=0;
    public int exp = 0;
    public void set()
    {
        exp = a;
    }
    
}

class Lib_rary
{
    

	//  attributes
	public string author;
    public  string isbn;
    public string title;
    public string number_copies;
   public Lib_rary next;

    // default constructor
    public Lib_rary()
{
    author = "";
    isbn = "";
    title = "";
    number_copies = "";
        next = null;
}

// input


};
class node_list
{
    public Lib_rary head;
    // it point to the start of linked list

    // default constructror
    public node_list()
    {
        head = null;
    }

    // parametrized constructor
    public node_list(Lib_rary ptr)
    {
        head = ptr;
    }

    // it load darta from file to the linked list
    public void load_data()
    {

        StreamReader sr = new StreamReader(@"C:\Users\musta\OneDrive\Desktop\WinFormsApp1\WinFormsApp1\like.txt");
        /*if (read)
        {
            cout << "file is open" << endl;
        }
        else
        {
            cout << "file is not open" << endl;
        }*/
        // it check that the file is empty or not
        string author, title;
        string isbn, number_copy;
        //string terminator;
        while (!sr.EndOfStream)
        {
            author = sr.ReadLine();
            title = sr.ReadLine();
            isbn = sr.ReadLine();
            number_copy = sr.ReadLine();
            //read >> terminator;

            Lib_rary obj = new Lib_rary();
            obj.author = author;
            obj.title = title;
            obj.isbn = isbn;
            obj.number_copies = number_copy;

            Lib_rary iter = head;
            if (iter == null)
            {
                head = obj;
                obj.next = null;
            }
            else
            {
                while (iter.next != null)
                {
                    iter = iter.next;
                }
                iter.next = obj;
            }

        }
        sr.Close();

    }

    // it load the data from the linked list to the text file
    public void save_data()
    {
        StreamWriter sw = new StreamWriter(@"C:\Users\musta\OneDrive\Desktop\WinFormsApp1\WinFormsApp1\like.txt");
        /*if (out)
        {
            cout << "file is open" << endl;
        }
        else
        {
            cout << "file is not open" << endl;
        }*/
        Lib_rary obj = head;
        while (obj != null)
        {
            string a1;
            a1 = obj.author;
            sw.WriteLine(a1);
            a1 = obj.title;
            sw.WriteLine(a1);
            a1 = obj.isbn;
            sw.WriteLine(a1);
            a1 = obj.number_copies;
            sw.WriteLine(a1);

            // & denote that the data of one book is complete
            obj = obj.next;
        }
        sw.Close();
        //out.close();
    }

    // delete all linked list
    public void del()
    {
        Lib_rary currnt = head;
        Lib_rary prev = null;
        while (currnt != null)
        {
            prev = currnt.next;
            if (currnt == head)
            {   currnt = null;
                head = null;
            }
            else
            {
                 currnt = null;
            }
            currnt = null;
            currnt = prev;
        }

    }
    public void update(Lib_rary l2)
    {
        // data load from file to text filr
        load_data();

        // update code

        Lib_rary ptr = head;

        // user select whether update the specific data or whol data of book

        bool flag = false;
        while (ptr != null)
        {
            if (ptr.isbn == l2.isbn)
            {
                flag = true;
                ptr.author = l2.author;
                ptr.isbn = l2.isbn;
                ptr.title = l2.title;
                ptr.number_copies = l2.number_copies;
                save_data();
               
                
            }

            ptr = ptr.next;
        }
        if (flag==false)
        {
            MessageBox.Show("data not found");
        }
        else
        {
            MessageBox.Show("data updated successfully");
        }
        del();

    }

    // insert data in to file
    public void create(Lib_rary l1 ,ref bool f1)
    {
        // data load from file to text filr

        load_data();
        Lib_rary p1 = head;
        bool f12 = false;
        while (p1!=null)
        {
            if (p1.isbn==l1.isbn)
            {
                f12= true;
            }
            p1 = p1.next;
        }
        if (f12 == false)
        {
            // and then we take the data from the user
            if (head == null)
            {
                Lib_rary obj = l1;
                head = obj;
                obj.next = null;
                f1 = true;
            }
            else
            {

                Lib_rary obj1 = l1;
                Lib_rary iter1 = head;
                while (iter1 != null)
                {
                    if (iter1.isbn == l1.isbn)
                    {
                        f1 = false;
                        return;
                    }
                    iter1 = iter1.next;
                }

                Lib_rary iter;
                iter = head;
                while (iter.next != null)
                {
                    iter = iter.next;
                }
                iter.next = obj1;
                f1 = true;
            }

            // after take data save data
            save_data();
            del();
        }
        else
        {
            f1 = false;
        }
        
    }

    public void delet_book(string isbn)
    {
        // data load from file to text filr
        load_data();
        // delete the node
        
        bool found = false;
        Lib_rary ptr = head;
        if (head != null && head.isbn == isbn)
        {
            Lib_rary ptr1 = head;
            head = head.next;
            ptr1 = null;
            found = true;
        }
        else
        {
            Lib_rary prev = null;
            while (ptr != null)
            {
                prev = ptr;
                ptr = ptr.next;
                if (ptr != null && ptr.isbn == isbn)
                {
                    prev.next = ptr.next;
                    ptr = null;
                    found = true;
                }
            }
        }
        // save data
        save_data();

        // delete the linked list
        del();
        if (found==true)
        {
            MessageBox.Show("data deleted successfully");
        }
        else
        {
            MessageBox.Show("data not deleted");
        }
    }
}

// it serach by isbn in the text file
//public void search()
//{
//    // data load from file to text filr
//    node_list::load_data();

//    // search code
//    cout << "enter isbn : " << endl;
//    string isbn;
//    cin >> isbn;
//    Lib_rary* ptr = head;
//    bool no_found = false;
//    while (ptr != NULL)
//    {
//        if (ptr->isbn == isbn)
//        {
//            no_found = true;
//            cout << "author : " << ptr->author << endl;
//            cout << "isbn : " << ptr->isbn << endl;
//            cout << "title : " << ptr->title << endl;
//            cout << "number of copies : " << ptr->number_copies << endl;
//            Sleep(2000);
//        }

//        ptr = ptr->next;
//    }
//    if (no_found == false)
//    {
//        cout << "no data found in file" << endl;
//        Sleep(2000);
//    }
//    // delete the linked list
//    del();
//}

//// update the data of book in file




////default constructor

namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(642, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "isbn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(646, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "copies";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(52, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(642, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(642, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(52, 374);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(268, 27);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(462, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.liblaptop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1024, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "library management system";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}