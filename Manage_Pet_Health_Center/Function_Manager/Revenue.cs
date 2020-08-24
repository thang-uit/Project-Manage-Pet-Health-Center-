using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Manage_Pet_Health_Center.Properties;

namespace Manage_Pet_Health_Center.Function_Manager
{
    public partial class Revenue : UserControl
    {
        BUS_Order bus_ord = new BUS_Order();

        public Revenue()
        {
            InitializeComponent();
        }

        private void Show_Total()
        {
            long Total_Revenue = 0;
            for (int i = 0; i < (dgvOrder.Rows.Count) - 1; i++)
            {
                Total_Revenue += long.Parse(dgvOrder.Rows[i].Cells[9].Value.ToString());
            }
            lblTotalRevenue.Text = Total_Revenue.ToString();
            lblAmountOrder.Text = Convert.ToString(dgvOrder.Rows.Count - 1);
        }

        private void LoadData()
        {
            dgvOrder.DataSource = bus_ord.Display_AllOrder();
            Show_Total();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(cboMonth.Text) == true)
            {
                MessageBox.Show("Please select Month!", "MONTH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMonth.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboYear.Text) == true)
            {
                MessageBox.Show("Please select Year!", "YEAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYear.Focus();
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                dgvOrder.DataSource = bus_ord.Display_FillOrder(cboMonth.Text, cboYear.Text);
                Show_Total();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboMonth.Text = "";
            cboYear.Text = "";
            LoadData();
        }

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Export to Excel! Are you sure?", "EXPORT TO EXCEL", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                // Creating a Excel object. 
                Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                try
                {
                    worksheet = workbook.ActiveSheet;

                    worksheet.Name = "Report";

                    int cellRowIndex = 1;
                    int cellColumnIndex = 1;

                    //Loop through each row and read value from each column. 
                    for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvOrder.Columns.Count; j++)
                        {
                            // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                            if (cellRowIndex == 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvOrder.Columns[j].HeaderText;
                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvOrder.Rows[i].Cells[j].Value.ToString();
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
                        MessageBox.Show("Export to Excel success!", "EXPORT TO EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
            }
        }     

        private void btnReport_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MANAGE PET HEALTH CENTER", new System.Drawing.Font("Arial", 30, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, 50));
            e.Graphics.DrawString("____________________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 100));


            Image image = Resources.business_report_200px;
            e.Graphics.DrawImage(image, 330, 120, image.Width, image.Height);
            e.Graphics.DrawString("REVENUE REPORT", new System.Drawing.Font("Arial", 28, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(257, 350));

            e.Graphics.DrawString("Month " + cboMonth.Text + " " + "Year " + cboYear.Text, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(600, 410));


            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 420));
            e.Graphics.DrawString("ORDER ID", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 440));
            e.Graphics.DrawString("CASHIER", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(150, 440));
            e.Graphics.DrawString("CUSTOMER", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(280, 440));
            e.Graphics.DrawString("VET", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(450, 440));
            e.Graphics.DrawString("PET", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(620, 440));
            e.Graphics.DrawString("TOTAL PRICE", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(720, 440));  
            e.Graphics.DrawString("__________________________________________________________________________________________________________________________", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, 438));

            int yPos = 470;
            for (int i = 0; i < (dgvOrder.Rows.Count) - 1; i++)
            {
                e.Graphics.DrawString(dgvOrder.Rows[i].Cells[0].Value.ToString() + "                      " + dgvOrder.Rows[i].Cells[2].Value.ToString() + "                      " + dgvOrder.Rows[i].Cells[4].Value.ToString() + "                           " + dgvOrder.Rows[i].Cells[5].Value.ToString() + "                                 " + dgvOrder.Rows[i].Cells[7].Value.ToString() + "                              " + dgvOrder.Rows[i].Cells[9].Value.ToString(), new System.Drawing.Font("Arial", 7, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(25, yPos));
                yPos = yPos + 30;
            }

            e.Graphics.DrawString("==========================================================================================================================", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(0, yPos - 10));


            e.Graphics.DrawString("AMOUNT OF ORDER", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, yPos + 20));
            e.Graphics.DrawString(lblAmountOrder.Text, new System.Drawing.Font("Arial", 13, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(145, yPos + 50));
            e.Graphics.DrawString("TOTAL PRICE(VNĐ)", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(650, yPos + 20));
            e.Graphics.DrawString(lblTotalRevenue.Text, new System.Drawing.Font("Arial", 13, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(680, yPos + 50));
        }
    }
}
