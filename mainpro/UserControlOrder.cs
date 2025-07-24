using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;
namespace WinFormsApp23
{
    public partial class UserControlOrder : UserControl
    {
        private string id = "";
        private readonly string connectionString = "Data Source=ANISH7109\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

        public UserControlOrder()
        {
            InitializeComponent();
            InitializeProductListGrid();

            this.Load += UserControlOrder_Load;
        }

        private void UserControlOrder_Load(object? sender, EventArgs e)
        {
            LoadAvailableProducts();
            if (cmbPaymentstatus != null) cmbPaymentstatus.SelectedIndex = 0;
            if (cmbPaymentStatus1 != null) cmbPaymentStatus1.SelectedIndex = 0;
            EmptyBox();
        }

        private void InitializeProductListGrid()
        {
            if (dgvProductList == null) return;

            dgvProductList.Columns.Clear();

            dgvProductList.Columns.Add("Product_Id", "Product ID");
            dgvProductList.Columns["Product_Id"].Visible = false;

            dgvProductList.Columns.Add("ProductName", "Product Name");
            dgvProductList.Columns.Add("Rate", "Rate");
            dgvProductList.Columns.Add("Quantity", "Quantity");
            dgvProductList.Columns.Add("Total", "Total");

            DataGridViewButtonColumn removeColumn = new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };
            dgvProductList.Columns.Add(removeColumn);
        }

        #region Product Management
        private class ProductItem
        {
            public int Id { get; }
            public string Name { get; }
            public decimal Rate { get; }
            public static decimal nudQuantity { get; }

            public ProductItem(int id, string name, decimal rate)
            {
                Id = id;
                Name = name ?? string.Empty;
                Rate = rate;
            }

            public override string ToString() => Name;
        }

