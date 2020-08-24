using BUS;
using Manage_Pet_Health_Center.Function_Receptionist;
using System;
using System.Windows.Forms;

namespace Manage_Pet_Health_Center.Function_Recep
{
    public partial class SearchOrder : UserControl
    {
        BUS_Order bus_ord = new BUS_Order();

        public SearchOrder()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvOrder.DataSource = bus_ord.Display_Order();
            lblAmountOrder.Text = Convert.ToString(dgvOrder.Rows.Count - 1);
        }

        private void SearchOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvOrder.DataSource = bus_ord.Display_SearchOrder(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            Order_Detail order_Detail = new Order_Detail();
            order_Detail.Order_ID = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            order_Detail.Customer_Name = dgvOrder.CurrentRow.Cells[5].Value.ToString();
            order_Detail.ShowDialog();
        }
    }
}
