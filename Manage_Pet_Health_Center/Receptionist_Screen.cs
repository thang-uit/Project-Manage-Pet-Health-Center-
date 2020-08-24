using DTO;
using Manage_Pet_Health_Center.Function_Recep;
using Manage_Pet_Health_Center.Function_Receptionist;
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
    public partial class Receptionist_Screen : Form
    {
        Home home = new Home();
        Customer customer = new Customer();
        Booking booking = new Booking();
        Payment payment;
        SearchOrder searchOrder = new SearchOrder();
        
        public Receptionist_Screen(DataTable Rec_ID)
        {
            payment = new Payment(Rec_ID);
            InitializeComponent();
        }

        private void Booking_LoadData()
        {
            booking.LoadData();
        }

        private void Payment_LoadData()
        {
            payment.LoadData();
        }

        private void SearchOrder_LoadData()
        {
            searchOrder.LoadData();
        }

        private void Receptionist_Screen_Load(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(home);

            btnHome.BackColor = Color.FromArgb(0, 194, 36);
            btnCustomer.BackColor = Color.FromArgb(64, 73, 77);
            btnBooking.BackColor = Color.FromArgb(64, 73, 77);
            btnPayment.BackColor = Color.FromArgb(64, 73, 77);
            btnPaymentHistory.BackColor = Color.FromArgb(64, 73, 77);

            home.Visible = true;
            customer.Visible = false;
            booking.Visible = false;
            payment.Visible = false;
            searchOrder.Visible = false;

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(customer);

            btnCustomer.BackColor = Color.FromArgb(0, 194, 36);
            btnHome.BackColor = Color.FromArgb(64, 73, 77);
            btnBooking.BackColor = Color.FromArgb(64, 73, 77);
            btnPayment.BackColor = Color.FromArgb(64, 73, 77);
            btnPaymentHistory.BackColor = Color.FromArgb(64, 73, 77);

            customer.Visible = true;
            home.Visible = false;
            booking.Visible = false;
            payment.Visible = false;
            searchOrder.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(booking);

            btnBooking.BackColor = Color.FromArgb(0, 194, 36);
            btnHome.BackColor = Color.FromArgb(64, 73, 77);
            btnCustomer.BackColor = Color.FromArgb(64, 73, 77);           
            btnPayment.BackColor = Color.FromArgb(64, 73, 77);
            btnPaymentHistory.BackColor = Color.FromArgb(64, 73, 77);

            Booking_LoadData();

            booking.Visible = true;
            home.Visible = false;
            customer.Visible = false;
            payment.Visible = false;
            searchOrder.Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(payment);

            btnPayment.BackColor = Color.FromArgb(0, 194, 36);
            btnHome.BackColor = Color.FromArgb(64, 73, 77);
            btnCustomer.BackColor = Color.FromArgb(64, 73, 77);
            btnBooking.BackColor = Color.FromArgb(64, 73, 77);
            btnPaymentHistory.BackColor = Color.FromArgb(64, 73, 77);

            Payment_LoadData();

            payment.Visible = true;
            home.Visible = false;
            customer.Visible = false;
            booking.Visible = false;
            searchOrder.Visible = false;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Add(searchOrder);

            btnPaymentHistory.BackColor = Color.FromArgb(0, 194, 36);
            btnHome.BackColor = Color.FromArgb(64, 73, 77);
            btnCustomer.BackColor = Color.FromArgb(64, 73, 77);
            btnBooking.BackColor = Color.FromArgb(64, 73, 77);
            btnPayment.BackColor = Color.FromArgb(64, 73, 77);

            SearchOrder_LoadData();

            searchOrder.Visible = true;
            home.Visible = false;
            customer.Visible = false;
            booking.Visible = false;
            payment.Visible = false;
        }
    }
}
