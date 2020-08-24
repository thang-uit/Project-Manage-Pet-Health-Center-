namespace Manage_Pet_Health_Center.Function_Receptionist
{
    partial class Order_Detail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.ORDERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT_OF_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDERID,
            this.PRODUCT_NO,
            this.PRODUCT_TYPE,
            this.NAME,
            this.AMOUNT_OF_PRODUCT,
            this.PRICE,
            this.TOTAL_AMOUNT});
            this.dgvOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 108);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1153, 402);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // ORDERID
            // 
            this.ORDERID.DataPropertyName = "ORDER_ID";
            this.ORDERID.HeaderText = "ORDER ID";
            this.ORDERID.MinimumWidth = 6;
            this.ORDERID.Name = "ORDERID";
            this.ORDERID.ReadOnly = true;
            this.ORDERID.Width = 130;
            // 
            // PRODUCT_NO
            // 
            this.PRODUCT_NO.DataPropertyName = "PRODUCT_NO";
            this.PRODUCT_NO.HeaderText = "PRODUCT ID";
            this.PRODUCT_NO.MinimumWidth = 6;
            this.PRODUCT_NO.Name = "PRODUCT_NO";
            this.PRODUCT_NO.ReadOnly = true;
            this.PRODUCT_NO.Width = 125;
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
            this.NAME.Width = 160;
            // 
            // AMOUNT_OF_PRODUCT
            // 
            this.AMOUNT_OF_PRODUCT.DataPropertyName = "AMOUNT_OF_PRODUCT";
            this.AMOUNT_OF_PRODUCT.HeaderText = "AMOUNT";
            this.AMOUNT_OF_PRODUCT.MinimumWidth = 6;
            this.AMOUNT_OF_PRODUCT.Name = "AMOUNT_OF_PRODUCT";
            this.AMOUNT_OF_PRODUCT.ReadOnly = true;
            this.AMOUNT_OF_PRODUCT.Width = 75;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 105;
            // 
            // TOTAL_AMOUNT
            // 
            this.TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.HeaderText = "TOTAL AMOUNT";
            this.TOTAL_AMOUNT.MinimumWidth = 6;
            this.TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.ReadOnly = true;
            this.TOTAL_AMOUNT.Width = 115;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerName.Location = new System.Drawing.Point(459, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(241, 35);
            this.lblCustomerName.TabIndex = 70;
            this.lblCustomerName.Text = "Customer name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(409, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 1);
            this.panel3.TabIndex = 72;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(409, 64);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(345, 27);
            this.txtName.TabIndex = 71;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Order_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1153, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dgvOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Order_Detail";
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.Order_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT_OF_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_AMOUNT;
    }
}