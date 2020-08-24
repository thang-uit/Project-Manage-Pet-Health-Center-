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

namespace Manage_Pet_Health_Center.Function_Manager
{
    public partial class Employee : UserControl
    {
        BUS_Employee bus_emp = new BUS_Employee();

        public Employee()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvEmployee.DataSource = bus_emp.Display_Employee();
            lblAmountEmployee.Text = Convert.ToString(dgvEmployee.Rows.Count - 1);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }      

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) == true)
            {
                MessageBox.Show("Please enter Employee ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmployeeID.Focus();
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
            if (string.IsNullOrWhiteSpace(txtTitle.Text) == true)
            {
                MessageBox.Show("Please enter Title!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSalary.Text) == true)
            {
                MessageBox.Show("Please enter Salary!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSalary.Focus();
                return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtEmployeeID.Text = "";
            txtName.Text = "";
            Birthday.Value.ToShortDateString();
            txtGender.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "@";
            txtPhonenumber.Text = "0";
            txtTitle.Text = "";
            txtSalary.Text = "000000";           
        }

        private bool Check_EmployeeIDExist()
        {
            for (int i = 0; i < (dgvEmployee.Rows.Count) - 1; i++)
            {
                if (txtEmployeeID.Text.Equals(dgvEmployee.Rows[i].Cells[0].Value.ToString()) == true)
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
                if (Check_EmployeeIDExist() == true)
                {
                    DTO_Employee dto_emp = new DTO_Employee(txtEmployeeID.Text, txtName.Text, Birthday.Value.ToShortDateString(), txtGender.Text, txtAddress.Text, txtEmail.Text, txtPhonenumber.Text, txtTitle.Text, long.Parse(txtSalary.Text));
                    if (bus_emp.Add(dto_emp))
                    {
                        MessageBox.Show("ADDING SUCCESS!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("ADDING FAIL!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("'    " + txtEmployeeID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                DTO_Employee dto_emp = new DTO_Employee(txtEmployeeID.Text, txtName.Text, Birthday.Value.ToShortDateString(), txtGender.Text, txtAddress.Text, txtEmail.Text, txtPhonenumber.Text, txtTitle.Text, long.Parse(txtSalary.Text));
                if (bus_emp.Edit(dto_emp))
                {
                    MessageBox.Show("EDIT SUCCESS!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("EDIT FAIL!", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) != true)
                {
                    if (bus_emp.Delete(txtEmployeeID.Text))
                    {
                        MessageBox.Show("DELETING SUCCESS!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("DELETING FAIL!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Employee ID you want to delete in the Employee ID box!");
                    txtEmployeeID.Focus();
                }
            }//Kết thúc thao tác xóa
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text) == true)
            {
                MessageBox.Show("Please enter the Employee ID or Name to search!", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvEmployee.DataSource = bus_emp.Search(txtSearch.Text, txtSearch.Text);
                ResetValues();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
            ResetValues();
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            txtEmployeeID.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            Birthday.Value = DateTime.Parse(dgvEmployee.CurrentRow.Cells[2].Value.ToString());
            txtGender.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            txtPhonenumber.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();
            txtTitle.Text = dgvEmployee.CurrentRow.Cells[7].Value.ToString();
            txtSalary.Text = dgvEmployee.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
