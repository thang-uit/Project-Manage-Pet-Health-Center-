using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using Manage_Pet_Health_Center.Properties;

namespace Manage_Pet_Health_Center.Function_Recep
{
    public partial class Payment : UserControl
    {
        BUS_Account bus_acc = new BUS_Account();
        BUS_Employee bus_emp = new BUS_Employee();
        BUS_Customer bus_cus = new BUS_Customer();
        BUS_Pet bus_pet = new BUS_Pet();
        BUS_Product bus_pro = new BUS_Product();
        BUS_Order bus_ord = new BUS_Order();
        BUS_Booking bus_boo = new BUS_Booking();
        BUS_OrderDetail bus_ordd = new BUS_OrderDetail();
        System.Data.DataTable Receptionist_ID;

        public Payment(System.Data.DataTable Rec_ID)
        {
            Receptionist_ID = Rec_ID;
            InitializeComponent();
        }

        private void Load_cboBookingID()
        {
            cboBookingID.DataSource = bus_boo.Display_BookingID();
            cboBookingID.DisplayMember = "BOOKING_ID";
            cboBookingID.ValueMember = "BOOKING_ID";
        }

        private void Load_cboEmployeeID()
        {

            cboEmployeeID.DataSource = Receptionist_ID;
            cboEmployeeID.DisplayMember = "EMPLOYEE_ID";
            cboEmployeeID.ValueMember = "EMPLOYEE_ID";
        }

        private void Load_cboProductID()
        {
            cboProductID.DataSource = bus_pro.Display_ProductID();
            cboProductID.DisplayMember = "PRODUCT_NO";
            cboProductID.ValueMember = "PRODUCT_NO";
        }

