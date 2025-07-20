namespace WinFormsApp23
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(565, 267);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(424, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Orange;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(756, 365);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Signup";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // button1
            // 
            button1.Location = new Point(329, 267);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 131);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter password";
            textBox2.Size = new Size(286, 31);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 80);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username";
            textBox1.Size = new Size(279, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(287, 134);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 80);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 67, 108);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(0, -27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 571);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 547);
            Controls.Add(panel2);
            Name = "Form1";
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
    }
}
