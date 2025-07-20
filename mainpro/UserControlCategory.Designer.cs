namespace WinFormsApp23
{
    partial class UserControlCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCategory));
            tcCategory = new TabControl();
            tpAddCategory = new TabPage();
            btnAdd = new Button();
            cmbStatus = new ComboBox();
            label3 = new Label();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tpManageCategory = new TabPage();
            lblTotal = new Label();
            label3455 = new Label();
            dgvCategory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtSearchCategory = new TextBox();
            picSearch = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            tpOptions = new TabPage();
            btnRemove = new Button();
            btnchange = new Button();
            label10 = new Label();
            cmbStatus1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtCategoryName1 = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            toolTip1 = new ToolTip(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tcCategory.SuspendLayout();
            tpAddCategory.SuspendLayout();
            tpManageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            tpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tcCategory
            // 
            tcCategory.Alignment = TabAlignment.Bottom;
            tcCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCategory.Controls.Add(tpAddCategory);
            tcCategory.Controls.Add(tpManageCategory);
            tcCategory.Controls.Add(tpOptions);
            tcCategory.Location = new Point(14, 12);
            tcCategory.Name = "tcCategory";
            tcCategory.SelectedIndex = 0;
            tcCategory.Size = new Size(1296, 808);
            tcCategory.TabIndex = 0;
            // 
            // tpAddCategory
            // 
            tpAddCategory.BackColor = Color.White;
            tpAddCategory.Controls.Add(btnAdd);
            tpAddCategory.Controls.Add(cmbStatus);
            tpAddCategory.Controls.Add(label3);
            tpAddCategory.Controls.Add(txtCategoryName);
            tpAddCategory.Controls.Add(label2);
            tpAddCategory.Controls.Add(label1);
            tpAddCategory.Location = new Point(4, 4);
            tpAddCategory.Name = "tpAddCategory";
            tpAddCategory.Size = new Size(1288, 770);
            tpAddCategory.TabIndex = 0;
            tpAddCategory.Text = "Add Category";
            tpAddCategory.Enter += tpAddCategory_Enter;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(22, 67, 108);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(129, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 63);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "", "Available", "Unavailable" });
            cmbStatus.Location = new Point(431, 190);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(321, 33);
            cmbStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(474, 142);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 3;
            label3.Text = "Status:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.None;
            txtCategoryName.Location = new Point(115, 190);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(291, 31);
            txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(115, 142);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 1;
            label2.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 67, 108);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "..../Add Category";
            // 
            // tpManageCategory
            // 
            tpManageCategory.Controls.Add(lblTotal);
            tpManageCategory.Controls.Add(label3455);
            tpManageCategory.Controls.Add(dgvCategory);
            tpManageCategory.Controls.Add(txtSearchCategory);
            tpManageCategory.Controls.Add(picSearch);
            tpManageCategory.Controls.Add(label4);
            tpManageCategory.Controls.Add(label5);
            tpManageCategory.Location = new Point(4, 4);
            tpManageCategory.Name = "tpManageCategory";
            tpManageCategory.Size = new Size(1288, 770);
            tpManageCategory.TabIndex = 0;
            tpManageCategory.Text = "Manage Category";
            tpManageCategory.UseVisualStyleBackColor = true;
            tpManageCategory.Enter += tpManageCategory_Enter;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.Location = new Point(55, 518);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(30, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "{?}";
            // 
            // label3455
            // 
            label3455.Anchor = AnchorStyles.None;
            label3455.AutoSize = true;
            label3455.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3455.ForeColor = SystemColors.ControlText;
            label3455.Location = new Point(3, 518);
            label3455.Name = "label3455";
            label3455.Size = new Size(56, 25);
            label3455.TabIndex = 8;
            label3455.Text = "Total:";
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.BorderStyle = BorderStyle.Fixed3D;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 67, 108);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 34;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 151, 196);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.Location = new Point(146, 214);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.ShowCellErrors = false;
            dgvCategory.ShowCellToolTips = false;
            dgvCategory.ShowEditingIcon = false;
            dgvCategory.ShowRowErrors = false;
            dgvCategory.Size = new Size(676, 213);
            dgvCategory.TabIndex = 7;
            dgvCategory.CellClick += dgvCategory_CellClick;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Category_id";
            Column1.HeaderText = "Category#";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Category_Name";
            Column2.HeaderText = "Category Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Category_status";
            Column3.HeaderText = "Status";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.Anchor = AnchorStyles.None;
            txtSearchCategory.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCategory.Location = new Point(191, 107);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.Size = new Size(291, 31);
            txtSearchCategory.TabIndex = 5;
            txtSearchCategory.TextChanged += txtSearchCategory_TextChanged;
            // 
            // picSearch
            // 
            picSearch.Anchor = AnchorStyles.None;
            picSearch.BorderStyle = BorderStyle.FixedSingle;
            picSearch.Cursor = Cursors.Hand;
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(477, 107);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(34, 31);
            picSearch.SizeMode = PictureBoxSizeMode.Zoom;
            picSearch.TabIndex = 6;
            picSearch.TabStop = false;
            picSearch.MouseHover += picSearch_MouseHover;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(200, 62);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 4;
            label4.Text = "Category Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 67, 108);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(244, 32);
            label5.TabIndex = 3;
            label5.Text = "..../Manage Category";
            // 
            // tpOptions
            // 
            tpOptions.Controls.Add(btnRemove);
            tpOptions.Controls.Add(btnchange);
            tpOptions.Controls.Add(label10);
            tpOptions.Controls.Add(cmbStatus1);
            tpOptions.Controls.Add(label9);
            tpOptions.Controls.Add(label8);
            tpOptions.Controls.Add(txtCategoryName1);
            tpOptions.Location = new Point(4, 4);
            tpOptions.Name = "tpOptions";
            tpOptions.Padding = new Padding(3);
            tpOptions.Size = new Size(1288, 770);
            tpOptions.TabIndex = 1;
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
            btnRemove.Location = new Point(260, 214);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 63);
            btnRemove.TabIndex = 12;
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
            btnchange.Location = new Point(66, 214);
            btnchange.Name = "btnchange";
            btnchange.Size = new Size(128, 63);
            btnchange.TabIndex = 11;
            btnchange.Text = "change";
            btnchange.UseVisualStyleBackColor = false;
            btnchange.Click += btnchange_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(22, 67, 108);
            label10.Location = new Point(6, 3);
            label10.Name = "label10";
            label10.Size = new Size(133, 32);
            label10.TabIndex = 6;
            label10.Text = "..../Options";
            // 
            // cmbStatus1
            // 
            cmbStatus1.Anchor = AnchorStyles.None;
            cmbStatus1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus1.FlatStyle = FlatStyle.Flat;
            cmbStatus1.FormattingEnabled = true;
            cmbStatus1.Items.AddRange(new object[] { "", "Available", "Unavailable" });
            cmbStatus1.Location = new Point(368, 154);
            cmbStatus1.Name = "cmbStatus1";
            cmbStatus1.Size = new Size(321, 33);
            cmbStatus1.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(52, 106);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 7;
            label9.Text = "Category Name:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(411, 106);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 9;
            label8.Text = "Status:";
            // 
            // txtCategoryName1
            // 
            txtCategoryName1.Anchor = AnchorStyles.None;
            txtCategoryName1.Location = new Point(52, 154);
            txtCategoryName1.Name = "txtCategoryName1";
            txtCategoryName1.Size = new Size(291, 31);
            txtCategoryName1.TabIndex = 8;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = btnAdd;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnchange;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = btnRemove;
            // 
            // UserControlCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcCategory);
            Name = "UserControlCategory";
            Size = new Size(1301, 820);
            tcCategory.ResumeLayout(false);
            tpAddCategory.ResumeLayout(false);
            tpAddCategory.PerformLayout();
            tpManageCategory.ResumeLayout(false);
            tpManageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            tpOptions.ResumeLayout(false);
            tpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcCategory;
        private TabPage tpAddCategory;
        private TabPage tpManageCategory;
        private TabPage tpOptions;
        private Label label1;
        private TextBox txtCategoryName;
        private ComboBox cmbStatus;
        private Label label3;
        private Label label2;
        private Button btnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox txtSearchCategory;
        private Label label4;
        private Label label5;
        private PictureBox picSearch;
        private DataGridView dgvCategory;
        private Label lblTotal;
      
        private ToolTip toolTip1;
        private Button btnchange;
        private Label label10;
        private ComboBox cmbStatus1;
        private Label label9;
        private Label label8;
        private TextBox txtCategoryName1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Button btnRemove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label3455;
    }
}
