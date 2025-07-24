using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp23
{
    public partial class UserControlCategory : UserControl
    {
        private string id = "";
        private readonly string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

        public UserControlCategory()
        {
            InitializeComponent();
            this.Load += UserControlCategory_Load;
        }

        private void UserControlCategory_Load(object? sender, EventArgs e)
        {
            LoadCategories();
        }

        public void EmptyBox()
        {
            txtCategoryName.Clear();

            
            if (!cmbStatus.Items.Contains("------Select--------"))
            {
                cmbStatus.Items.Insert(0, "------Select-------");
            }

            cmbStatus.SelectedIndex = 0;
        }
        private void EmptyBox1()
        {
            txtCategoryName1.Clear();
            if (!cmbStatus1.Items.Contains("---Select---------"))
            {
                cmbStatus1.Items.Insert(0, "-----Select-----------");
            }

            cmbStatus1.SelectedIndex = 0;

            id = "";
        }

        private void LoadCategories()
        {
            try
            {
                dgvCategory.Rows.Clear();
                using SqlConnection con = new SqlConnection(connectionString);
                string query = "SELECT Category_Id, Category_Name, Category_Status FROM Category";

                using SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvCategory.Rows.Add(
                        reader["Category_Id"],
                        reader["Category_Name"],
                        reader["Category_Status"]
                    );
                }

                if (dgvCategory.Columns.Count > 0)
                    dgvCategory.Columns[0].Visible = false;

                lblTotal.Text = dgvCategory.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
        }

        private void picSearch_MouseHover(object? sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search for a category");
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a category name");
                return;
            }
            if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a status");
                return;
            }

            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                string query = "INSERT INTO Category (Category_Name, Category_Status) VALUES (@Name, @Status)";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCategoryName.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem!.ToString());

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category added successfully!");
                EmptyBox();
                LoadCategories();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add failed: {ex.Message}");
            }
        }

        private void tpAddCategory_Enter(object? sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageCategory_Enter(object? sender, EventArgs e)
        {
            txtSearchCategory.Clear();
            LoadCategories();
        }

        private void txtSearchCategory_TextChanged(object? sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                string query = "SELECT Category_Id, Category_Name, Category_Status FROM Category WHERE Category_Name LIKE @Search";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearchCategory.Text.Trim() + "%");
                con.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvCategory.Rows.Add(
                        reader["Category_Id"],
                        reader["Category_Name"],
                        reader["Category_Status"]
                    );
                }
                lblTotal.Text = dgvCategory.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}");
            }
        }

        private void dgvCategory_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                id = row.Cells[0].Value?.ToString() ?? "";
                txtCategoryName1.Text = row.Cells[1].Value?.ToString() ?? "";
                cmbStatus1.SelectedItem = row.Cells[2].Value?.ToString();
                tcCategory.SelectedTab = tpOptions;
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select a category");
                return;
            }
            if (txtCategoryName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a category name");
                return;
            }
            if (cmbStatus1.SelectedIndex == 0)
            {
                MessageBox.Show("Select a status");
                return;
            }

            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                string query = "UPDATE Category SET Category_Name=@Name, Category_Status=@Status WHERE Category_Id=@Id";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtCategoryName1.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", cmbStatus1.SelectedItem!.ToString());
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category updated!");
                EmptyBox1();
                LoadCategories();
                tcCategory.SelectedTab = tpManageCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}");
            }
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Select a category");
                return;
            }

            var result = MessageBox.Show("Delete this category?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using SqlConnection con = new SqlConnection(connectionString);
                    string query = "DELETE FROM Category WHERE Category_Id=@Id";
                    using SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category deleted.");
                    EmptyBox1();
                    LoadCategories();
                    tcCategory.SelectedTab = tpManageCategory;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete failed: {ex.Message}");
                }
            }
        }

        private void tpOptions_Enter(object? sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Select a category first");
                tcCategory.SelectedTab = tpManageCategory;
            }
            else
            {
                txtCategoryName1.Text = "";
                cmbStatus1.SelectedIndex = 0;
            }
        }

        private void tpOptions_Leave(object? sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
