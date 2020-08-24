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
using DTO;
using System.Security.Cryptography.X509Certificates;

namespace Manage_Pet_Health_Center.Function_Recep
{
    public partial class Booking : UserControl
    {
        BUS_Customer bus_cus = new BUS_Customer();
        BUS_Pet bus_pet = new BUS_Pet();
        BUS_Employee bus_emp = new BUS_Employee();
        BUS_Booking bus_boo = new BUS_Booking();

        public Booking()
        {
            InitializeComponent();
        }

        private void ResetValues()
        {
            cboCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhonenumber.Text = "";

            txtBookingID.Text = "";
            Date.Value.ToString("");
            cboVetID.Text = "";
            txtVetname.Text = "";

            cboPetID.Text = "";
            txtPetname.Text = "";
            txtAge.Text = "";
            txtPetGender.Text = "";
            txtPettype.Text = "";
            txtBreed.Text = "";
            txtColor.Text = "";
            txtWeight.Text = "";
            txtDistinction.Text = "";
        }

        private void ResetValues_Pet()
        {
            cboPetID.Text = "";
            txtPetname.Text = "";
            txtAge.Text = "";
            txtPetGender.Text = "";
            txtPettype.Text = "";
            txtBreed.Text = "";
            txtColor.Text = "";
            txtWeight.Text = "";
            txtDistinction.Text = "";
        }

        private void Load_cboCustomerID()
        {
            cboCustomerID.DataSource = bus_cus.Display_CustomerID();
            cboCustomerID.DisplayMember = "CUSTOMER_ID";
            cboCustomerID.ValueMember = "CUSTOMER_ID";
        }     

        private void Load_cboPetID()
        {
            cboPetID.DataSource = bus_pet.Display_PetID(cboCustomerID.Text);
            cboPetID.DisplayMember = "PET_ID";
            cboPetID.ValueMember = "PET_ID";
        }

        public void Load_cboVetID()
        {
            cboVetID.DataSource = bus_emp.Display_VetID(); // Khi mở Booking dữ liệu ID của các bác sĩ thú y sẽ được load vào Combobox
            cboVetID.DisplayMember = "EMPLOYEE_ID";
            cboVetID.ValueMember = "EMPLOYEE_ID";
        }

        private void LoadDatagridview()
        {
            dgvBooking.DataSource = bus_boo.Display_Booking();
        }

        public void LoadData()
        {
            Load_cboCustomerID();
            Load_cboVetID();
            LoadDatagridview();
            ResetValues();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(cboCustomerID.Text) == true)
            {
                MessageBox.Show("Please select Customer ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCustomerID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboPetID.Text) == true)
            {
                MessageBox.Show("Please select Pet ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPetID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBookingID.Text) == true)
            {
                MessageBox.Show("Please enter Booking ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookingID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(Date.Value.ToString()) == true)
            {
                MessageBox.Show("Please select Date appointment!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Date.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboVetID.Text) == true)
            {
                MessageBox.Show("Please select Vet ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboVetID.Focus();
                return false;
            }
            return true;
        }

        private void cboCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_cboPetID();
            var item = this.cboCustomerID.GetItemText(this.cboCustomerID.SelectedItem);
            try
            {
                txtCustomerName.Text = bus_cus.Display_Customer(item).Rows[0]["NAME"].ToString();
                Birthday.Value = DateTime.Parse(bus_cus.Display_Customer(item).Rows[0]["BIRTHDAY"].ToString());
                txtGender.Text = bus_cus.Display_Customer(item).Rows[0]["GENDER"].ToString();
                txtAddress.Text = bus_cus.Display_Customer(item).Rows[0]["ADDRESS"].ToString();
                txtEmail.Text = bus_cus.Display_Customer(item).Rows[0]["EMAIL"].ToString();
                txtPhonenumber.Text = bus_cus.Display_Customer(item).Rows[0]["PHONE_NUMBER"].ToString();
                ResetValues_Pet();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cboPetID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.cboPetID.GetItemText(this.cboPetID.SelectedItem);
            try
            {
                txtPetname.Text = bus_pet.Display_Pet(item).Rows[0]["NAME"].ToString();
                txtAge.Text = bus_pet.Display_Pet(item).Rows[0]["AGE"].ToString();
                txtPetGender.Text = bus_pet.Display_Pet(item).Rows[0]["GENDER"].ToString();
                txtPettype.Text = bus_pet.Display_Pet(item).Rows[0]["PET_TYPE"].ToString();
                txtBreed.Text = bus_pet.Display_Pet(item).Rows[0]["BREED"].ToString();
                txtColor.Text = bus_pet.Display_Pet(item).Rows[0]["COLOR"].ToString();
                txtWeight.Text = bus_pet.Display_Pet(item).Rows[0]["WEIGHT"].ToString();
                txtDistinction.Text = bus_pet.Display_Pet(item).Rows[0]["DISTINCTION"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cboVetID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVetname.Text = bus_emp.Display_VetName(cboVetID.Text).Rows[0]["NAME"].ToString();
        }

        private bool Check_BookingIDExist()
        {
            for (int i = 0; i < (dgvBooking.Rows.Count) - 1; i++)
            {
                if (txtBookingID.Text.Equals(dgvBooking.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (Check_BookingIDExist() == true)
                {
                    DTO_Booking dto_boo = new DTO_Booking(txtBookingID.Text, cboCustomerID.Text, cboPetID.Text, Date.Value.ToString(), cboVetID.Text);
                    if (bus_boo.Add(dto_boo))
                    {
                        MessageBox.Show("SAVING SUCCESS!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridview();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("SAVING FAIL!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("'" + txtBookingID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                DTO_Booking dto_boo = new DTO_Booking(txtBookingID.Text, cboCustomerID.Text, cboPetID.Text, Date.Value.ToString(), cboVetID.Text);
                if (bus_boo.Edit(dto_boo))
                {
                    MessageBox.Show("Edit Success!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridview();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Edit Fail!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(txtBookingID.Text) != true)
                {
                    if (bus_boo.Delete(txtBookingID.Text))
                    {
                        MessageBox.Show("DELETE SUCCESS!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridview();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("DELETE FAIL!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Booking ID in Booking ID box!", "NOTIFICATON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvBooking_SelectionChanged(object sender, EventArgs e)
        {
            txtBookingID.Text = dgvBooking.CurrentRow.Cells[0].Value.ToString();
            cboCustomerID.Text = dgvBooking.CurrentRow.Cells[1].Value.ToString();
            txtCustomerName.Text = dgvBooking.CurrentRow.Cells[2].Value.ToString();
            cboPetID.Text = dgvBooking.CurrentRow.Cells[3].Value.ToString();
            txtPettype.Text = dgvBooking.CurrentRow.Cells[4].Value.ToString();
            Date.Value = DateTime.Parse(dgvBooking.CurrentRow.Cells[5].Value.ToString());
            txtVetname.Text = dgvBooking.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBookingID.Text) == true)
            {
                MessageBox.Show("Please enter the Booking ID or Customer name to search!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchBookingID.Focus();
            }
            else
            {               
                dgvBooking.DataSource = bus_boo.Search_Booking(txtSearchBookingID.Text, txtSearchBookingID.Text);
                ResetValues();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearchBookingID.Text = "";
            LoadDatagridview();
            ResetValues();
        }
    }
}
