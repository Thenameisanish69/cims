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

namespace WinFormsApp23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gender = "";
            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            else
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ageText = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(ageText))
            {
                MessageBox.Show("Please enter your age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValidNumber = int.TryParse(ageText, out int age);

            if (!isValidNumber || age < 0 || age > 50)
            {
                MessageBox.Show("Please enter a valid age between 0 and 120.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dob = dateTimePicker1.Value;

            string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO users (Firstname, Lastname, username, password, [Date of birth], Age, Gender) " +
                               "VALUES (@Firstname, @Lastname, @Username, @Password, @DOB, @Age, @Gender)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Firstname", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Lastname", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", textBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !checkBox1.Checked;
        
    }
    }
}



