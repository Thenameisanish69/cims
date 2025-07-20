namespace WinFormsApp23
{
    partial class userControlBrand1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlBrand1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tcProduct = new TabControl();
            tpAddProduct = new TabPage();
            button1 = new Button();
            nudQuantity = new NumericUpDown();
            cmbstatus = new ComboBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            nudRate = new NumericUpDown();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tpManageProduct = new TabPage();
            picSearch = new PictureBox();
            txtSearchProduct = new TextBox();
            lblTotal1 = new Label();
            label9 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tpOptions = new TabPage();
            nudQunatity2 = new NumericUpDown();
            label15 = new Label();
            btnRemove = new Button();
            btnChange = new Button();
            cmbStatus2 = new ComboBox();
            label10 = new Label();
            cmbCategory2 = new ComboBox();
            label11 = new Label();
            nudRate1 = new NumericUpDown();
            label12 = new Label();
            txtProductName1 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            toolTip1 = new ToolTip(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            panel2 = new Panel();
            tcProduct.SuspendLayout();
            tpAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRate).BeginInit();
            tpManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            tpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQunatity2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRate1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tcProduct
            // 
            tcProduct.Alignment = TabAlignment.Bottom;
            tcProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcProduct.Controls.Add(tpAddProduct);
            tcProduct.Controls.Add(tpManageProduct);
            tcProduct.Controls.Add(tpOptions);
            tcProduct.Location = new Point(0, 3);
            tcProduct.Name = "tcProduct";
            tcProduct.SelectedIndex = 0;
            tcProduct.Size = new Size(1301, 817);
            tcProduct.TabIndex = 0;
            // 
            // tpAddProduct
            // 
            tpAddProduct.Controls.Add(panel1);
            tpAddProduct.Controls.Add(button1);
            tpAddProduct.Controls.Add(label1);
            tpAddProduct.Location = new Point(4, 4);
            tpAddProduct.Name = "tpAddProduct";
            tpAddProduct.Padding = new Padding(3);
            tpAddProduct.Size = new Size(1293, 779);
            tpAddProduct.TabIndex = 0;
            tpAddProduct.Text = "Add Product";
            tpAddProduct.UseVisualStyleBackColor = true;
            tpAddProduct.Click += tpAddProduct_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(22, 67, 108);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(90, 569);
            button1.Name = "button1";
            button1.Size = new Size(157, 54);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.None;
            nudQuantity.Location = new Point(181, 108);
            nudQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(176, 31);
            nudQuantity.TabIndex = 6;
            // 
            // cmbstatus
            // 
            cmbstatus.Anchor = AnchorStyles.None;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "", "Available", "Not Available" });
            cmbstatus.Location = new Point(181, 221);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(264, 33);
            cmbstatus.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 222);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 12;
            label7.Text = "Status:";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(181, 164);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(264, 33);
            cmbCategory.TabIndex = 10;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 165);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 9;
            label6.Text = "Category:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 111);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 5;
            label4.Text = "Quntity:";
            // 
            // nudRate
            // 
            nudRate.Anchor = AnchorStyles.None;
            nudRate.Location = new Point(181, 56);
            nudRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudRate.Name = "nudRate";
            nudRate.Size = new Size(176, 31);
            nudRate.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 63);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 3;
            label3.Text = "Rate:";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.None;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(181, 13);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(304, 31);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 16);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 68, 108);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = ".../ Add Product";
            // 
            // tpManageProduct
            // 
            tpManageProduct.Controls.Add(picSearch);
            tpManageProduct.Controls.Add(txtSearchProduct);
            tpManageProduct.Controls.Add(lblTotal1);
            tpManageProduct.Controls.Add(label9);
            tpManageProduct.Controls.Add(lblTotal);
            tpManageProduct.Controls.Add(label8);
            tpManageProduct.Controls.Add(dgvProduct);
            tpManageProduct.Location = new Point(4, 4);
            tpManageProduct.Name = "tpManageProduct";
            tpManageProduct.Padding = new Padding(3);
            tpManageProduct.Size = new Size(1293, 779);
            tpManageProduct.TabIndex = 1;
            tpManageProduct.Text = "Manage Product";
            tpManageProduct.UseVisualStyleBackColor = true;
            // 
            // picSearch
            // 
            picSearch.Anchor = AnchorStyles.None;
            picSearch.BorderStyle = BorderStyle.FixedSingle;
            picSearch.Cursor = Cursors.Hand;
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(895, 76);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(42, 31);
            picSearch.SizeMode = PictureBoxSizeMode.Zoom;
            picSearch.TabIndex = 13;
            picSearch.TabStop = false;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.None;
            txtSearchProduct.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProduct.Location = new Point(154, 76);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(746, 31);
            txtSearchProduct.TabIndex = 12;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged_1;
            // 
            // lblTotal1
            // 
            lblTotal1.Anchor = AnchorStyles.None;
            lblTotal1.AutoSize = true;
            lblTotal1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal1.ForeColor = SystemColors.ControlText;
            lblTotal1.Location = new Point(170, 598);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(30, 25);
            lblTotal1.TabIndex = 16;
            lblTotal1.Text = "{?}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 67, 108);
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(229, 32);
            label9.TabIndex = 10;
            label9.Text = "..../Manage Product";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.Location = new Point(118, 598);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(12, 82);
            label8.Name = "label8";
            label8.Size = new Size(136, 25);
            label8.TabIndex = 11;
            label8.Text = "Product Name:";
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AllowUserToResizeColumns = false;
            dgvProduct.AllowUserToResizeRows = false;
            dgvProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.BorderStyle = BorderStyle.Fixed3D;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 34;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 151, 196);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(6, 290);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 62;
            dgvProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ShowCellErrors = false;
            dgvProduct.ShowCellToolTips = false;
            dgvProduct.ShowEditingIcon = false;
            dgvProduct.ShowRowErrors = false;
            dgvProduct.Size = new Size(1281, 305);
            dgvProduct.TabIndex = 14;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Product_Id";
            Column1.HeaderText = "Product Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Rate";
            Column3.HeaderText = "Rate";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Quantity";
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Category";
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Status";
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // tpOptions
            // 
            tpOptions.Controls.Add(panel2);
            tpOptions.Controls.Add(btnRemove);
            tpOptions.Controls.Add(btnChange);
            tpOptions.Controls.Add(label14);
            tpOptions.Location = new Point(4, 4);
            tpOptions.Name = "tpOptions";
            tpOptions.Padding = new Padding(3);
            tpOptions.Size = new Size(1293, 779);
            tpOptions.TabIndex = 2;
            tpOptions.Text = "Options";
            tpOptions.UseVisualStyleBackColor = true;
            // 
            // nudQunatity2
            // 
            nudQunatity2.Anchor = AnchorStyles.None;
            nudQunatity2.Location = new Point(153, 106);
            nudQunatity2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQunatity2.Name = "nudQunatity2";
            nudQunatity2.Size = new Size(276, 31);
            nudQunatity2.TabIndex = 28;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(50, 108);
            label15.Name = "label15";
            label15.Size = new Size(80, 25);
            label15.TabIndex = 27;
            label15.Text = "Quntity:";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.BackColor = Color.FromArgb(57, 151, 196);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(331, 546);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 63);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_2;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.None;
            btnChange.BackColor = Color.FromArgb(22, 67, 108);
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(138, 546);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(128, 63);
            btnChange.TabIndex = 25;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click_1;
            // 
            // cmbStatus2
            // 
            cmbStatus2.Anchor = AnchorStyles.None;
            cmbStatus2.FormattingEnabled = true;
            cmbStatus2.Items.AddRange(new object[] { "", "Available", "Not Available" });
            cmbStatus2.Location = new Point(153, 212);
            cmbStatus2.Name = "cmbStatus2";
            cmbStatus2.Size = new Size(259, 33);
            cmbStatus2.TabIndex = 24;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(50, 212);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 23;
            label10.Text = "Status:";
            // 
            // cmbCategory2
            // 
            cmbCategory2.Anchor = AnchorStyles.None;
            cmbCategory2.FormattingEnabled = true;
            cmbCategory2.Location = new Point(153, 155);
            cmbCategory2.Name = "cmbCategory2";
            cmbCategory2.Size = new Size(259, 33);
            cmbCategory2.TabIndex = 22;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(50, 158);
            label11.Name = "label11";
            label11.Size = new Size(92, 25);
            label11.TabIndex = 21;
            label11.Text = "Category:";
            // 
            // nudRate1
            // 
            nudRate1.Anchor = AnchorStyles.None;
            nudRate1.Location = new Point(153, 63);
            nudRate1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudRate1.Name = "nudRate1";
            nudRate1.Size = new Size(291, 31);
            nudRate1.TabIndex = 20;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(77, 63);
            label12.Name = "label12";
            label12.Size = new Size(53, 25);
            label12.TabIndex = 19;
            label12.Text = "Rate:";
            // 
            // txtProductName1
            // 
            txtProductName1.Anchor = AnchorStyles.None;
            txtProductName1.BorderStyle = BorderStyle.FixedSingle;
            txtProductName1.Location = new Point(153, 12);
            txtProductName1.Name = "txtProductName1";
            txtProductName1.Size = new Size(426, 31);
            txtProductName1.TabIndex = 18;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(16, 14);
            label13.Name = "label13";
            label13.Size = new Size(136, 25);
            label13.TabIndex = 17;
            label13.Text = "Product Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(22, 68, 108);
            label14.Location = new Point(6, 3);
            label14.Name = "label14";
            label14.Size = new Size(98, 25);
            label14.TabIndex = 16;
            label14.Text = ".../Options";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = button1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnChange;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = btnRemove;
            // 
            // panel1
            // 
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(cmbstatus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nudRate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(48, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 361);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(nudQunatity2);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(cmbStatus2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cmbCategory2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(nudRate1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtProductName1);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(122, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 357);
            panel2.TabIndex = 29;
            // 
            // userControlBrand1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcProduct);
            Name = "userControlBrand1";
            Size = new Size(1301, 820);
            Load += UserControlBrand_Load;
            tcProduct.ResumeLayout(false);
            tpAddProduct.ResumeLayout(false);
            tpAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRate).EndInit();
            tpManageProduct.ResumeLayout(false);
            tpManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            tpOptions.ResumeLayout(false);
            tpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQunatity2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRate1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcProduct;
        private TabPage tpAddProduct;
        private TabPage tpManageProduct;
        private TabPage tpOptions;
        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private NumericUpDown nudQuantity;
        private Label label4;
        private NumericUpDown nudRate;
        private Label label3;
        private PageSetupDialog pageSetupDialog1;
        private Label label6;
        private ComboBox cmbCategory;
        private ComboBox cmbstatus;
        private Label label7;
        private Button button1;
        private TextBox txtProductName1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label lblTotal1;
        private Label label9;
        private Label lblTotal;
        private Label label8;
        private DataGridView dgvProduct;
        private PictureBox picSearch;
        private TextBox txtSearchProduct;
        private ToolTip toolTip1;
        private Button btnChange;
        private ComboBox cmbStatus2;
        private Label label10;
        private ComboBox cmbCategory2;
        private Label label11;
        private NumericUpDown nudRate1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button btnRemove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private NumericUpDown nudQunatity2;
        private Label label15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel1;
        private Panel panel2;
    }
}