        public void RefreshProduct()
        {
            LoadAvailableProducts();
        }
        private int GetAvailableStock(int productId)
        {
            int stock = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT quantity FROM Product WHERE Product_Id = @Product_Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Product_Id", productId);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int s))
                    {
                        stock = s;
                    }
                }
            }

            return stock;
        }

        private void LoadAvailableProducts()
        {
            try
            {
                if (cmbProduct == null) return;


                cmbProduct.Items.Clear();
                cmbProduct.Items.Add("-----Select-----");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Product_Id, ProductName, Rate FROM Product WHERE Status='Available' ORDER BY ProductName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbProduct.Items.Add(new ProductItem(
                                    Convert.ToInt32(reader["Product_Id"]),
                                    reader["ProductName"]?.ToString() ?? string.Empty,
                                    Convert.ToDecimal(reader["Rate"])
                                ));
                            }
                        }
                    }
                }

                cmbProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct?.SelectedIndex > 0 && cmbProduct.SelectedItem is ProductItem product)
            {
                txtRate.Text = product.Rate.ToString("F2");
                nudQuantity.Value = 1;
            }
            else
            {
                txtRate.Clear();
                nudQuantity.Value = 0;
            }
            UpdateProductTotal();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateProductTotal();
        }

        private void UpdateProductTotal()
        {
            if (txtRate != null && decimal.TryParse(txtRate.Text, out decimal rate) && cmbProduct?.SelectedIndex > 0)
            {
                txtTotal.Text = (rate * nudQuantity.Value).ToString("F2");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (txtCustomerName == null || string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCustomerName.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Customer name should contain only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }
            if (MtbCustomerNumber == null || !MtbCustomerNumber.MaskFull)
            {
                MessageBox.Show("Please enter a valid customer number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbProduct == null || cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudQuantity.Value <= 0||nudQuantity.Value>=101)
            {
                MessageBox.Show("Please enter a valid quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudQuantity.Value = 0;
                return;
            }
           
            
            if (cmbProduct.SelectedItem is not ProductItem product)
            {
                return;
            }
            int availableStock = GetAvailableStock(product.Id);
            int existingQty = 0;
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                if (row.Cells["Product_Id"].Value?.ToString() == product.Id.ToString())
                {
                    existingQty = int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int q) ? q : 0;
                    break;
                }
            }
            int totalRequestedQty = existingQty + (int)nudQuantity.Value;
            if (totalRequestedQty > availableStock)
            {
                MessageBox.Show("Insufficient stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal lineTotal = product.Rate * nudQuantity.Value;

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                if (row.Cells["Product_Id"].Value?.ToString() == product.Id.ToString())
                {
                    if (decimal.TryParse(row.Cells["Quantity"].Value?.ToString(), out decimal currentQuantity) &&
                        decimal.TryParse(row.Cells["Total"].Value?.ToString(), out decimal currentTotal))
                    {
                        row.Cells["Quantity"].Value = (currentQuantity + nudQuantity.Value).ToString();
                        row.Cells["Total"].Value = (currentTotal + lineTotal).ToString("F2");
                        UpdateOrderTotals();
                        AddClear();
                        return;
                    }
                }
            }

            dgvProductList.Rows.Add(
                product.Id,
                product.Name,
                product.Rate.ToString("F2"),
                nudQuantity.Value.ToString(),
                lineTotal.ToString("F2")
            );

            UpdateOrderTotals();
            AddClear();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductList.Columns["Remove"]?.Index)
            {
                dgvProductList.Rows.RemoveAt(e.RowIndex);
                UpdateOrderTotals();
            }
        }

        private void AddClear()
        {
            if (cmbProduct != null) cmbProduct.SelectedIndex = 0;
            txtRate.Clear();
            nudQuantity.Value = 0;
            txtTotal.Clear();
        }

        private void UpdateOrderTotals()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                if (row.Cells["Total"].Value != null &&
                    decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowTotal))
                {
                    total += rowTotal;
                }
            }

            txtTotalAmount.Text = total.ToString("F2");
            txtGrandTotal.Text = (total - nudDiscount.Value).ToString("F2");
            UpdateDueAmount();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT o.Orders_Id, o.Orders_Date, o.Customer_Name, o.Customer_Number, 
                                   o.Total_Amount, o.Paid_Amount, o.Due_Amount, o.Discount, o.Grand_Total, o.Payment_Status
                                   FROM Orders o
                                   ORDER BY o.Orders_Date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (dgvOrders != null)
                        {
                            dgvOrders.Columns.Clear();
                            dgvOrders.DataSource = table;

                            dgvOrders.Columns["Orders_Id"].HeaderText = "Order ID";
                            dgvOrders.Columns["Orders_Date"].HeaderText = "Order Date";
                            dgvOrders.Columns["Customer_Name"].HeaderText = "Customer Name";
                            dgvOrders.Columns["Customer_Number"].HeaderText = "Customer Number";
                            dgvOrders.Columns["Total_Amount"].HeaderText = "Total Amount";
                            dgvOrders.Columns["Paid_Amount"].HeaderText = "Paid Amount";
                            dgvOrders.Columns["Due_Amount"].HeaderText = "Due Amount";
                            dgvOrders.Columns["Discount"].HeaderText = "Discount";
                            dgvOrders.Columns["Grand_Total"].HeaderText = "Grand Total";
                            dgvOrders.Columns["Payment_Status"].HeaderText = "Payment Status";

                            lblTotal.Text = dgvOrders.Rows.Count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrdersProduct(string orders_Id)
        {
            if (string.IsNullOrEmpty(orders_Id))
            {
                MessageBox.Show("Invalid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (dgvProductList == null) return;
                dgvProductList.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT p.Product_Id, p.ProductName, op.Rate, op.Quantity, (op.Rate * op.Quantity) AS Total
                           FROM OrdersProduct op
                           JOIN Product p ON op.Product_Id = p.Product_Id
                           WHERE op.Orders_Id = @Orders_Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Orders_Id", orders_Id);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            bool hasData = false;
                            while (reader.Read())
                            {
                                hasData = true;
                                dgvProductList.Rows.Add(
                                    reader["Product_Id"],
                                    reader["ProductName"],
                                    Convert.ToDecimal(reader["Rate"]).ToString("F2"),
                                    reader["Quantity"],
                                    Convert.ToDecimal(reader["Total"]).ToString("F2")
                                );
                            }

                            if (!hasData)
                            {
                                MessageBox.Show("No products found for this order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                UpdateOrderTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveOrder()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string orderQuery = @"INSERT INTO Orders (Orders_Date, Customer_Name, Customer_Number, 
                                    Total_Amount, Paid_Amount, Due_Amount, Discount, Grand_Total, Payment_Status)
                                    OUTPUT INSERTED.Orders_Id
                                    VALUES (@Orders_Date, @Customer_Name, @Customer_Number, @Total_Amount, 
                                    @Paid_Amount, @Due_Amount, @Discount, @Grand_Total, @Payment_Status)";

                    using (SqlCommand orderCommand = new SqlCommand(orderQuery, connection, transaction))
                    {
                        if (dptDate != null) orderCommand.Parameters.AddWithValue("@Orders_Date", dptDate.Value);
                        else orderCommand.Parameters.AddWithValue("@Orders_Date", DateTime.Now);
                        orderCommand.Parameters.AddWithValue("@Customer_Name", txtCustomerName?.Text.Trim() ?? "");
                        orderCommand.Parameters.AddWithValue("@Customer_Number", MtbCustomerNumber?.Text ?? "");
                        orderCommand.Parameters.AddWithValue("@Total_Amount", decimal.TryParse(txtTotalAmount?.Text, out decimal totalAmount) ? totalAmount : 0);
                        orderCommand.Parameters.AddWithValue("@Paid_Amount", nudPaidAmount?.Value ?? 0);
                        orderCommand.Parameters.AddWithValue("@Due_Amount", decimal.TryParse(txtDueAmount?.Text, out decimal dueAmount) ? dueAmount : 0);
                        orderCommand.Parameters.AddWithValue("@Discount", nudDiscount?.Value ?? 0);
                        orderCommand.Parameters.AddWithValue("@Grand_Total", decimal.TryParse(txtGrandTotal?.Text, out decimal grandTotal) ? grandTotal : 0);
                        orderCommand.Parameters.AddWithValue("@Payment_Status", cmbPaymentstatus?.SelectedItem?.ToString() ?? "Pending");

                        int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                        foreach (DataGridViewRow row in dgvProductList.Rows)
                        {
                            if (row.Cells["Product_Id"].Value == null || row.Cells["Rate"].Value == null || row.Cells["Quantity"].Value == null)
                                continue;

                            string productQuery = @"INSERT INTO OrdersProduct (Orders_Id, Product_Id, Rate, Quantity)
                                         VALUES (@Orders_Id, @Product_Id, @Rate, @Quantity)";

                            using (SqlCommand productCommand = new SqlCommand(productQuery, connection, transaction))
                            {
                                productCommand.Parameters.AddWithValue("@Orders_Id", orderId);
                                productCommand.Parameters.AddWithValue("@Product_Id", row.Cells["Product_Id"].Value != null && int.TryParse(row.Cells["Product_Id"].Value.ToString(), out int productId) ? productId : 0);
                                productCommand.Parameters.AddWithValue("@Rate", decimal.TryParse(row.Cells["Rate"].Value.ToString(), out decimal rate) ? rate : 0);
                                productCommand.Parameters.AddWithValue("@Quantity", decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out decimal quantity) ? quantity : 0);

                                productCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error saving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateOrder()
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Invalid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string orderQuery = @"UPDATE Orders SET 
                                Orders_Date = @Orders_Date, 
                                Customer_Name = @Customer_Name, 
                                Customer_Number = @Customer_Number,
                                Total_Amount = @Total_Amount,
                                Paid_Amount = @Paid_Amount,
                                Due_Amount = @Due_Amount,
                                Discount = @Discount,
                                Grand_Total = @Grand_Total,
                                Payment_Status = @Payment_Status
                                WHERE Orders_Id = @Orders_Id";

                    using (SqlCommand orderCommand = new SqlCommand(orderQuery, connection, transaction))
                    {
                        if (dptDate1 != null) orderCommand.Parameters.AddWithValue("@Orders_Date", dptDate1.Value);
                        else orderCommand.Parameters.AddWithValue("@Orders_Date", DateTime.Now);
                        orderCommand.Parameters.AddWithValue("@Customer_Name", txtCustomerName1?.Text.Trim() ?? "");
                        orderCommand.Parameters.AddWithValue("@Customer_Number", mtbCustomerNumber1?.Text ?? "");
                        orderCommand.Parameters.AddWithValue("@Total_Amount", decimal.TryParse(txtTotalAmount1?.Text, out decimal totalAmount) ? totalAmount : 0);
                        orderCommand.Parameters.AddWithValue("@Paid_Amount", nudPaidAmount1?.Value ?? 0);
                        orderCommand.Parameters.AddWithValue("@Due_Amount", decimal.TryParse(txtDueAmount1?.Text, out decimal dueAmount) ? dueAmount : 0);
                        orderCommand.Parameters.AddWithValue("@Discount", nudDiscount1?.Value ?? 0);
                        orderCommand.Parameters.AddWithValue("@Grand_Total", decimal.TryParse(txtGrandTotal1?.Text, out decimal grandTotal) ? grandTotal : 0);
                        orderCommand.Parameters.AddWithValue("@Payment_Status", cmbPaymentStatus1?.SelectedItem?.ToString() ?? "Pending");
                        orderCommand.Parameters.AddWithValue("@Orders_Id", id);

                        orderCommand.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM OrdersProduct WHERE Orders_Id = @Orders_Id";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@Orders_Id", id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    foreach (DataGridViewRow row in dgvProductList.Rows)
                    {
                        if (row.Cells["Product_Id"].Value == null || row.Cells["Rate"].Value == null || row.Cells["Quantity"].Value == null)
                            continue;

                        string productQuery = @"INSERT INTO OrdersProduct (Orders_Id, Product_Id, Rate, Quantity)
                                     VALUES (@Orders_Id, @Product_Id, @Rate, @Quantity)";

                        using (SqlCommand productCommand = new SqlCommand(productQuery, connection, transaction))
                        {
                            productCommand.Parameters.AddWithValue("@Orders_Id", id);
                            productCommand.Parameters.AddWithValue("@Product_Id", row.Cells["Product_Id"].Value != null && int.TryParse(row.Cells["Product_Id"].Value.ToString(), out int productId) ? productId : 0);
                            productCommand.Parameters.AddWithValue("@Rate", decimal.TryParse(row.Cells["Rate"].Value.ToString(), out decimal rate) ? rate : 0);
                            productCommand.Parameters.AddWithValue("@Quantity", decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out decimal quantity) ? quantity : 0);

                            productCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error updating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoveOrder(string orders_Id)
        {
            if (string.IsNullOrEmpty(orders_Id))
            {
                MessageBox.Show("Invalid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteProductsQuery = "DELETE FROM OrdersProduct WHERE Orders_Id = @Orders_Id";
                    using (SqlCommand deleteProductsCommand = new SqlCommand(deleteProductsQuery, connection, transaction))
                    {
                        deleteProductsCommand.Parameters.AddWithValue("@Orders_Id", orders_Id);
                        deleteProductsCommand.ExecuteNonQuery();
                    }

                    string deleteOrderQuery = "DELETE FROM Orders WHERE Orders_Id = @Orders_Id";
                    using (SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection, transaction))
                    {
                        deleteOrderCommand.Parameters.AddWithValue("@Orders_Id", orders_Id);
                        deleteOrderCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region UI Event Handlers
        private void tpManageOrder_Enter(object sender, EventArgs e)
        {
            txtSearchCustomerName.Clear();
            LoadOrders();
        }

        private void tpAddOrder_Enter(object sender, EventArgs e)
        {
            EmptyBox();
            RefreshProduct(); // Refresh products when entering the Add Order tab
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                tcOrder.SelectedTab = tpManageOrder;
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT o.Orders_Id, o.Orders_Date, o.Customer_Name, o.Customer_Number, 
                                   o.Total_Amount, o.Paid_Amount, o.Due_Amount, o.Discount, o.Grand_Total, o.Payment_Status
                                   FROM Orders o
                                   WHERE o.Customer_Name LIKE @SearchText
                                   ORDER BY o.Orders_Date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", $"%{txtSearchCustomerName.Text}%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (dgvOrders != null)
                        {
                            dgvOrders.Columns.Clear();
                            dgvOrders.DataSource = table;

                            dgvOrders.Columns["Orders_Id"].HeaderText = "Order ID";
                            dgvOrders.Columns["Orders_Date"].HeaderText = "Order Date";
                            dgvOrders.Columns["Customer_Name"].HeaderText = "Customer Name";
                            dgvOrders.Columns["Customer_Number"].HeaderText = "Customer Number";
                            dgvOrders.Columns["Total_Amount"].HeaderText = "Total Amount";
                            dgvOrders.Columns["Paid_Amount"].HeaderText = "Paid Amount";
                            dgvOrders.Columns["Due_Amount"].HeaderText = "Due Amount";
                            dgvOrders.Columns["Discount"].HeaderText = "Discount";
                            dgvOrders.Columns["Grand_Total"].HeaderText = "Grand Total";
                            dgvOrders.Columns["Payment_Status"].HeaderText = "Payment Status";

                            lblTotal.Text = dgvOrders.Rows.Count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex] != null && dgvOrders.Columns.Count > 0)
                {
                    DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                    id = row.Cells["Orders_Id"].Value?.ToString() ?? "";
                    dptDate1.Value = row.Cells["Orders_Date"].Value != null ? Convert.ToDateTime(row.Cells["Orders_Date"].Value) : DateTime.Now;
                    txtCustomerName1.Text = row.Cells["Customer_Name"].Value?.ToString() ?? "";
                    mtbCustomerNumber1.Text = row.Cells["Customer_Number"].Value?.ToString() ?? "";
                    txtTotalAmount1.Text = row.Cells["Total_Amount"].Value != null ? Convert.ToDecimal(row.Cells["Total_Amount"].Value).ToString("F2") : "0.00";
                    nudPaidAmount1.Value = row.Cells["Paid_Amount"].Value != null ? Convert.ToDecimal(row.Cells["Paid_Amount"].Value) : 0;
                    txtDueAmount1.Text = row.Cells["Due_Amount"].Value != null ? Convert.ToDecimal(row.Cells["Due_Amount"].Value).ToString("F2") : "0.00";
                    nudDiscount1.Value = row.Cells["Discount"].Value != null ? Convert.ToDecimal(row.Cells["Discount"].Value) : 0;
                    txtGrandTotal1.Text = row.Cells["Grand_Total"].Value != null ? Convert.ToDecimal(row.Cells["Grand_Total"].Value).ToString("F2") : "0.00";
                    cmbPaymentStatus1.SelectedItem = row.Cells["Payment_Status"].Value?.ToString() ?? "Pending";

                    LoadOrdersProduct(id);
                    tcOrder.SelectedTab = tpOptions;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing order click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd1, "Add product to order");
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(picSearch, "Search customer orders");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder())
                return;

            SaveOrder();
            EmptyBox();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select an order to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                RemoveOrder(id);
                LoadOrders();
                EmptyBox1();
                tcOrder.SelectedTab = tpManageOrder;
            }
        }

        private bool ValidateOrder()
        {
            TextBox customerNameControl = tcOrder.SelectedTab == tpOptions ? txtCustomerName1 : txtCustomerName;
            MaskedTextBox customerNumberControl = tcOrder.SelectedTab == tpOptions ? mtbCustomerNumber1 : MtbCustomerNumber;
            NumericUpDown paidAmountControl = tcOrder.SelectedTab == tpOptions ? nudPaidAmount1 : nudPaidAmount;
            ComboBox paymentStatusControl = tcOrder.SelectedTab == tpOptions ? cmbPaymentStatus1 : cmbPaymentstatus;

            if (string.IsNullOrWhiteSpace(customerNameControl.Text))
            {
                MessageBox.Show("Please enter customer name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!customerNumberControl.MaskCompleted)
            {
                MessageBox.Show("Please enter valid customer number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (dgvProductList.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product to the order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (paidAmountControl.Value == 0)
            {
                MessageBox.Show("Please enter paid amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (paymentStatusControl.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void EmptyBox()
        {
            dptDate.Value = DateTime.Now;
            txtCustomerName.Clear();
            MtbCustomerNumber.Clear();
            AddClear();
            if (dgvProductList != null) dgvProductList.Rows.Clear();
            txtTotalAmount.Text = "0.00";
            nudPaidAmount.Value = 0;
            txtDueAmount.Text = "0.00";
            nudDiscount.Value = 0;
            txtGrandTotal.Text = "0.00";
            if (cmbPaymentstatus != null) cmbPaymentstatus.SelectedIndex = 0;
        }

        private void EmptyBox1()
        {
            dptDate1.Value = DateTime.Now;
            txtCustomerName1.Clear();
            mtbCustomerNumber1.Clear();
            AddClear();
            if (dgvProductList != null) dgvProductList.Rows.Clear();
            txtTotalAmount1.Text = "0.00";
            nudPaidAmount1.Value = 0;
            txtDueAmount1.Text = "0.00";
            nudDiscount1.Value = 0;
            txtGrandTotal1.Text = "0.00";
            if (cmbPaymentStatus1 != null) cmbPaymentStatus1.SelectedIndex = 0;
            id = "";
        }

        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateDueAmount();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount.Text, out decimal total))
            {
                txtGrandTotal.Text = (total - nudDiscount.Value).ToString("F2");
                UpdateDueAmount();
            }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount.Text, out decimal total))
            {
                txtGrandTotal.Text = (total - nudDiscount.Value).ToString("F2");
                UpdateDueAmount();
            }
        }
        #endregion
        private void nudPaidAmount1_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount1.Text, out decimal total))
            {
                txtDueAmount1.Text = (total - nudPaidAmount1.Value).ToString("F2");
            }
        }

        private void nudDiscount1_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount1.Text, out decimal total))
            {
                txtGrandTotal1.Text = (total - nudDiscount1.Value).ToString("F2");
                txtDueAmount1.Text = (decimal.Parse(txtGrandTotal1.Text) - nudPaidAmount1.Value).ToString("F2");
            }
        }

        private void txtTotalAmount1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalAmount1.Text, out decimal total))
            {
                txtGrandTotal1.Text = (total - nudDiscount1.Value).ToString("F2");
                txtDueAmount1.Text = (decimal.Parse(txtGrandTotal1.Text) - nudPaidAmount1.Value).ToString("F2");
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            nudQuantity_ValueChanged(sender, e);
        }

        private void UpdateDueAmount()
        {
            if (decimal.TryParse(txtGrandTotal.Text, out decimal grandTotal))
            {
                txtDueAmount.Text = (grandTotal - nudPaidAmount.Value).ToString("F2");
            }
        }

        private void btnchange_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select an order to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateOrder())
                return;

            UpdateOrder();
            EmptyBox1();
        }
        RichTextBox richTextBox1 = new RichTextBox();

        private void Receipt()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Order Receipt\n");
            richTextBox1.AppendText("========================================\n");
            richTextBox1.AppendText($"Order Date: {dptDate.Value.ToShortDateString()}\n");
            richTextBox1.AppendText($"Customer Name: {txtCustomerName.Text}\n");
            richTextBox1.AppendText($"Customer Number: {MtbCustomerNumber.Text}\n");
            richTextBox1.AppendText("Products:\n");

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                if (row.Cells["ProductName"].Value != null && row.Cells["Rate"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    richTextBox1.AppendText($"{row.Cells["ProductName"].Value} - Rate: {row.Cells["Rate"].Value}, Quantity: {row.Cells["Quantity"].Value}, Total: {row.Cells["Total"].Value}\n");
                }
            }

            richTextBox1.AppendText("========================================\n");
            richTextBox1.AppendText($"Total Amount: {txtTotalAmount.Text}\n");
            richTextBox1.AppendText($"Paid Amount: {nudPaidAmount.Value}\n");
            richTextBox1.AppendText($"Due Amount: {txtDueAmount.Text}\n");
            richTextBox1.AppendText($"Discount: {nudDiscount.Value}\n");
            richTextBox1.AppendText($"Grand Total: {txtGrandTotal.Text}\n");
            richTextBox1.AppendText($"Payment Status: {cmbPaymentstatus.SelectedItem}\n");
            richTextBox1.AppendText("========================================\n");
            richTextBox1.AppendText("Thank you for your order!\n");
        }


        private void txtCustomerName1_TextChanged(object sender, EventArgs e)
        {
        }


        private void tpAddOrder_Click(object sender, EventArgs e)
        {
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt();
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.PrintPage += printDocument_PrintPage; 
            printPreviewDialog.Document = printDocument!;
            printPreviewDialog.Width = 800;
            printPreviewDialog.Height = 600;
            printPreviewDialog.ShowDialog();
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics!.DrawString(
   richTextBox1.Text,
   new Font("Arial", 10),
   Brushes.Black,
   new RectangleF(50, 50, e.MarginBounds.Width, e.MarginBounds.Height)
);
        }
    }
}


#endregion