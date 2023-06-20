namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(182, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Blue;
            this.display.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.display.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(801, 218);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(134, 52);
            this.display.TabIndex = 1;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(193, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(487, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Blue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(445, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 38);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(801, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1071, 573);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button display;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Button button4;
    }
}