namespace WinFormsApp23
{
    partial class UserControl11
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl11));
            panel1 = new Panel();
            lbltotalproduct = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel2 = new Panel();
            lbltotalorder = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel3 = new Panel();
            lbllowstock = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel4 = new Panel();
            label2 = new Label();
            lbltotalrevenue = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(22, 67, 108);
            panel1.Controls.Add(lbltotalproduct);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(45, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 144);
            panel1.TabIndex = 0;
            // 
            // lbltotalproduct
            // 
            lbltotalproduct.AutoSize = true;
            lbltotalproduct.ForeColor = Color.White;
            lbltotalproduct.Location = new Point(136, 69);
            lbltotalproduct.Name = "lbltotalproduct";
            lbltotalproduct.Size = new Size(30, 25);
            lbltotalproduct.TabIndex = 0;
            lbltotalproduct.Text = "{?}";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 30);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel2;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(57, 151, 196);
            panel2.Controls.Add(lbltotalorder);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(436, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 144);
            panel2.TabIndex = 1;
            // 
            // lbltotalorder
            // 
            lbltotalorder.AutoSize = true;
            lbltotalorder.ForeColor = Color.White;
            lbltotalorder.Location = new Point(136, 69);
            lbltotalorder.Name = "lbltotalorder";
            lbltotalorder.Size = new Size(30, 25);
            lbltotalorder.TabIndex = 0;
            lbltotalorder.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(136, 30);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 0;
            label4.Text = "Total orders";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = panel3;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.FromArgb(74, 183, 154);
            panel3.Controls.Add(lbllowstock);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(45, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 144);
            panel3.TabIndex = 1;
            // 
            // lbllowstock
            // 
            lbllowstock.AutoSize = true;
            lbllowstock.ForeColor = Color.White;
            lbllowstock.Location = new Point(136, 69);
            lbllowstock.Name = "lbllowstock";
            lbllowstock.Size = new Size(30, 25);
            lbllowstock.TabIndex = 0;
            lbllowstock.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(136, 30);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 0;
            label6.Text = "Low stock";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.TargetControl = panel4;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.FromArgb(106, 183, 79);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lbltotalrevenue);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(436, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 144);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 69);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 1;
            label2.Text = "Rs";
            // 
            // lbltotalrevenue
            // 
            lbltotalrevenue.AutoSize = true;
            lbltotalrevenue.ForeColor = Color.White;
            lbltotalrevenue.Location = new Point(182, 69);
            lbltotalrevenue.Name = "lbltotalrevenue";
            lbltotalrevenue.Size = new Size(30, 25);
            lbltotalrevenue.TabIndex = 0;
            lbltotalrevenue.Text = "{?}";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(136, 30);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 0;
            label8.Text = "Total Revenue";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(98, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // UserControl11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl11";
            Size = new Size(1174, 577);
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbltotalproduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Panel panel2;
        private Label lbltotalorder;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lbllowstock;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label lbltotalrevenue;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
