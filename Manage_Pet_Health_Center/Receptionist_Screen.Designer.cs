namespace Manage_Pet_Health_Center
{
    partial class Receptionist_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_Screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnPaymentHistory);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 943);
            this.panel1.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProfile.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.checked_user_male_80px;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(1, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(147, 136);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.btnPaymentHistory.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.bill_100px;
            this.btnPaymentHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaymentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentHistory.FlatAppearance.BorderSize = 0;
            this.btnPaymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentHistory.Location = new System.Drawing.Point(1, 804);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(146, 136);
            this.btnPaymentHistory.TabIndex = 4;
            this.btnPaymentHistory.UseVisualStyleBackColor = false;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.btnPayment.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.card_payment_100px;
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(1, 648);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(146, 136);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.btnBooking.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.edit_property_100px;
            this.btnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Location = new System.Drawing.Point(1, 485);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(146, 136);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.btnCustomer.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.user_100px;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Location = new System.Drawing.Point(1, 324);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(146, 136);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.btnHome.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.conchokhonggia;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(1, 160);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(146, 136);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.AutoSize = true;
            this.pnlDisplay.BackgroundImage = global::Manage_Pet_Health_Center.Properties.Resources.Ghien_review_Dang_cap_thu_cung_04;
            this.pnlDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDisplay.Location = new System.Drawing.Point(151, -2);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1696, 940);
            this.pnlDisplay.TabIndex = 1;
            // 
            // Receptionist_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1847, 937);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Receptionist_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Receptionist";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Receptionist_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPaymentHistory;
        private System.Windows.Forms.Button btnProfile;
    }
}