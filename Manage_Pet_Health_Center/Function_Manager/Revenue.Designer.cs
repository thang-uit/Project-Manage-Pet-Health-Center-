namespace Manage_Pet_Health_Center.Function_Manager
{
    partial class Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue));
            this.pnlDisplayRevenue = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOKING_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASHIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PET_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PET_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblAmountOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExporttoExcel = new System.Windows.Forms.Button();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlTitleRevenue = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlDisplayRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlTitleRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayRevenue
            // 
            this.pnlDisplayRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlDisplayRevenue.Controls.Add(this.btnReport);
            this.pnlDisplayRevenue.Controls.Add(this.dgvOrder);
            this.pnlDisplayRevenue.Controls.Add(this.cboMonth);
            this.pnlDisplayRevenue.Controls.Add(this.cboYear);
            this.pnlDisplayRevenue.Controls.Add(this.btnCancel);
            this.pnlDisplayRevenue.Controls.Add(this.btnSearch);
            this.pnlDisplayRevenue.Controls.Add(this.label3);
            this.pnlDisplayRevenue.Controls.Add(this.lblMonth);
            this.pnlDisplayRevenue.Controls.Add(this.lblAmountOrder);
            this.pnlDisplayRevenue.Controls.Add(this.label2);
            this.pnlDisplayRevenue.Controls.Add(this.btnExporttoExcel);
            this.pnlDisplayRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnlDisplayRevenue.Controls.Add(this.lbl);
            this.pnlDisplayRevenue.Controls.Add(this.groupBox2);
            this.pnlDisplayRevenue.Location = new System.Drawing.Point(0, 120);
            this.pnlDisplayRevenue.Name = "pnlDisplayRevenue";
            this.pnlDisplayRevenue.Size = new System.Drawing.Size(1529, 746);
            this.pnlDisplayRevenue.TabIndex = 6;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(128)))), ((int)(((byte)(242)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::Manage_Pet_Health_Center.Properties.Resources.report_card_100px1;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(1222, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(307, 107);
            this.btnReport.TabIndex = 126;
            this.btnReport.Text = "Print Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDER_ID,
            this.BOOKING_ID,
            this.CASHIER,
            this.CUSTOMER_ID,
            this.CUSTOMER,
            this.VET,
            this.PET_ID,
            this.PET_TYPE,
            this.ORDER_DATE,
            this.TOTAL_PRICE});
            this.dgvOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrder.Location = new System.Drawing.Point(0, 110);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1529, 533);
            this.dgvOrder.TabIndex = 125;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "ORDER ID";
            this.ORDER_ID.MinimumWidth = 6;
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.ReadOnly = true;
            this.ORDER_ID.Width = 125;
            // 
            // BOOKING_ID
            // 
            this.BOOKING_ID.DataPropertyName = "BOOKING_ID";
            this.BOOKING_ID.HeaderText = "BOOKING ID";
            this.BOOKING_ID.MinimumWidth = 6;
            this.BOOKING_ID.Name = "BOOKING_ID";
            this.BOOKING_ID.ReadOnly = true;
            this.BOOKING_ID.Width = 125;
            // 
            // CASHIER
            // 
            this.CASHIER.DataPropertyName = "CASHIER";
            this.CASHIER.HeaderText = "CASHIER";
            this.CASHIER.MinimumWidth = 6;
            this.CASHIER.Name = "CASHIER";
            this.CASHIER.ReadOnly = true;
            this.CASHIER.Width = 135;
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID";
            this.CUSTOMER_ID.HeaderText = "CUSTOMER ID";
            this.CUSTOMER_ID.MinimumWidth = 6;
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            this.CUSTOMER_ID.ReadOnly = true;
            this.CUSTOMER_ID.Width = 115;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.DataPropertyName = "CUSTOMER";
            this.CUSTOMER.HeaderText = "CUSTOMER";
            this.CUSTOMER.MinimumWidth = 6;
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.ReadOnly = true;
            this.CUSTOMER.Width = 140;
            // 
            // VET
            // 
            this.VET.DataPropertyName = "VET";
            this.VET.HeaderText = "VET";
            this.VET.MinimumWidth = 6;
            this.VET.Name = "VET";
            this.VET.ReadOnly = true;
            this.VET.Width = 140;
            // 
            // PET_ID
            // 
            this.PET_ID.DataPropertyName = "PET_ID";
            this.PET_ID.HeaderText = "PET ID";
            this.PET_ID.MinimumWidth = 6;
            this.PET_ID.Name = "PET_ID";
            this.PET_ID.ReadOnly = true;
            this.PET_ID.Width = 95;
            // 
            // PET_TYPE
            // 
            this.PET_TYPE.DataPropertyName = "PET_TYPE";
            this.PET_TYPE.HeaderText = "PET TYPE";
            this.PET_TYPE.MinimumWidth = 6;
            this.PET_TYPE.Name = "PET_TYPE";
            this.PET_TYPE.ReadOnly = true;
            this.PET_TYPE.Width = 85;
            // 
            // ORDER_DATE
            // 
            this.ORDER_DATE.DataPropertyName = "ORDER_DATE";
            this.ORDER_DATE.HeaderText = "ORDER DATE";
            this.ORDER_DATE.MinimumWidth = 6;
            this.ORDER_DATE.Name = "ORDER_DATE";
            this.ORDER_DATE.ReadOnly = true;
            this.ORDER_DATE.Width = 125;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.DataPropertyName = "TOTAL_PRICE";
            this.TOTAL_PRICE.HeaderText = "TOTAL PRICE";
            this.TOTAL_PRICE.MinimumWidth = 6;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            this.TOTAL_PRICE.Width = 123;
            // 
            // cboMonth
            // 
            this.cboMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(204, 36);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(71, 31);
            this.cboMonth.TabIndex = 124;
            // 
            // cboYear
            // 
            this.cboYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboYear.Location = new System.Drawing.Point(370, 36);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(103, 31);
            this.cboYear.TabIndex = 123;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Manage_Pet_Health_Center.Properties.Resources.cancel_48px;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(562, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 56);
            this.btnCancel.TabIndex = 120;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Manage_Pet_Health_Center.Properties.Resources.search_property_48px;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(482, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 63);
            this.btnSearch.TabIndex = 117;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(302, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 116;
            this.label3.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMonth.Location = new System.Drawing.Point(111, 36);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(87, 29);
            this.lblMonth.TabIndex = 114;
            this.lblMonth.Text = "Month";
            // 
            // lblAmountOrder
            // 
            this.lblAmountOrder.AutoSize = true;
            this.lblAmountOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(129)))));
            this.lblAmountOrder.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOrder.ForeColor = System.Drawing.Color.Black;
            this.lblAmountOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAmountOrder.Location = new System.Drawing.Point(577, 695);
            this.lblAmountOrder.Name = "lblAmountOrder";
            this.lblAmountOrder.Size = new System.Drawing.Size(31, 33);
            this.lblAmountOrder.TabIndex = 112;
            this.lblAmountOrder.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(485, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 111;
            this.label2.Text = "Amount of order";
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExporttoExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExporttoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExporttoExcel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporttoExcel.Image = global::Manage_Pet_Health_Center.Properties.Resources.microsoft_excel_2019_96px;
            this.btnExporttoExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExporttoExcel.Location = new System.Drawing.Point(865, 3);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(357, 107);
            this.btnExporttoExcel.TabIndex = 110;
            this.btnExporttoExcel.Text = "Export to Excel";
            this.btnExporttoExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExporttoExcel.UseVisualStyleBackColor = false;
            this.btnExporttoExcel.Click += new System.EventHandler(this.btnExporttoExcel_Click);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(129)))));
            this.lblTotalRevenue.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRevenue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalRevenue.Location = new System.Drawing.Point(890, 695);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(111, 33);
            this.lblTotalRevenue.TabIndex = 52;
            this.lblTotalRevenue.Text = "000000";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl.Location = new System.Drawing.Point(845, 662);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(197, 33);
            this.lbl.TabIndex = 51;
            this.lbl.Text = "Total revenue";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(355, 646);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 94);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // pnlTitleRevenue
            // 
            this.pnlTitleRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.pnlTitleRevenue.Controls.Add(this.panel1);
            this.pnlTitleRevenue.Controls.Add(this.lblRevenue);
            this.pnlTitleRevenue.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleRevenue.Name = "pnlTitleRevenue";
            this.pnlTitleRevenue.Size = new System.Drawing.Size(1529, 114);
            this.pnlTitleRevenue.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.profit_100px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(563, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 98);
            this.panel1.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRevenue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRevenue.Location = new System.Drawing.Point(657, 20);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(319, 70);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "REVENUE";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDisplayRevenue);
            this.Controls.Add(this.pnlTitleRevenue);
            this.Name = "Revenue";
            this.Size = new System.Drawing.Size(1529, 866);
            this.Load += new System.EventHandler(this.Revenue_Load);
            this.pnlDisplayRevenue.ResumeLayout(false);
            this.pnlDisplayRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlTitleRevenue.ResumeLayout(false);
            this.pnlTitleRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayRevenue;
        private System.Windows.Forms.Panel pnlTitleRevenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnExporttoExcel;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblAmountOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnReport;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOKING_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASHIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn VET;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
    }
}