        public void LoadData()
        {
            Load_cboBookingID();
            Load_cboEmployeeID();
            Load_cboProductID();
        }       

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool CheckData_Order()
        {
            if (string.IsNullOrWhiteSpace(cboBookingID.Text) == true)
            {
                MessageBox.Show("Please select Booking ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBookingID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) == true)
            {
                MessageBox.Show("Please enter Order ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) == true)
            {
                MessageBox.Show("Customer ID can not empty!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboEmployeeID.Text) == true)
            {
                MessageBox.Show("Please select Employee ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEmployeeID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) == true)
            {
                MessageBox.Show("Cashier can not empty!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEmployeeID.Focus();
                return false;
            }
            return true;
        }

        private void ResetOrder()
        {
            cboBookingID.Text = "";
            txtOrderID.Text = "";
            txtVet.Text = "";
            txtCustomerID.Text = "";
            txtGender.Text = "";
            txtCustomerName.Text = "";
            txtPetID.Text = "";
            txtPettype.Text = "";
            txtPetName.Text = "";
            cboProductID.Text = "";
            txtProducttype.Text = "";
            txtProductName.Text = "";
            numAmount.Value = 0;
            txtPrice.Text = "";
            txtTotalAmount.Text = "";
            lblTotalPrice.Text = "000000";
        }

        private void cboBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVet.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["VET"].ToString();
            txtCustomerID.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["CUSTOMER_ID"].ToString();
            txtGender.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["GENDER"].ToString();
            txtCustomerName.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["CUSTOMER"].ToString();
            txtPetID.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["PET_ID"].ToString();
            txtPettype.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["PET_TYPE"].ToString();
            txtPetName.Text = bus_boo.Display_InfoBooking(cboBookingID.Text).Rows[0]["NAME"].ToString();
        }

        private void cboEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmployeeName.Text = bus_emp.Display_ReceptionistName(cboEmployeeID.Text).Rows[0]["NAME"].ToString();
        }

        private void cboProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProducttype.Text = bus_pro.Display_Products(cboProductID.Text).Rows[0]["PRODUCT_TYPE"].ToString();
            txtProductName.Text = bus_pro.Display_Products(cboProductID.Text).Rows[0]["NAME"].ToString();
            txtPrice.Text = bus_pro.Display_Products(cboProductID.Text).Rows[0]["PRICE"].ToString();
            numAmount.Value = 0;
            txtTotalAmount.Text = "";
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPrice.Text) == true)
            {
                MessageBox.Show("Please select Product ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProductID.Focus();
            }
            else
            {
                long TotalAmount = int.Parse(numAmount.Value.ToString()) * long.Parse(txtPrice.Text);
                txtTotalAmount.Text = TotalAmount.ToString();
            }           
        }
       
        public bool ChechData_OrderDetail()
        {
            if (string.IsNullOrWhiteSpace(cboBookingID.Text) == true)
            {
                MessageBox.Show("Please select Booking ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBookingID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) == true)
            {
                MessageBox.Show("Please enter Order ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) == true)
            {
                MessageBox.Show("Customer ID can not empty!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboEmployeeID.Text) == true)
            {
                MessageBox.Show("Please select Employee ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEmployeeID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) == true)
            {
                MessageBox.Show("Cashier can not empty!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEmployeeID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) == true)
            {
                MessageBox.Show("Please enter Order ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(numAmount.Value.ToString()) == true)
            {
                MessageBox.Show("Please select Amount!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numAmount.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text) == true)
            {
                MessageBox.Show("Total amount can not empty!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalAmount.Focus();
                return false;
            }
            return true;
        }

        private bool Check_ProductExist()
        {
            for (int i = 0; i < (dgvOrderDetail.Rows.Count) - 1; i++)
            {
                if (cboProductID.Text.Equals(dgvOrderDetail.Rows[i].Cells[1].Value.ToString()) == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChechData_OrderDetail() == true)
            {
                if(Check_ProductExist() == true)
                {
                    DTO_OrderDetail dto_ordd = new DTO_OrderDetail(txtOrderID.Text, cboProductID.Text, int.Parse(numAmount.Value.ToString()), long.Parse(txtTotalAmount.Text));
                    if (bus_ordd.Add(dto_ordd))
                    {
                        MessageBox.Show("ADDING SUCCESS!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvOrderDetail.DataSource = bus_ordd.Display_ORDERDETAIL(txtOrderID.Text);

                        long totalprice = 0;
                        for (int i = 0; i < (dgvOrderDetail.Rows.Count) - 1; i++)
                        {
                            totalprice += long.Parse(dgvOrderDetail.Rows[i].Cells[6].Value.ToString());
                        }
                        lblTotalPrice.Text = totalprice.ToString();

                        numAmount.Value = 0;
                        txtTotalAmount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("ADDING FAIL!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("'    " + cboProductID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ChechData_OrderDetail() == true)
            {
                DTO_OrderDetail dto_ordd = new DTO_OrderDetail(txtOrderID.Text, cboProductID.Text, int.Parse(numAmount.Value.ToString()), long.Parse(txtTotalAmount.Text));
                if (bus_ordd.Edit(dto_ordd))
                {
                    MessageBox.Show("EDITING SUCCESS!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOrderDetail.DataSource = bus_ordd.Display_ORDERDETAIL(txtOrderID.Text);

                    long totalprice = 0;
                    for (int i = 0; i < (dgvOrderDetail.Rows.Count) - 1; i++)
                    {
                        totalprice += long.Parse(dgvOrderDetail.Rows[i].Cells[6].Value.ToString());
                    }
                    lblTotalPrice.Text = totalprice.ToString();
                }
                else
                {
                    MessageBox.Show("EDITING FAIL!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(cboProductID.Text) != true)
                {
                    if (bus_ordd.Delete(txtOrderID.Text, cboProductID.Text))
                    {
                        MessageBox.Show("DELETING SUCCESS", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvOrderDetail.DataSource = bus_ordd.Display_ORDERDETAIL(txtOrderID.Text);

                        long totalprice = 0;
                        for (int i = 0; i < (dgvOrderDetail.Rows.Count) - 1; i++)
                        {
                            totalprice += long.Parse(dgvOrderDetail.Rows[i].Cells[6].Value.ToString());
                        }
                        lblTotalPrice.Text = totalprice.ToString();
                        numAmount.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("DELETING FAIL", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select the Product ID you want to delete in the Product ID box!");
                    cboProductID.Focus();
                }
            }//Kết thúc thao tác xóa
        }

        private void Print_Bill() // Payment
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Print Bill";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvOrderDetail.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvOrderDetail.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvOrderDetail.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvOrderDetail.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Print Bill Success!", "PRINT BILL", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (CheckData_Order() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Saving and print bill, are you sure?", "SAVE AND PRINT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    DTO_Order dto_ord = new DTO_Order(txtOrderID.Text, cboBookingID.Text, txtCustomerID.Text, txtVet.Text, txtPetID.Text, cboEmployeeID.Text, OrderDate.Value.ToString(), long.Parse(lblTotalPrice.Text));
                    if (bus_ord.Save(dto_ord))
                    {
                        MessageBox.Show("SAVE SUCCESS!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        printPreviewDialog.Document = printDocument; 
                        printPreviewDialog.ShowDialog(); 
                        printDocument.Print(); // In hóa đơn

                        Load_cboBookingID();                   
                        dgvOrderDetail.DataSource = bus_ordd.Refresh_OrderDetail_Empty(); // Tạo mới lại bảng Chi tiết hóa đơn rỗng
                        ResetOrder();
                    }
                    else
                    {
                        MessageBox.Show("SAVE FAIL!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                }
            }
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            txtOrderID.Text = dgvOrderDetail.CurrentRow.Cells[0].Value.ToString();
            cboProductID.Text = dgvOrderDetail.CurrentRow.Cells[1].Value.ToString();
            txtProducttype.Text = dgvOrderDetail.CurrentRow.Cells[2].Value.ToString();
            txtProductName.Text = dgvOrderDetail.CurrentRow.Cells[3].Value.ToString();
            numAmount.Value = int.Parse(dgvOrderDetail.CurrentRow.Cells[4].Value.ToString());
            txtPrice.Text = dgvOrderDetail.CurrentRow.Cells[5].Value.ToString();
            txtTotalAmount.Text = dgvOrderDetail.CurrentRow.Cells[6].Value.ToString();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MANAGE PET HEALTH CENTER", new System.Drawing.Font("Arial", 30, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, 50));
            e.Graphics.DrawString("____________________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 100));


            Image image = Resources.bill;
            e.Graphics.DrawImage(image, 300, 100, image.Width, image.Height);
            e.Graphics.DrawString("BILL", new System.Drawing.Font("Arial", 25, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(380, 310));



            e.Graphics.DrawString("Booking ID: " + cboBookingID.Text, new System.Drawing.Font("Arial", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 360));
            e.Graphics.DrawString("Order ID: " + txtOrderID.Text, new System.Drawing.Font("Arial", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 400));

            e.Graphics.DrawString("************************************************************************************************************************************", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 435));

            e.Graphics.DrawString("Date: " + OrderDate.Value.ToString(), new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 450));
            e.Graphics.DrawString("Cashier: " + txtEmployeeName.Text, new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 480));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 510));

            e.Graphics.DrawString("Customer ID: " + txtCustomerID.Text, new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 540));
            e.Graphics.DrawString("Customer Name: " + txtCustomerName.Text + " (" + txtGender.Text + ")", new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 570));
            e.Graphics.DrawString("Pet ID: " + txtPetID.Text, new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 600));
            e.Graphics.DrawString("Pet Name: " + txtPetName.Text + " (" + txtPettype.Text + ")", new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 630));
            e.Graphics.DrawString("Vet: " + txtVet.Text, new System.Drawing.Font("Arial", 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 660));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, 690));

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 720));
            e.Graphics.DrawString("PRODUCT TYPE", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 740));
            e.Graphics.DrawString("NAME", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 740));
            e.Graphics.DrawString("AMOUNT", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(450, 740));
            e.Graphics.DrawString("PRICE", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(590, 740));
            e.Graphics.DrawString("TOTAL AMOUNT", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(700, 740));
            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 738));

            int yPos = 770;
            for(int i = 0; i < (dgvOrderDetail.Rows.Count) - 1; i++)
            {
                e.Graphics.DrawString(dgvOrderDetail.Rows[i].Cells[2].Value.ToString() + "                              " + dgvOrderDetail.Rows[i].Cells[3].Value.ToString() + "                                             " + dgvOrderDetail.Rows[i].Cells[4].Value.ToString() + "                           " + dgvOrderDetail.Rows[i].Cells[5].Value.ToString() + "                       " + dgvOrderDetail.Rows[i].Cells[6].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, yPos));
                yPos = yPos + 30;
            }

            e.Graphics.DrawString("==========================================================================================================================", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, yPos - 10));

            e.Graphics.DrawString("TOTAL PRICE(VNĐ)", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(650, yPos + 20));
            e.Graphics.DrawString(lblTotalPrice.Text, new System.Drawing.Font("Arial", 13, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(680, yPos + 50));

            e.Graphics.DrawString("Thank you and see you again.", new System.Drawing.Font("Arial", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(250, yPos + 80));
        }
    }
}
