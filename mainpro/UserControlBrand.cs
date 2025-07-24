using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp23
{
    public partial class userControlBrand1 : UserControl
    {
        private string id = "";
        private readonly string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

        public userControlBrand1()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserControlBrand_Load);
            tcProduct.SelectedIndexChanged += TcProduct_SelectedIndexChanged;
            tpAddProduct.Enter += TpAddProduct_Enter; 

        }

        private void TpAddProduct_Enter(object? sender, EventArgs e)
        {
            LoadCategories(); 
        }

        private void TcProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tcProduct.SelectedTab == tpOptions)
            {
                LoadCategories(setDefaultSelection: false);
            }
        }

        public void RefreshCategories()
        {
            LoadCategories();
        }

        private void UserControlBrand_Load(object? sender, EventArgs e)
        {
            LoadCategories();
            if (cmbstatus != null)
            {
                cmbstatus.Items.Clear();
                cmbstatus.Items.Add("-----Select-------");
                cmbstatus.Items.Add("Available");
                cmbstatus.Items.Add("Unavailable");
                cmbstatus.SelectedIndex = 0;
            }
            if (cmbStatus2 != null)
            {
                cmbStatus2.Items.Clear();
                cmbStatus2.Items.Add("-----Select-----");
                cmbStatus2.Items.Add("Available");
                cmbStatus2.Items.Add("Unavailable");

                cmbStatus2.SelectedIndex = 0;
            }
            if (cmbstatus != null) cmbstatus.SelectedIndex = 0;
           
            LoadProducts();
        }

        private void LoadCategories(bool setDefaultSelection = true)
        {
            try
            {
                string currentCategory = cmbCategory?.SelectedItem?.ToString() ?? "";
                string currentCategory2 = cmbCategory2?.SelectedItem?.ToString() ?? "";

                if (cmbCategory != null) cmbCategory.Items.Clear();
                if (cmbCategory2 != null) cmbCategory2.Items.Clear();

                if (cmbCategory != null) cmbCategory.Items.Add("-----Select-----");
                if (cmbCategory2 != null) cmbCategory2.Items.Add("-----Select-----");

                using SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT Category_Name FROM Category WHERE Category_Status='Available' ORDER BY Category_Name";

                using SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string? categoryName = reader["Category_Name"] as string;
                    if (!string.IsNullOrEmpty(categoryName))
                    {
                        if (cmbCategory != null) cmbCategory.Items.Add(categoryName);
                        if (cmbCategory2 != null) cmbCategory2.Items.Add(categoryName);
                    }
                }

                if (setDefaultSelection)
                {
                    if (cmbCategory != null) cmbCategory.SelectedIndex = 0;
                    if (cmbCategory2 != null) cmbCategory2.SelectedIndex = 0;
                }
                else
                {
                    if (cmbCategory != null)
                        cmbCategory.SelectedItem = cmbCategory.Items.Contains(currentCategory) ? currentCategory : cmbCategory.Items.Count > 0 ? cmbCategory.Items[0] : null;
                    if (cmbCategory2 != null)
                        cmbCategory2.SelectedItem = cmbCategory2.Items.Contains(currentCategory2) ? currentCategory2 : cmbCategory2.Items.Count > 0 ? cmbCategory2.Items[0] : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT Product_Id, ProductName, Rate, Quantity, Category, Status FROM Product";

                using SqlCommand command = new SqlCommand(query, connection);
                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (dgvProduct != null)
                {
                    dgvProduct.DataSource = table;
                    lblTotal1.Text = dgvProduct.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxAutoFill()
        {
            LoadCategories();
            if (cmbstatus != null) cmbstatus.SelectedIndex = 0;
        }

        public void EmptyBox()
        {
            txtProductName.Clear();
            nudRate.Value = 0;
            nudQuantity.Value = 0;
            if (cmbCategory != null) cmbCategory.SelectedIndex = 0;
            if (cmbstatus != null) cmbstatus.SelectedIndex = 0;
        }

        private void EmptyBox1()
        {
            txtProductName1.Clear();
            nudRate1.Value = 0;
            nudQunatity2.Value = 0;
            ComboBoxAutoFill();
            if (cmbStatus2 != null) cmbStatus2.SelectedIndex = 0;
            if (cmbCategory2 != null) cmbCategory2.SelectedIndex = 0;
            id = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(ProductName, @"^[a-zA-Z0-9\s\-]+$"))
            {
                MessageBox.Show("Product name can only contain letters, numbers, spaces, and dashes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }
            if (nudRate.Value <= 0||nudRate.Value>=100001)
            {
                MessageBox.Show("Please enter a valid rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudRate.Value = 0;
                return;
            }
            if (nudQuantity.Value <= 0||nudQuantity.Value>=101)
            {
                MessageBox.Show("Please enter a valid quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudQuantity.Value = 0;
                return;
            }
            if (cmbCategory == null || cmbCategory.SelectedIndex == 0 || cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbstatus == null || cmbstatus.SelectedIndex == 0 || cmbstatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = @"INSERT INTO Product 
                    (ProductName, Rate, Quantity, Category, Status)
                    VALUES (@Name, @Rate, @Quantity, @Category, @Status)";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                command.Parameters.AddWithValue("@Rate", nudRate.Value);
                command.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                command.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Status", cmbstatus.SelectedItem?.ToString() ?? "");

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
                LoadCategories(); 
                EmptyBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search for products");
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProduct != null && dgvProduct.Rows[e.RowIndex] != null)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                id = row.Cells[0].Value?.ToString() ?? "";

               
                txtProductName1.Text = row.Cells[1].Value?.ToString() ?? "";

                
                object? rateValue = row.Cells[2].Value;
                nudRate1.Value = rateValue != null && decimal.TryParse(rateValue.ToString(), out decimal rate)
                    ? rate
                    : 0;

              
                object? quantityValue = row.Cells[3].Value;
                nudQunatity2.Value = quantityValue != null && decimal.TryParse(quantityValue.ToString(), out decimal qty)
                    ? qty
                    : 0;

                
                string categoryValue = row.Cells[4].Value?.ToString() ?? "";
                if (cmbCategory2 != null && cmbCategory2.Items.Contains(categoryValue))
                    cmbCategory2.SelectedItem = categoryValue;
                else if (cmbCategory2 != null)
                    cmbCategory2.SelectedIndex = 0;

                
                string statusValue = row.Cells[5].Value?.ToString() ?? "";
                if (cmbStatus2 != null && cmbStatus2.Items.Contains(statusValue))
                    cmbStatus2.SelectedItem = statusValue;
                else if (cmbStatus2 != null)
                    cmbStatus2.SelectedIndex = 0;

               
                tcProduct.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a product to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = @"UPDATE Product SET 
                            ProductName = @Name, 
                            Rate = @Rate, 
                            Quantity = @Quantity, 
                            Category = @Category, 
                            Status = @Status 
                         WHERE Product_Id = @Id";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtProductName1.Text.Trim());
                command.Parameters.AddWithValue("@Rate", nudRate1.Value);
                command.Parameters.AddWithValue("@Quantity", nudQunatity2.Value);
                command.Parameters.AddWithValue("@Category", cmbCategory2?.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Status", cmbStatus2?.SelectedItem?.ToString() ?? "");
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
                if (nudQunatity2.Value <= 0 || nudQunatity2.Value >= 101)
                {
                    MessageBox.Show("Please enter a valid quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudQunatity2.Value = 0;
                    return;
                }
                if (nudRate1.Value <= 0 || nudRate1.Value >= 1000001)
                {
                    MessageBox.Show("Please enter a valid rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudRate1.Value = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadProducts();
                LoadCategories(); 
                EmptyBox1();
                tcProduct.SelectedTab = tpManageProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void tpOptions_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a product to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using SqlConnection connection = new SqlConnection(connectionString);
                    string query = "DELETE FROM Product WHERE Product_Id = @Id";

                    using SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProducts();
                    LoadCategories(); 
                    EmptyBox1();
                    tcProduct.SelectedTab = tpManageProduct;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpAddProduct_Click(object sender, EventArgs e)
        {
        }

        private void txtSearchProduct_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim();

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                string query = @"SELECT Product_Id, ProductName, Rate, Quantity, Category, Status 
                         FROM Product
                         WHERE ProductName LIKE @Search";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (dgvProduct != null)
                {
                    dgvProduct.DataSource = table;
                    lblTotal1.Text = dgvProduct.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}