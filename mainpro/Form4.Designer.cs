namespace WinFormsApp23
{
    partial class Form4
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label1 = new Label();
            panel1 = new Panel();
            guna2CustomGradientPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Location = new Point(12, 634);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(251, 51);
            guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 16);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "Logout";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(guna2CustomGradientPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 759);
            panel1.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 759);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label label1;
        private Panel panel1;
    }
}