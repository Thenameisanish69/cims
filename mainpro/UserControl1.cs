using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp23
{
    public partial class UserControl11 : UserControl
    {
        private readonly string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

        public UserControl11()
        {
            InitializeComponent();
            this.Load += UserControl11_Load;
        }

        private void UserControl11_Load(object? sender, EventArgs e) 
        {
            RefreshStats(); 
        }

        public void RefreshStats()
        {
            try
            {
                lbltotalproduct.Text = GetCount("SELECT COUNT(*) FROM Product").ToString();
                lbltotalorder.Text = GetCount("SELECT COUNT(*) FROM Orders").ToString();
                lbllowstock.Text = GetCount("SELECT COUNT(*) FROM Product WHERE Status = 'Not available'").ToString();
                lbltotalrevenue.Text = GetSum("SELECT SUM(Grand_Total) FROM Orders WHERE Payment_status='Paid'").ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCount(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private decimal GetSum(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }
    }
}
