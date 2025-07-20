using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Azure.Core.HttpHeader;


namespace WinFormsApp23
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Firstname FROM users WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (cmd.ExecuteScalar() is string firstname)
                    {
                        MessageBox.Show("Hello, " + firstname + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Home homeForm = new Home(username);
                        this.Hide();
                        homeForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    con.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 registrationForm = new Form2();

            registrationForm.ShowDialog();
            this.Show();
        }
    }
}




