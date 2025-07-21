namespace WinFormsApp23
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            button3 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 82);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 168);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Date of birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 127);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(200, 125);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(343, 125);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(65, 213);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 7;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(65, 280);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 8;
            label7.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter firstname";
            textBox1.Size = new Size(281, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 82);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter lastname";
            textBox2.Size = new Size(281, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 213);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter username";
            textBox5.Size = new Size(300, 31);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(200, 277);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Enter password";
            textBox6.Size = new Size(300, 31);
            textBox6.TabIndex = 14;
            textBox6.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 58, 162);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(113, 447);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 160);
            dateTimePicker1.MaxDate = new DateTime(2006, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2006, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(188, 346);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 29);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 15, 45);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 493);
            panel2.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(268, 447);
            button3.Name = "button3";
            button3.Size = new Size(111, 34);
            button3.TabIndex = 16;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 493);
            Controls.Add(panel2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Panel panel2;
        private Button button3;
    }
}