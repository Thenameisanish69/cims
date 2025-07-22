namespace WinFormsApp23
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            pnlMove = new Panel();
            button7 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel2 = new Panel();
            lblusername = new Label();
            label3 = new Label();
            panel3 = new Panel();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            userControlBrand11 = new userControlBrand1();
            userControl111 = new UserControl11();
            userControlCategory1 = new UserControlCategory();
            userControlBrand12 = new userControlBrand1();
            userControlOrder1 = new UserControlOrder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 15, 45);
            panel1.Controls.Add(pnlMove);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 588);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // pnlMove
            // 
            pnlMove.BackColor = Color.White;
            pnlMove.Location = new Point(30, 155);
            pnlMove.Margin = new Padding(2);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(7, 37);
            pnlMove.TabIndex = 1;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(41, 415);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(140, 23);
            button7.TabIndex = 0;
            button7.Text = "          Logout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.order1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(42, 329);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(113, 39);
            button5.TabIndex = 0;
            button5.Tag = " ";
            button5.Text = "        Order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.category1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(42, 208);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(113, 39);
            button3.TabIndex = 0;
            button3.Text = "           Category";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.product1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(42, 268);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(113, 39);
            button2.TabIndex = 0;
            button2.Text = "          Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.dashboard3;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(41, 155);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 39);
            button1.TabIndex = 0;
            button1.Text = "             Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 0;
            label2.Text = "Management system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Computer Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = pnlMove;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 151, 196);
            panel2.Controls.Add(lblusername);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(234, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 71);
            panel2.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.White;
            lblusername.Location = new Point(147, 13);
            lblusername.Margin = new Padding(2, 0, 2, 0);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(32, 25);
            lblusername.TabIndex = 3;
            lblusername.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Welcome";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 151, 196);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(234, 563);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 25);
            panel3.TabIndex = 2;
            // 
            // userControlBrand11
            // 
            userControlBrand11.BackColor = Color.White;
            userControlBrand11.Dock = DockStyle.Fill;
            userControlBrand11.Location = new Point(0, 0);
            userControlBrand11.Margin = new Padding(1);
            userControlBrand11.Name = "userControlBrand11";
            userControlBrand11.Size = new Size(1144, 588);
            userControlBrand11.TabIndex = 4;
            // 
            // userControl111
            // 
            userControl111.Dock = DockStyle.Fill;
            userControl111.Location = new Point(234, 71);
            userControl111.Margin = new Padding(1);
            userControl111.Name = "userControl111";
            userControl111.Size = new Size(910, 492);
            userControl111.TabIndex = 3;
            userControl111.Load += userControl111_Load;
            // 
            // userControlCategory1
            // 
            userControlCategory1.BackColor = Color.White;
            userControlCategory1.Dock = DockStyle.Fill;
            userControlCategory1.Location = new Point(234, 71);
            userControlCategory1.Margin = new Padding(1);
            userControlCategory1.Name = "userControlCategory1";
            userControlCategory1.Size = new Size(910, 492);
            userControlCategory1.TabIndex = 0;
            // 
            // userControlBrand12
            // 
            userControlBrand12.BackColor = Color.White;
            userControlBrand12.Dock = DockStyle.Fill;
            userControlBrand12.Location = new Point(234, 71);
            userControlBrand12.Margin = new Padding(1);
            userControlBrand12.Name = "userControlBrand12";
            userControlBrand12.Size = new Size(910, 492);
            userControlBrand12.TabIndex = 0;
            // 
            // userControlOrder1
            // 
            userControlOrder1.BackColor = Color.White;
            userControlOrder1.Dock = DockStyle.Fill;
            userControlOrder1.Location = new Point(234, 71);
            userControlOrder1.Margin = new Padding(1);
            userControlOrder1.Name = "userControlOrder1";
            userControlOrder1.Size = new Size(910, 492);
            userControlOrder1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 588);
            Controls.Add(userControlOrder1);
            Controls.Add(userControlBrand12);
            Controls.Add(userControlCategory1);
            Controls.Add(userControl111);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(userControlBrand11);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computer Shop management system";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button7;
        private Panel pnlMove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel2;
        private Label lblusername;
        private Label label3;
        private Panel panel3;
       
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
     
        private userControlBrand1 userControlBrand11;
        private UserControl11 userControl111;
        private UserControlCategory userControlCategory1;
        private userControlBrand1 userControlBrand12;
        private UserControlOrder userControlOrder1;
    }
}