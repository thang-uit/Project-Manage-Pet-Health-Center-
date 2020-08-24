using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Pet_Health_Center.Function_Receptionist
{
    public partial class Order_Detail : Form
    {
        public string Order_ID;
        public string Customer_Name;
        BUS_OrderDetail bus_ordd = new BUS_OrderDetail();

        public Order_Detail()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            txtName.Text = Customer_Name;
            dgvOrderDetail.DataSource = bus_ordd.Display_ORDERDETAIL(Order_ID);
        }

        private void Order_Detail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
