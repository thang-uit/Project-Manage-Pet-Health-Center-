using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Manage_Pet_Health_Center.Function_Recep
{
    public partial class Pet : Form
    {
        public string Customer_ID; // Lấy ID của Form Customer khi Double click
        BUS_Pet bus_pet = new BUS_Pet();
        BUS_Customer bus_cus = new BUS_Customer();

        public Pet()
        {
            InitializeComponent();
        }

        public void LoadData_cboCustomerID()
        {
            cboCustomerID.DataSource = bus_cus.Display_CustomerID();
            cboCustomerID.DisplayMember = "CUSTOMER_ID";
            cboCustomerID.ValueMember = "CUSTOMER_ID";
            cboCustomerID.Text = Customer_ID;  
        }

        public void LoadDataPet()
        {
            dgvPet.DataSource = bus_pet.Display(Customer_ID);
        }

        private void Pet_Load(object sender, EventArgs e)
        {
            this.pETTableAdapter.Fill(this.mANAGE_PET_HEALTH_CENTERDataSet2.PET);
            LoadData_cboCustomerID();
            LoadDataPet();
        }

        private bool CheckData()
        {
            if(string.IsNullOrWhiteSpace(cboCustomerID.Text) == true)
            {
                MessageBox.Show("Please enter Customer ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCustomerID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPetID.Text) == true)
            {
                MessageBox.Show("Please enter Pet ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPetID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                MessageBox.Show("Please enter Name!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAge.Text) == true)
            {
                MessageBox.Show("Please enter Age!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGender.Text) == true)
            {
                MessageBox.Show("Please enter Gender!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGender.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPettype.Text) == true)
            {
                MessageBox.Show("Please enter Pet type!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPettype.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBreed.Text) == true)
            {
                MessageBox.Show("Please enter Breed!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBreed.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColor.Text) == true)
            {
                MessageBox.Show("Please enter Color!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColor.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtWeight.Text) == true)
            {
                MessageBox.Show("Please enter Weight!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeight.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDistinction.Text) == true)
            {
                MessageBox.Show("Please enter Distinction!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistinction.Focus();
                return false;
            }
            return true;
        }

        private void ResetValue()
        {
            txtPetID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtPettype.Text = "";
            txtBreed.Text = "";
            txtColor.Text = "";
            txtWeight.Text = "";
            txtDistinction.Text = "";
        }

        private void cboCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomername.Text = bus_pet.Display_CustomerName(cboCustomerID.Text).Rows[0]["NAME"].ToString();
            dgvPet.DataSource = bus_pet.Display(cboCustomerID.Text);
            ResetValue();
        }

        private bool Check_PetIDtExist()
        {
            for (int i = 0; i < (dgvPet.Rows.Count) - 1; i++)
            {
                if (txtPetID.Text.Equals(dgvPet.Rows[i].Cells[1].Value.ToString()) == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckData() == true)
            {
                if (Check_PetIDtExist() == true)
                {
                    DTO_Pet dto_pet = new DTO_Pet(txtPetID.Text, cboCustomerID.Text, txtName.Text, txtAge.Text, txtGender.Text, txtPettype.Text, txtBreed.Text, txtColor.Text, float.Parse(txtWeight.Text), txtDistinction.Text);
                    if (bus_pet.Add(dto_pet))
                    {
                        MessageBox.Show("ADDING SUCCESS!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPet.DataSource = bus_pet.Display(cboCustomerID.Text);
                        ResetValue();
                    }
                    else
                    {
                        MessageBox.Show("ADDING FAIL!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("'    " + txtPetID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                DTO_Pet dto_pet = new DTO_Pet(txtPetID.Text, cboCustomerID.Text, txtName.Text, txtAge.Text, txtGender.Text, txtPettype.Text, txtBreed.Text, txtColor.Text, float.Parse(txtWeight.Text), txtDistinction.Text);
                if (bus_pet.Edit(dto_pet))
                {
                    MessageBox.Show("EDITING SUCCESS!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPet.DataSource = bus_pet.Display(cboCustomerID.Text);
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("EDITING FAIL!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Pet", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(txtPetID.Text) != true)
                {
                    if (bus_pet.Delete(txtPetID.Text))
                    {
                        MessageBox.Show("DELETING SUCCESS!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPet.DataSource = bus_pet.Display(cboCustomerID.Text);
                        ResetValue();
                    }
                    else
                    {
                        MessageBox.Show("DELETING FAIL!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Pet ID you want to delete in the Pet ID box!");
                    txtPetID.Focus();
                }
            }//Kết thúc thao tác xóa
        }

        private void dgvPet_SelectionChanged(object sender, EventArgs e)
        {
            txtPetID.Text = dgvPet.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvPet.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = dgvPet.CurrentRow.Cells[3].Value.ToString();
            txtGender.Text = dgvPet.CurrentRow.Cells[4].Value.ToString();
            txtPettype.Text = dgvPet.CurrentRow.Cells[5].Value.ToString();
            txtBreed.Text = dgvPet.CurrentRow.Cells[6].Value.ToString();
            txtColor.Text = dgvPet.CurrentRow.Cells[7].Value.ToString();
            txtWeight.Text = dgvPet.CurrentRow.Cells[8].Value.ToString();
            txtDistinction.Text = dgvPet.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text) == true)
            {
                MessageBox.Show("Please enter the Pet ID, Pet type or Name to search!", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
            }
            else
            {
                dgvPet.DataSource = bus_pet.Search(cboCustomerID.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
                ResetValue();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dgvPet.DataSource = bus_pet.Display(cboCustomerID.Text);
            ResetValue();
        }
    }
}
