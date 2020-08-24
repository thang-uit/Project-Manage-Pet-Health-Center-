using Manage_Pet_Health_Center.Function_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Pet_Health_Center
{
    public partial class Manager_Screen : Form
    {
        Home_M home_m = new Home_M();
        Employee employee = new Employee();
        Product product = new Product();
        Revenue revenue = new Revenue();

        public Manager_Screen()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(home_m);

            btnHome.BackColor = Color.FromArgb(159, 2, 207);
            btnEmployee.BackColor = Color.FromArgb(2, 214, 45);
            btnProduct.BackColor = Color.FromArgb(2, 214, 45);
            btnRevenue.BackColor = Color.FromArgb(2, 214, 45);

            home_m.Visible = true;
            employee.Visible = false;
            product.Visible = false;
            revenue.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(employee);

            btnEmployee.BackColor = Color.FromArgb(159, 2, 207);
            btnHome.BackColor = Color.FromArgb(2, 214, 45);
            btnProduct.BackColor = Color.FromArgb(2, 214, 45);
            btnRevenue.BackColor = Color.FromArgb(2, 214, 45);

            employee.Visible = true;
            home_m.Visible = false;
            product.Visible = false;
            revenue.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(product);

            btnProduct.BackColor = Color.FromArgb(159, 2, 207);
            btnHome.BackColor = Color.FromArgb(2, 214, 45);
            btnEmployee.BackColor = Color.FromArgb(2, 214, 45);
            btnRevenue.BackColor = Color.FromArgb(2, 214, 45);

            product.Visible = true;
            home_m.Visible = false;
            employee.Visible = false;
            revenue.Visible = false;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(revenue);

            btnRevenue.BackColor = Color.FromArgb(159, 2, 207);
            btnHome.BackColor = Color.FromArgb(2, 214, 45);
            btnEmployee.BackColor = Color.FromArgb(2, 214, 45);
            btnProduct.BackColor = Color.FromArgb(2, 214, 45);

            revenue.Visible = true;
            home_m.Visible = false;
            employee.Visible = false;
            product.Visible = false;
        }
    }
}
