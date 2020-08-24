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
    public partial class Product : UserControl
    {
        BUS_Product bus_pro = new BUS_Product();

        public Product()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvProduct.DataSource = bus_pro.Display();
            lblAmount.Text = Convert.ToString(dgvProduct.Rows.Count - 1);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) == true)
            {
                MessageBox.Show("Please enter Product ID!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductType.Text) == true)
            {
                MessageBox.Show("Please enter Product type!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductType.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                MessageBox.Show("Please enter Name!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSupplier.Text) == true)
            {
                MessageBox.Show("Please enter Supplier!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplier.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNation.Text) == true)
            {
                MessageBox.Show("Please enter Nation!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNation.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) == true)
            {
                MessageBox.Show("Please enter Price!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Focus();
                return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtProductID.Text = "";
            txtProductType.Text = "";
            txtName.Text = "";
            txtSupplier.Text = "";
            txtNation.Text = "";
            txtPrice.Text = "";           
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            txtProductID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductType.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtSupplier.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString(); 
            txtNation.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private bool Check_ProductIDExist()
        {
            for (int i = 0; i < (dgvProduct.Rows.Count) - 1; i++)
            {
                if (txtProductID.Text.Equals(dgvProduct.Rows[i].Cells[0].Value.ToString()) == true)
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
                if (Check_ProductIDExist() == true)
                {
                    DTO_Product dto_pro = new DTO_Product(txtProductID.Text, txtProductType.Text, txtName.Text, txtSupplier.Text, txtNation.Text, long.Parse(txtPrice.Text));
                    if (bus_pro.Add(dto_pro))
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
                    MessageBox.Show("'    " + txtProductID.Text + "' already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                DTO_Product dto_pro = new DTO_Product(txtProductID.Text, txtProductType.Text, txtName.Text, txtSupplier.Text, txtNation.Text, long.Parse(txtPrice.Text));
                if (bus_pro.Edit(dto_pro))
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
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (blresult == 1)
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) != true)
                {
                    if (bus_pro.Delete(txtProductID.Text))
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
                    MessageBox.Show("Please enter the Product ID you want to delete in the Product ID box!");
                    txtProductID.Focus();
                }
            }//Kết thúc thao tác xóa
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) == true)
            {
                MessageBox.Show("Please enter the Product ID, Product type or Name to search!", "SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvProduct.DataSource = bus_pro.Search(txtSearch.Text, txtSearch.Text, txtSearch.Text);
                ResetValues();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
            ResetValues();
        }
    }
}

