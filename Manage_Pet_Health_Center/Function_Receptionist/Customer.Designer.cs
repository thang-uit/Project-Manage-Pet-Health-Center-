namespace Manage_Pet_Health_Center.Function_Recep
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAmountCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANAGE_PET_HEALTH_CENTERDataSet = new Manage_Pet_Health_Center.MANAGE_PET_HEALTH_CENTERDataSet();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cUSTOMERTableAdapter = new Manage_Pet_Health_Center.MANAGE_PET_HEALTH_CENTERDataSetTableAdapters.CUSTOMERTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlTitleCustomer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlDisplayCustomer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGE_PET_HEALTH_CENTERDataSet)).BeginInit();
            this.pnlTitleCustomer.SuspendLayout();
            this.pnlDisplayCustomer.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 590);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 158);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add, Edit and Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Manage_Pet_Health_Center.Properties.Resources.delete_male_user_100px;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(310, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 128);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Manage_Pet_Health_Center.Properties.Resources.add_female_user_100px;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(11, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 128);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Manage_Pet_Health_Center.Properties.Resources.edit_user_100px;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(163, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 128);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(189, 590);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(170, 1);
            this.panel7.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(189, 517);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 1);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(189, 446);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 1);
            this.panel5.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(189, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 1);
            this.panel4.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(175, 238);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(170, 1);
            this.panel8.TabIndex = 28;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhonenumber.ForeColor = System.Drawing.Color.White;
            this.lblPhonenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhonenumber.Location = new System.Drawing.Point(6, 507);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(148, 24);
            this.lblPhonenumber.TabIndex = 9;
            this.lblPhonenumber.Text = "Phone number";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.White;
            this.lblCustomerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerID.Location = new System.Drawing.Point(7, 61);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(127, 24);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(7, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBirthday.Location = new System.Drawing.Point(7, 208);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(90, 24);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGender.Location = new System.Drawing.Point(7, 288);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 24);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtGender.ForeColor = System.Drawing.Color.White;
            this.txtGender.Location = new System.Drawing.Point(175, 291);
            this.txtGender.MaxLength = 10;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(93, 21);
            this.txtGender.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(6, 434);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 24);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblAmountCustomer
            // 
            this.lblAmountCustomer.AutoSize = true;
            this.lblAmountCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAmountCustomer.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAmountCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblAmountCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmountCustomer.Location = new System.Drawing.Point(1229, 24);
            this.lblAmountCustomer.Name = "lblAmountCustomer";
            this.lblAmountCustomer.Size = new System.Drawing.Size(26, 29);
            this.lblAmountCustomer.TabIndex = 34;
            this.lblAmountCustomer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(954, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Amount of customer";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeight = 29;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.bIRTHDAYDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn});
            this.dgvCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCustomer.DataSource = this.cUSTOMERBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.GridColor = System.Drawing.Color.Blue;
            this.dgvCustomer.Location = new System.Drawing.Point(477, 63);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1219, 767);
            this.dgvCustomer.TabIndex = 30;
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // cUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Name = "cUSTOMERIDDataGridViewTextBoxColumn";
            this.cUSTOMERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 160;
            // 
            // bIRTHDAYDataGridViewTextBoxColumn
            // 
            this.bIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.HeaderText = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIRTHDAYDataGridViewTextBoxColumn.Name = "bIRTHDAYDataGridViewTextBoxColumn";
            this.bIRTHDAYDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIRTHDAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.ReadOnly = true;
            this.gENDERDataGridViewTextBoxColumn.Width = 70;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn.Width = 155;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 160;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.pHONENUMBERDataGridViewTextBoxColumn.Width = 120;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.mANAGE_PET_HEALTH_CENTERDataSet;
            // 
            // mANAGE_PET_HEALTH_CENTERDataSet
            // 
            this.mANAGE_PET_HEALTH_CENTERDataSet.DataSetName = "MANAGE_PET_HEALTH_CENTERDataSet";
            this.mANAGE_PET_HEALTH_CENTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Birthday
            // 
            this.Birthday.CalendarForeColor = System.Drawing.Color.White;
            this.Birthday.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.Birthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Birthday.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(175, 207);
            this.Birthday.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.Birthday.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(170, 28);
            this.Birthday.TabIndex = 3;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerID.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.White;
            this.txtCustomerID.Location = new System.Drawing.Point(175, 63);
            this.txtCustomerID.MaxLength = 10;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(130, 21);
            this.txtCustomerID.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(175, 365);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 21);
            this.txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(175, 436);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(189, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 1);
            this.panel3.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(6, 363);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 24);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(189, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 1);
            this.panel2.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(175, 135);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 21);
            this.txtName.TabIndex = 2;
            // 
            // pnlTitleCustomer
            // 
            this.pnlTitleCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleCustomer.AutoScroll = true;
            this.pnlTitleCustomer.AutoSize = true;
            this.pnlTitleCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlTitleCustomer.Controls.Add(this.panel1);
            this.pnlTitleCustomer.Controls.Add(this.lblCustomer);
            this.pnlTitleCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleCustomer.Name = "pnlTitleCustomer";
            this.pnlTitleCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTitleCustomer.Size = new System.Drawing.Size(1696, 105);
            this.pnlTitleCustomer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.user_100px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(604, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 98);
            this.panel1.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomer.Location = new System.Drawing.Point(698, 14);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(373, 70);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "CUSTOMER";
            // 
            // pnlDisplayCustomer
            // 
            this.pnlDisplayCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlDisplayCustomer.Controls.Add(this.label2);
            this.pnlDisplayCustomer.Controls.Add(this.lblAmountCustomer);
            this.pnlDisplayCustomer.Controls.Add(this.label1);
            this.pnlDisplayCustomer.Controls.Add(this.dgvCustomer);
            this.pnlDisplayCustomer.Controls.Add(this.panel7);
            this.pnlDisplayCustomer.Controls.Add(this.panel6);
            this.pnlDisplayCustomer.Controls.Add(this.panel5);
            this.pnlDisplayCustomer.Controls.Add(this.panel4);
            this.pnlDisplayCustomer.Controls.Add(this.panel3);
            this.pnlDisplayCustomer.Controls.Add(this.panel2);
            this.pnlDisplayCustomer.Controls.Add(this.btnCancel);
            this.pnlDisplayCustomer.Controls.Add(this.btnSearch);
            this.pnlDisplayCustomer.Controls.Add(this.txtSearch);
            this.pnlDisplayCustomer.Controls.Add(this.groupBox);
            this.pnlDisplayCustomer.Location = new System.Drawing.Point(0, 107);
            this.pnlDisplayCustomer.Name = "pnlDisplayCustomer";
            this.pnlDisplayCustomer.Size = new System.Drawing.Size(1696, 833);
            this.pnlDisplayCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1295, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 18);
            this.label2.TabIndex = 110;
            this.label2.Text = "Double click on Row to display Pet of each customer";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Manage_Pet_Health_Center.Properties.Resources.cancel_24px;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(805, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 39);
            this.btnCancel.TabIndex = 20;
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
            this.btnSearch.Location = new System.Drawing.Point(754, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 46);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtSearch.Location = new System.Drawing.Point(477, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 28);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "ID, Name";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.panel8);
            this.groupBox.Controls.Add(this.lblPhonenumber);
            this.groupBox.Controls.Add(this.lblCustomerID);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Controls.Add(this.lblBirthday);
            this.groupBox.Controls.Add(this.lblGender);
            this.groupBox.Controls.Add(this.lblAddress);
            this.groupBox.Controls.Add(this.txtGender);
            this.groupBox.Controls.Add(this.lblEmail);
            this.groupBox.Controls.Add(this.Birthday);
            this.groupBox.Controls.Add(this.txtCustomerID);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.txtAddress);
            this.groupBox.Controls.Add(this.txtEmail);
            this.groupBox.Controls.Add(this.txtPhonenumber);
            this.groupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(14, 55);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(457, 775);
            this.groupBox.TabIndex = 31;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Input";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonenumber.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtPhonenumber.ForeColor = System.Drawing.Color.White;
            this.txtPhonenumber.Location = new System.Drawing.Point(175, 509);
            this.txtPhonenumber.MaxLength = 13;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(170, 21);
            this.txtPhonenumber.TabIndex = 7;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlTitleCustomer);
            this.Controls.Add(this.pnlDisplayCustomer);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1696, 940);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGE_PET_HEALTH_CENTERDataSet)).EndInit();
            this.pnlTitleCustomer.ResumeLayout(false);
            this.pnlTitleCustomer.PerformLayout();
            this.pnlDisplayCustomer.ResumeLayout(false);
            this.pnlDisplayCustomer.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAmountCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private MANAGE_PET_HEALTH_CENTERDataSet mANAGE_PET_HEALTH_CENTERDataSet;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddress;
        private MANAGE_PET_HEALTH_CENTERDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlTitleCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlDisplayCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
