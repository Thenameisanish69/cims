﻿namespace WinFormsApp23
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
            button2 = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Poppins", 9F);
            button2.Location = new Point(206, 347);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 25);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Poppins", 9F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(131, 299);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 26);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Orange;
            linkLabel1.Font = new Font("Poppins", 9F);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(166, 403);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 22);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signup";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 58, 162);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins", 9F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(100, 347);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 25);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 267);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter password";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 203);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 234);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 170);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.bg;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 465);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins ExtraBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(138, 57);
            label3.Name = "label3";
            label3.Size = new Size(109, 51);
            label3.TabIndex = 9;
            label3.Text = "Log In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 465);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button button2;
        private Panel panel2;
        private Label label3;
    }
}
