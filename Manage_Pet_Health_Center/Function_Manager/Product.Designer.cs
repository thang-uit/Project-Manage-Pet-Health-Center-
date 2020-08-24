namespace Manage_Pet_Health_Center.Function_Manager
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDisplayProduct = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.PRODUCT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProducttype = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.pnlTitleProduct = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlDisplayProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTitleProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayProduct
            // 
            this.pnlDisplayProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlDisplayProduct.Controls.Add(this.lblAmount);
            this.pnlDisplayProduct.Controls.Add(this.lbl);
            this.pnlDisplayProduct.Controls.Add(this.btnCancel);
            this.pnlDisplayProduct.Controls.Add(this.btnSearch);
            this.pnlDisplayProduct.Controls.Add(this.txtSearch);
            this.pnlDisplayProduct.Controls.Add(this.dgvProduct);
            this.pnlDisplayProduct.Controls.Add(this.groupBox1);
            this.pnlDisplayProduct.Location = new System.Drawing.Point(0, 120);
            this.pnlDisplayProduct.Name = "pnlDisplayProduct";
            this.pnlDisplayProduct.Size = new System.Drawing.Size(1529, 746);
            this.pnlDisplayProduct.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAmount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmount.Location = new System.Drawing.Point(1120, 15);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(26, 29);
            this.lblAmount.TabIndex = 50;
            this.lblAmount.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl.Location = new System.Drawing.Point(995, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 29);
            this.lbl.TabIndex = 49;
            this.lbl.Text = "Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Manage_Pet_Health_Center.Properties.Resources.cancel_24px;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(805, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 39);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Manage_Pet_Health_Center.Properties.Resources.google_web_search_24px;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(762, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 41);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtSearch.Location = new System.Drawing.Point(509, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 28);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.Text = "ID, Product type, Name";
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_NO,
            this.PRODUCT_TYPE,
            this.NAME,
            this.SUPPLIER,
            this.NATION,
            this.PRICE});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Location = new System.Drawing.Point(509, 49);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1020, 694);
            this.dgvProduct.TabIndex = 45;
            this.dgvProduct.SelectionChanged += new System.EventHandler(this.dgvProduct_SelectionChanged);
            // 
            // PRODUCT_NO
            // 
            this.PRODUCT_NO.DataPropertyName = "PRODUCT_NO";
            this.PRODUCT_NO.HeaderText = "PRODUCT ID";
            this.PRODUCT_NO.MinimumWidth = 6;
            this.PRODUCT_NO.Name = "PRODUCT_NO";
            this.PRODUCT_NO.ReadOnly = true;
            this.PRODUCT_NO.Width = 110;
            // 
            // PRODUCT_TYPE
            // 
            this.PRODUCT_TYPE.DataPropertyName = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.HeaderText = "PRODUCT TYPE";
            this.PRODUCT_TYPE.MinimumWidth = 6;
            this.PRODUCT_TYPE.Name = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.ReadOnly = true;
            this.PRODUCT_TYPE.Width = 125;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 145;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.DataPropertyName = "SUPPLIER";
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.MinimumWidth = 6;
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.ReadOnly = true;
            this.SUPPLIER.Width = 110;
            // 
            // NATION
            // 
            this.NATION.DataPropertyName = "NATION";
            this.NATION.HeaderText = "NATION";
            this.NATION.MinimumWidth = 6;
            this.NATION.Name = "NATION";
            this.NATION.ReadOnly = true;
            this.NATION.Width = 110;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblProducttype);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.lblNation);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtNation);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.txtProductType);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 704);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(188, 495);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 1);
            this.panel6.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(188, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 1);
            this.panel5.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(188, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(188, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 1);
            this.panel3.TabIndex = 48;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplier.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtSupplier.ForeColor = System.Drawing.Color.White;
            this.txtSupplier.Location = new System.Drawing.Point(189, 297);
            this.txtSupplier.MaxLength = 100;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(262, 21);
            this.txtSupplier.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(188, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 1);
            this.panel2.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 137);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add, Edit and Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Manage_Pet_Health_Center.Properties.Resources.delete_64px;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(310, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 106);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Manage_Pet_Health_Center.Properties.Resources.add_new_100px;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(11, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 105);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Manage_Pet_Health_Center.Properties.Resources.edit_property_64px;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(163, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 109);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(188, 69);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(167, 1);
            this.panel8.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(188, 212);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblProducttype
            // 
            this.lblProducttype.AutoSize = true;
            this.lblProducttype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblProducttype.ForeColor = System.Drawing.Color.White;
            this.lblProducttype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducttype.Location = new System.Drawing.Point(22, 125);
            this.lblProducttype.Name = "lblProducttype";
            this.lblProducttype.Size = new System.Drawing.Size(132, 24);
            this.lblProducttype.TabIndex = 31;
            this.lblProducttype.Text = "Product type";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProductID.Location = new System.Drawing.Point(22, 46);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(110, 24);
            this.lblProductID.TabIndex = 29;
            this.lblProductID.Text = "Product ID";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNation.ForeColor = System.Drawing.Color.White;
            this.lblNation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNation.Location = new System.Drawing.Point(22, 385);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(71, 24);
            this.lblNation.TabIndex = 39;
            this.lblNation.Text = "Nation";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(188, 474);
            this.txtPrice.MaxLength = 13;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // txtNation
            // 
            this.txtNation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtNation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNation.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtNation.ForeColor = System.Drawing.Color.White;
            this.txtNation.Location = new System.Drawing.Point(188, 387);
            this.txtNation.MaxLength = 100;
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(216, 21);
            this.txtNation.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupplier.Location = new System.Drawing.Point(22, 295);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(88, 24);
            this.lblSupplier.TabIndex = 37;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtProductType
            // 
            this.txtProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtProductType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductType.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtProductType.ForeColor = System.Drawing.Color.White;
            this.txtProductType.Location = new System.Drawing.Point(188, 127);
            this.txtProductType.MaxLength = 100;
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(194, 21);
            this.txtProductType.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(22, 210);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrice.Location = new System.Drawing.Point(22, 472);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price";
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductID.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtProductID.ForeColor = System.Drawing.Color.White;
            this.txtProductID.Location = new System.Drawing.Point(188, 47);
            this.txtProductID.MaxLength = 10;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(167, 21);
            this.txtProductID.TabIndex = 1;
            // 
            // pnlTitleProduct
            // 
            this.pnlTitleProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlTitleProduct.Controls.Add(this.panel1);
            this.pnlTitleProduct.Controls.Add(this.lblProduct);
            this.pnlTitleProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleProduct.Name = "pnlTitleProduct";
            this.pnlTitleProduct.Size = new System.Drawing.Size(1529, 114);
            this.pnlTitleProduct.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.product_100px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(563, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 98);
            this.panel1.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProduct.Location = new System.Drawing.Point(657, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(326, 70);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "PRODUCT";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDisplayProduct);
            this.Controls.Add(this.pnlTitleProduct);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(1529, 866);
            this.Load += new System.EventHandler(this.Product_Load);
            this.pnlDisplayProduct.ResumeLayout(false);
            this.pnlDisplayProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlTitleProduct.ResumeLayout(false);
            this.pnlTitleProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayProduct;
        private System.Windows.Forms.Panel pnlTitleProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProducttype;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}
