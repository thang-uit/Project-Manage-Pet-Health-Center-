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
using Manage_Pet_Health_Center.Function_Receptionist;
using System.Data.SqlClient;

namespace Manage_Pet_Health_Center.Function_Recep
{
    public partial class Customer : UserControl
    {
        BUS_Customer bus_cus = new BUS_Customer();

        public Customer()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvCustomer.DataSource = bus_cus.Display();
            lblAmountCustomer.Text = Convert.ToString(dgvCustomer.Rows.Count - 1);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) == true)
            {
                MessageBox.Show("Please enter Customer ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                MessageBox.Show("Please enter Name!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGender.Text) == true)
            {
                MessageBox.Show("Please enter Gender!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGender.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text) == true)
            {
                MessageBox.Show("Please enter Address!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) == true)
            {
                MessageBox.Show("Please enter Email!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhonenumber.Text) == true)
            {
                MessageBox.Show("Please enter Phone number!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhonenumber.Focus();
                return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            Birthday.Value.ToShortDateString();
            txtGender.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "@";
            txtPhonenumber.Text = "0";
        }

        private bool Check_CustomerIDtExist()
        {
            for (int i = 0; i < (dgvCustomer.Rows.Count) - 1; i++)
            {
                if (txtCustomerID.Text.Equals(dgvCustomer.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (Check_CustomerIDtExist() == true)
                {
                    DTO_Customer dto_cus = new DTO_Customer(txtCustomerID.Text, txtName.Text, Birthday.Value.ToShortDateString(), txtGender.Text, txtAddress.Text, txtEmail.Text, txtPhonenumber.Text);
                    if (bus_cus.Add(dto_cus))
                    {
                        MessageBox.Show("ADDING SUCCESS!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("ADDING FAIL!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("'    " + txtCustomerID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                DTO_Customer dto_cus = new DTO_Customer(txtCustomerID.Text, txtName.Text, Birthday.Value.ToShortDateString(), txtGender.Text, txtAddress.Text, txtEmail.Text, txtPhonenumber.Text);
                if (bus_cus.Edit(dto_cus))
                {
                    MessageBox.Show("EDITING SUCCESS!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
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
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text) != true)
                {
                    if (bus_cus.Delete(txtCustomerID.Text))
                    {
                        MessageBox.Show("DELETING SUCCESS", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("DELETING FAIL", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Customer ID you want to delete in the Customer ID box!");
                    txtCustomerID.Focus();
                }
            }//Kết thúc thao tác xóa
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) == true)
            {
                MessageBox.Show("Please enter the Customer ID or Name to search!", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
            }
            else
            {
                dgvCustomer.DataSource = bus_cus.Search(txtSearch.Text, txtSearch.Text);
                ResetValues();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = bus_cus.Best_Search(txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
            ResetValues();
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            Birthday.Value = DateTime.Parse(dgvCustomer.CurrentRow.Cells[2].Value.ToString());
            txtGender.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtPhonenumber.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Customer_ID = txtCustomerID.Text;
            pet.ShowDialog();
        }
    }
}
