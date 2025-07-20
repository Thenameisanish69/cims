namespace WinFormsApp23
{
    partial class UserControlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrder));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tcOrder = new TabControl();
            tpAddOrder = new TabPage();
            btnAdd1 = new Button();
            label16 = new Label();
            label15 = new Label();
            txtGrandTotal = new TextBox();
            btnsave = new Button();
            nudDiscount = new NumericUpDown();
            label14 = new Label();
            cmbPaymentstatus = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            txtDueAmount = new TextBox();
            label12 = new Label();
            nudPaidAmount = new NumericUpDown();
            label10 = new Label();
            txtTotalAmount = new TextBox();
            label9 = new Label();
            dgvProductList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            cmbProduct = new ComboBox();
            txtRate = new TextBox();
            btnAdd = new Button();
            txtTotal = new TextBox();
            label8 = new Label();
            nudQuantity = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            MtbCustomerNumber = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            dptDate = new DateTimePicker();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tpManageOrder = new TabPage();
            txtSearchCustomerName = new TextBox();
            lblTotal = new Label();
            label3455 = new Label();
            dgvOrders = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            picSearch = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            tpOptions = new TabPage();
            btnRemove = new Button();
            btnchange = new Button();
            txtGrandTotal1 = new TextBox();
            mtbCustomerNumber1 = new MaskedTextBox();
            nudDiscount1 = new NumericUpDown();
            label22 = new Label();
            label23 = new Label();
            label21 = new Label();
            cmbPaymentStatus1 = new ComboBox();
            txtCustomerName1 = new TextBox();
            label24 = new Label();
            dptDate1 = new DateTimePicker();
            label25 = new Label();
            label20 = new Label();
            txtDueAmount1 = new TextBox();
            label19 = new Label();
            label26 = new Label();
            label28 = new Label();
            nudPaidAmount1 = new NumericUpDown();
            txtTotalAmount1 = new TextBox();
            label27 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            printDialog1 = new PrintDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            tcOrder.SuspendLayout();
            tpAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPaidAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            tpManageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            tpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPaidAmount1).BeginInit();
            SuspendLayout();
            // 
            // tcOrder
            // 
            tcOrder.Alignment = TabAlignment.Bottom;
            tcOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcOrder.Controls.Add(tpAddOrder);
            tcOrder.Controls.Add(tpManageOrder);
            tcOrder.Controls.Add(tpOptions);
            tcOrder.Location = new Point(14, 13);
            tcOrder.Name = "tcOrder";
            tcOrder.SelectedIndex = 0;
            tcOrder.Size = new Size(1284, 804);
            tcOrder.TabIndex = 0;
            // 
            // tpAddOrder
            // 
            tpAddOrder.Controls.Add(btnAdd1);
            tpAddOrder.Controls.Add(label16);
            tpAddOrder.Controls.Add(label15);
            tpAddOrder.Controls.Add(txtGrandTotal);
            tpAddOrder.Controls.Add(btnsave);
            tpAddOrder.Controls.Add(nudDiscount);
            tpAddOrder.Controls.Add(label14);
            tpAddOrder.Controls.Add(cmbPaymentstatus);
            tpAddOrder.Controls.Add(label13);
            tpAddOrder.Controls.Add(label11);
            tpAddOrder.Controls.Add(txtDueAmount);
            tpAddOrder.Controls.Add(label12);
            tpAddOrder.Controls.Add(nudPaidAmount);
            tpAddOrder.Controls.Add(label10);
            tpAddOrder.Controls.Add(txtTotalAmount);
            tpAddOrder.Controls.Add(label9);
            tpAddOrder.Controls.Add(dgvProductList);
            tpAddOrder.Controls.Add(cmbProduct);
            tpAddOrder.Controls.Add(txtRate);
            tpAddOrder.Controls.Add(btnAdd);
            tpAddOrder.Controls.Add(txtTotal);
            tpAddOrder.Controls.Add(label8);
            tpAddOrder.Controls.Add(nudQuantity);
            tpAddOrder.Controls.Add(label7);
            tpAddOrder.Controls.Add(label6);
            tpAddOrder.Controls.Add(label5);
            tpAddOrder.Controls.Add(MtbCustomerNumber);
            tpAddOrder.Controls.Add(label4);
            tpAddOrder.Controls.Add(label3);
            tpAddOrder.Controls.Add(dptDate);
            tpAddOrder.Controls.Add(txtCustomerName);
            tpAddOrder.Controls.Add(label2);
            tpAddOrder.Controls.Add(label1);
            tpAddOrder.Location = new Point(4, 4);
            tpAddOrder.Name = "tpAddOrder";
            tpAddOrder.Padding = new Padding(3);
            tpAddOrder.Size = new Size(1276, 766);
            tpAddOrder.TabIndex = 0;
            tpAddOrder.Text = "Add order";
            tpAddOrder.UseVisualStyleBackColor = true;
            tpAddOrder.Click += tpAddOrder_Click;
            tpAddOrder.Enter += tpAddOrder_Enter;
            // 
            // btnAdd1
            // 
            btnAdd1.Anchor = AnchorStyles.None;
            btnAdd1.BackColor = Color.Transparent;
            btnAdd1.FlatAppearance.BorderSize = 0;
            btnAdd1.ForeColor = SystemColors.ControlText;
            btnAdd1.Image = (Image)resources.GetObject("btnAdd1.Image");
            btnAdd1.Location = new Point(1095, 161);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(44, 54);
            btnAdd1.TabIndex = 42;
            btnAdd1.UseVisualStyleBackColor = false;
            btnAdd1.Click += btnAdd1_Click;
            btnAdd1.MouseHover += btnAdd1_MouseHover;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlText;
            label16.Location = new Point(6, 53);
            label16.Name = "label16";
            label16.Size = new Size(55, 25);
            label16.TabIndex = 41;
            label16.Text = "Date:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(362, 53);
            label15.Name = "label15";
            label15.Size = new Size(151, 25);
            label15.TabIndex = 40;
            label15.Text = "Customer Name:";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Anchor = AnchorStyles.None;
            txtGrandTotal.BorderStyle = BorderStyle.FixedSingle;
            txtGrandTotal.Location = new Point(54, 622);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(291, 31);
            txtGrandTotal.TabIndex = 39;
            txtGrandTotal.Text = "0";
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(22, 67, 108);
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(33, 671);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(157, 54);
            btnsave.TabIndex = 37;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // nudDiscount
            // 
            nudDiscount.Anchor = AnchorStyles.None;
            nudDiscount.Location = new Point(775, 541);
            nudDiscount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(225, 31);
            nudDiscount.TabIndex = 36;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(784, 504);
            label14.Name = "label14";
            label14.Size = new Size(90, 25);
            label14.TabIndex = 0;
            label14.Text = "Discount:";
            // 
            // cmbPaymentstatus
            // 
            cmbPaymentstatus.Anchor = AnchorStyles.None;
            cmbPaymentstatus.FormattingEnabled = true;
            cmbPaymentstatus.Items.AddRange(new object[] { "------SELECT-------", "Paid", "Not Paid" });
            cmbPaymentstatus.Location = new Point(775, 627);
            cmbPaymentstatus.Name = "cmbPaymentstatus";
            cmbPaymentstatus.Size = new Size(230, 33);
            cmbPaymentstatus.TabIndex = 34;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(775, 599);
            label13.Name = "label13";
            label13.Size = new Size(143, 25);
            label13.TabIndex = 0;
            label13.Text = "Payment status:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(54, 590);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 0;
            label11.Text = "Grand Total:";
            // 
            // txtDueAmount
            // 
            txtDueAmount.Anchor = AnchorStyles.None;
            txtDueAmount.BorderStyle = BorderStyle.FixedSingle;
            txtDueAmount.Location = new Point(54, 541);
            txtDueAmount.Name = "txtDueAmount";
            txtDueAmount.Size = new Size(291, 31);
            txtDueAmount.TabIndex = 30;
            txtDueAmount.Text = "0";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(54, 504);
            label12.Name = "label12";
            label12.Size = new Size(123, 25);
            label12.TabIndex = 0;
            label12.Text = "Due Amount:";
            // 
            // nudPaidAmount
            // 
            nudPaidAmount.Anchor = AnchorStyles.None;
            nudPaidAmount.Location = new Point(784, 455);
            nudPaidAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPaidAmount.Name = "nudPaidAmount";
            nudPaidAmount.Size = new Size(225, 31);
            nudPaidAmount.TabIndex = 28;
            nudPaidAmount.ValueChanged += nudPaidAmount_ValueChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(798, 412);
            label10.Name = "label10";
            label10.Size = new Size(124, 25);
            label10.TabIndex = 0;
            label10.Text = "Paid Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.None;
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Location = new Point(54, 455);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(291, 31);
            txtTotalAmount.TabIndex = 26;
            txtTotalAmount.Text = "0";
            txtTotalAmount.TextChanged += txtTotalAmount_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(33, 412);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 0;
            label9.Text = "Total Amount:";
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AllowUserToResizeColumns = false;
            dgvProductList.AllowUserToResizeRows = false;
            dgvProductList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.BackgroundColor = Color.White;
            dgvProductList.BorderStyle = BorderStyle.Fixed3D;
            dgvProductList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductList.ColumnHeadersHeight = 34;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 151, 196);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductList.EnableHeadersVisualStyles = false;
            dgvProductList.Location = new Point(3, 257);
            dgvProductList.MultiSelect = false;
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersVisible = false;
            dgvProductList.RowHeadersWidth = 62;
            dgvProductList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.ShowCellErrors = false;
            dgvProductList.ShowCellToolTips = false;
            dgvProductList.ShowEditingIcon = false;
            dgvProductList.ShowRowErrors = false;
            dgvProductList.Size = new Size(1242, 152);
            dgvProductList.TabIndex = 24;
            dgvProductList.CellClick += dgvProductList_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Rate";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 40F;
            Column5.HeaderText = "Action";
            Column5.Image = (Image)resources.GetObject("Column5.Image");
            Column5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // cmbProduct
            // 
            cmbProduct.Anchor = AnchorStyles.None;
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FlatStyle = FlatStyle.Flat;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(33, 172);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(341, 33);
            cmbProduct.TabIndex = 23;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // txtRate
            // 
            txtRate.Anchor = AnchorStyles.None;
            txtRate.BorderStyle = BorderStyle.FixedSingle;
            txtRate.Location = new Point(584, 174);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(163, 31);
            txtRate.TabIndex = 22;
            txtRate.TextChanged += txtRate_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(946, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 30);
            btnAdd.TabIndex = 0;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.None;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(992, 173);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(80, 31);
            txtTotal.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(992, 132);
            label8.Name = "label8";
            label8.Size = new Size(56, 25);
            label8.TabIndex = 0;
            label8.Text = "Total:";
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Location = new Point(798, 174);
            nudQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 31);
            nudQuantity.TabIndex = 18;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(817, 132);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 0;
            label7.Text = "Quantity:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(614, 132);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 0;
            label6.Text = "Rate:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(33, 132);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 0;
            label5.Text = "Product:";
            // 
            // MtbCustomerNumber
            // 
            MtbCustomerNumber.Anchor = AnchorStyles.None;
            MtbCustomerNumber.BorderStyle = BorderStyle.FixedSingle;
            MtbCustomerNumber.Location = new Point(1113, 54);
            MtbCustomerNumber.Mask = "0000-000000";
            MtbCustomerNumber.Name = "MtbCustomerNumber";
            MtbCustomerNumber.Size = new Size(163, 31);
            MtbCustomerNumber.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(946, 54);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 0;
            label4.Text = "Customer Number:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(563, -53);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 0;
            label3.Text = "Customer Name:";
            // 
            // dptDate
            // 
            dptDate.Anchor = AnchorStyles.None;
            dptDate.Format = DateTimePickerFormat.Short;
            dptDate.Location = new Point(65, 48);
            dptDate.Name = "dptDate";
            dptDate.Size = new Size(291, 31);
            dptDate.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.None;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Location = new Point(519, 51);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(416, 31);
            txtCustomerName.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(138, -53);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 67, 108);
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 6;
            label1.Text = "..../Add Order";
            // 
            // tpManageOrder
            // 
            tpManageOrder.Controls.Add(txtSearchCustomerName);
            tpManageOrder.Controls.Add(lblTotal);
            tpManageOrder.Controls.Add(label3455);
            tpManageOrder.Controls.Add(dgvOrders);
            tpManageOrder.Controls.Add(picSearch);
            tpManageOrder.Controls.Add(label17);
            tpManageOrder.Controls.Add(label18);
            tpManageOrder.Location = new Point(4, 4);
            tpManageOrder.Name = "tpManageOrder";
            tpManageOrder.Padding = new Padding(3);
            tpManageOrder.Size = new Size(1276, 766);
            tpManageOrder.TabIndex = 1;
            tpManageOrder.Text = "Manage Order";
            tpManageOrder.UseVisualStyleBackColor = true;
            tpManageOrder.Enter += tpManageOrder_Enter;
            // 
            // txtSearchCustomerName
            // 
            txtSearchCustomerName.Anchor = AnchorStyles.None;
            txtSearchCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCustomerName.Location = new Point(259, 166);
            txtSearchCustomerName.Name = "txtSearchCustomerName";
            txtSearchCustomerName.Size = new Size(291, 31);
            txtSearchCustomerName.TabIndex = 12;
            txtSearchCustomerName.TextChanged += txtSearchCustomerName_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.Location = new Point(129, 608);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(30, 25);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "{?}";
            // 
            // label3455
            // 
            label3455.Anchor = AnchorStyles.None;
            label3455.AutoSize = true;
            label3455.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3455.ForeColor = SystemColors.ControlText;
            label3455.Location = new Point(79, 608);
            label3455.Name = "label3455";
            label3455.Size = new Size(56, 25);
            label3455.TabIndex = 15;
            label3455.Text = "Total:";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.Fixed3D;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.ColumnHeadersHeight = 50;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(57, 151, 196);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.Location = new Point(46, 255);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.ShowCellErrors = false;
            dgvOrders.ShowCellToolTips = false;
            dgvOrders.ShowEditingIcon = false;
            dgvOrders.ShowRowErrors = false;
            dgvOrders.Size = new Size(1004, 284);
            dgvOrders.TabIndex = 14;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Orders_id";
            Column6.HeaderText = "OrderId";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Orders_Date";
            Column7.HeaderText = "Date";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Customer_Name";
            Column8.HeaderText = "Customer Name";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Customer_Number";
            Column9.HeaderText = "Customer Number";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Total_Amount";
            Column10.HeaderText = "Total Amount";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "Paid_Amount";
            Column11.HeaderText = "Paid Amount";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "Due_Amount";
            Column12.HeaderText = "Due Amount";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.DataPropertyName = "Discount";
            Column13.HeaderText = "Discount";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.DataPropertyName = "Grand_Total";
            Column14.HeaderText = "Grand Total";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.DataPropertyName = "Payment_Status";
            Column15.HeaderText = "status";
            Column15.MinimumWidth = 8;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // picSearch
            // 
            picSearch.Anchor = AnchorStyles.None;
            picSearch.BorderStyle = BorderStyle.FixedSingle;
            picSearch.Cursor = Cursors.Hand;
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(547, 166);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(34, 31);
            picSearch.SizeMode = PictureBoxSizeMode.Zoom;
            picSearch.TabIndex = 13;
            picSearch.TabStop = false;
            picSearch.MouseHover += picSearch_MouseHover;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(259, 106);
            label17.Name = "label17";
            label17.Size = new Size(151, 25);
            label17.TabIndex = 11;
            label17.Text = "Customer Name:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(22, 67, 108);
            label18.Location = new Point(6, 3);
            label18.Name = "label18";
            label18.Size = new Size(217, 32);
            label18.TabIndex = 10;
            label18.Text = "..../Manage Orders";
            // 
            // tpOptions
            // 
            tpOptions.Controls.Add(btnRemove);
            tpOptions.Controls.Add(btnchange);
            tpOptions.Controls.Add(txtGrandTotal1);
            tpOptions.Controls.Add(mtbCustomerNumber1);
            tpOptions.Controls.Add(nudDiscount1);
            tpOptions.Controls.Add(label22);
            tpOptions.Controls.Add(label23);
            tpOptions.Controls.Add(label21);
            tpOptions.Controls.Add(cmbPaymentStatus1);
            tpOptions.Controls.Add(txtCustomerName1);
            tpOptions.Controls.Add(label24);
            tpOptions.Controls.Add(dptDate1);
            tpOptions.Controls.Add(label25);
            tpOptions.Controls.Add(label20);
            tpOptions.Controls.Add(txtDueAmount1);
            tpOptions.Controls.Add(label19);
            tpOptions.Controls.Add(label26);
            tpOptions.Controls.Add(label28);
            tpOptions.Controls.Add(nudPaidAmount1);
            tpOptions.Controls.Add(txtTotalAmount1);
            tpOptions.Controls.Add(label27);
            tpOptions.Location = new Point(4, 4);
            tpOptions.Name = "tpOptions";
            tpOptions.Padding = new Padding(3);
            tpOptions.Size = new Size(1276, 766);
            tpOptions.TabIndex = 2;
            tpOptions.Text = "Options";
            tpOptions.UseVisualStyleBackColor = true;
            tpOptions.Enter += tpOptions_Enter;
            tpOptions.Leave += tpOptions_Leave;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.BackColor = Color.FromArgb(57, 151, 196);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(264, 572);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 63);
            btnRemove.TabIndex = 53;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnchange
            // 
            btnchange.Anchor = AnchorStyles.None;
            btnchange.BackColor = Color.FromArgb(22, 67, 108);
            btnchange.FlatStyle = FlatStyle.Flat;
            btnchange.ForeColor = Color.White;
            btnchange.Location = new Point(71, 572);
            btnchange.Name = "btnchange";
            btnchange.Size = new Size(128, 63);
            btnchange.TabIndex = 52;
            btnchange.Text = "change";
            btnchange.UseVisualStyleBackColor = false;
            btnchange.Click += btnchange_Click_1;
            // 
            // txtGrandTotal1
            // 
            txtGrandTotal1.Anchor = AnchorStyles.None;
            txtGrandTotal1.BorderStyle = BorderStyle.FixedSingle;
            txtGrandTotal1.Location = new Point(52, 498);
            txtGrandTotal1.Name = "txtGrandTotal1";
            txtGrandTotal1.Size = new Size(291, 31);
            txtGrandTotal1.TabIndex = 51;
            txtGrandTotal1.Text = "0";
            // 
            // mtbCustomerNumber1
            // 
            mtbCustomerNumber1.Anchor = AnchorStyles.None;
            mtbCustomerNumber1.BorderStyle = BorderStyle.FixedSingle;
            mtbCustomerNumber1.Location = new Point(52, 228);
            mtbCustomerNumber1.Mask = "0000-000000";
            mtbCustomerNumber1.Name = "mtbCustomerNumber1";
            mtbCustomerNumber1.Size = new Size(191, 31);
            mtbCustomerNumber1.TabIndex = 13;
            // 
            // nudDiscount1
            // 
            nudDiscount1.Anchor = AnchorStyles.None;
            nudDiscount1.Location = new Point(637, 426);
            nudDiscount1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDiscount1.Name = "nudDiscount1";
            nudDiscount1.Size = new Size(225, 31);
            nudDiscount1.TabIndex = 50;
            nudDiscount1.ValueChanged += nudDiscount1_ValueChanged;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(52, 200);
            label22.Name = "label22";
            label22.Size = new Size(172, 25);
            label22.TabIndex = 0;
            label22.Text = "Customer Number:";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(685, 383);
            label23.Name = "label23";
            label23.Size = new Size(90, 25);
            label23.TabIndex = 0;
            label23.Text = "Discount:";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(382, 124);
            label21.Name = "label21";
            label21.Size = new Size(151, 25);
            label21.TabIndex = 0;
            label21.Text = "Customer Name:";
            // 
            // cmbPaymentStatus1
            // 
            cmbPaymentStatus1.Anchor = AnchorStyles.None;
            cmbPaymentStatus1.FormattingEnabled = true;
            cmbPaymentStatus1.Items.AddRange(new object[] { "", "Paid", "Not Paid" });
            cmbPaymentStatus1.Location = new Point(632, 499);
            cmbPaymentStatus1.Name = "cmbPaymentStatus1";
            cmbPaymentStatus1.Size = new Size(230, 33);
            cmbPaymentStatus1.TabIndex = 49;
            // 
            // txtCustomerName1
            // 
            txtCustomerName1.Anchor = AnchorStyles.None;
            txtCustomerName1.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName1.Location = new Point(370, 152);
            txtCustomerName1.Name = "txtCustomerName1";
            txtCustomerName1.Size = new Size(416, 31);
            txtCustomerName1.TabIndex = 41;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.None;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(669, 471);
            label24.Name = "label24";
            label24.Size = new Size(143, 25);
            label24.TabIndex = 0;
            label24.Text = "Payment status:";
            // 
            // dptDate1
            // 
            dptDate1.Anchor = AnchorStyles.None;
            dptDate1.Format = DateTimePickerFormat.Short;
            dptDate1.Location = new Point(43, 152);
            dptDate1.Name = "dptDate1";
            dptDate1.Size = new Size(291, 31);
            dptDate1.TabIndex = 10;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.None;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ControlText;
            label25.Location = new Point(69, 455);
            label25.Name = "label25";
            label25.Size = new Size(112, 25);
            label25.TabIndex = 0;
            label25.Text = "Grand Total:";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(52, 124);
            label20.Name = "label20";
            label20.Size = new Size(55, 25);
            label20.TabIndex = 0;
            label20.Text = "Date:";
            // 
            // txtDueAmount1
            // 
            txtDueAmount1.Anchor = AnchorStyles.None;
            txtDueAmount1.BorderStyle = BorderStyle.FixedSingle;
            txtDueAmount1.Location = new Point(52, 411);
            txtDueAmount1.Name = "txtDueAmount1";
            txtDueAmount1.Size = new Size(291, 31);
            txtDueAmount1.TabIndex = 48;
            txtDueAmount1.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(22, 67, 108);
            label19.Location = new Point(6, 3);
            label19.Name = "label19";
            label19.Size = new Size(133, 32);
            label19.TabIndex = 7;
            label19.Text = "..../Options";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(76, 365);
            label26.Name = "label26";
            label26.Size = new Size(123, 25);
            label26.TabIndex = 0;
            label26.Text = "Due Amount:";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.None;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.ControlText;
            label28.Location = new Point(71, 285);
            label28.Name = "label28";
            label28.Size = new Size(129, 25);
            label28.TabIndex = 0;
            label28.Text = "Total Amount:";
            // 
            // nudPaidAmount1
            // 
            nudPaidAmount1.Anchor = AnchorStyles.None;
            nudPaidAmount1.Location = new Point(637, 331);
            nudPaidAmount1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPaidAmount1.Name = "nudPaidAmount1";
            nudPaidAmount1.Size = new Size(225, 31);
            nudPaidAmount1.TabIndex = 47;
            nudPaidAmount1.ValueChanged += nudPaidAmount1_ValueChanged;
            // 
            // txtTotalAmount1
            // 
            txtTotalAmount1.Anchor = AnchorStyles.None;
            txtTotalAmount1.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount1.Location = new Point(52, 331);
            txtTotalAmount1.Name = "txtTotalAmount1";
            txtTotalAmount1.Size = new Size(291, 31);
            txtTotalAmount1.TabIndex = 46;
            txtTotalAmount1.Text = "0";
            txtTotalAmount1.TextChanged += txtTotalAmount1_TextChanged;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.ControlText;
            label27.Location = new Point(651, 285);
            label27.Name = "label27";
            label27.Size = new Size(124, 25);
            label27.TabIndex = 0;
            label27.Text = "Paid Amount:";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = btnsave;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = btnchange;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.TargetControl = btnRemove;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog1";
            printPreviewDialog.Visible = false;
            // 
            // UserControlOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcOrder);
            Name = "UserControlOrder";
            Size = new Size(1301, 820);
            tcOrder.ResumeLayout(false);
            tpAddOrder.ResumeLayout(false);
            tpAddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPaidAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            tpManageOrder.ResumeLayout(false);
            tpManageOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            tpOptions.ResumeLayout(false);
            tpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPaidAmount1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcOrder;
        private TabPage tpAddOrder;
        private TabPage tpManageOrder;
        private TabPage tpOptions;
        private DateTimePicker dptDate;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaskedTextBox MtbCustomerNumber;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTotal;
        private Label label8;
        private NumericUpDown nudQuantity;
        private Button btnAdd;
        private TextBox txtRate;
        private ComboBox cmbProduct;
        private DataGridView dgvProductList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private Label label10;
        private TextBox txtTotalAmount;
        private Label label9;
        private Label label11;
        private TextBox txtDueAmount;
        private Label label12;
        private NumericUpDown nudPaidAmount;
        private Label label13;
        private NumericUpDown nudDiscount;
        private Label label14;
        private ComboBox cmbPaymentstatus;
        private Button btnsave;
        private Button btnReceipt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private ToolTip toolTip1;
        private TextBox txtGrandTotal;
        private Label label16;
        private Label label15;
        private Button btnAdd1;
        private Label lblTotal;
        private Label label3455;
        private DataGridView dgvOrders;
        private TextBox txtSearchCustomerName;
        private PictureBox picSearch;
        private Label label17;
        private Label label18;
        private ToolTip toolTip2;
        private Label label19;
        private Label label21;
        private TextBox txtCustomerName1;
        private DateTimePicker dptDate1;
        private Label label20;
        private TextBox txtGrandTotal1;
        private MaskedTextBox mtbCustomerNumber1;
        private NumericUpDown nudDiscount1;
        private Label label22;
        private Label label23;
        private ComboBox cmbPaymentStatus1;
        private Label label24;
        private Label label25;
        private TextBox txtDueAmount1;
        private Label label26;
        private Label label28;
        private NumericUpDown nudPaidAmount1;
        private TextBox txtTotalAmount1;
        private Label label27;
        private Button btnRemove;
        private Button btnchange;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
    }
}
