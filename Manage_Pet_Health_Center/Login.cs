using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Manage_Pet_Health_Center.Function_Recep;

namespace Manage_Pet_Health_Center
{
    public partial class Login : Form
    {
        BUS_Account bus_acc = new BUS_Account();

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            pnlConcho.Visible = false;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            pnlConcho.Visible = true;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if(lblShowpassword.Text.Equals(""))
            {
                // Hide password
                txtPassword.UseSystemPasswordChar = true;
                lblShowpassword.Text = " ";
                
            }
            else
            {
                // Show password
                txtPassword.UseSystemPasswordChar = false;
                lblShowpassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Receptionsit (Username/Password): (Thang_UIT / t) hoặc (hongthuy / t)
            // Manager (Username/Password): (Nghia_UIT / n)
            string Username = this.txtUsername.Text; 
            string Password = this.txtPassword.Text;
            if(string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                MessageBox.Show("Please enter your full username and password!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (bus_acc.Get_Role(Username, Password).Rows[0][0].ToString().Equals("Receptionist"))
                    {
                        MessageBox.Show("Hello Receptionist!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable RecID = bus_acc.Display_RecID(Username, Password);
                        Receptionist_Screen Receptionist = new Receptionist_Screen(RecID);
                        this.Hide();
                        Receptionist.ShowDialog();
                        this.Show();
                    }
                    else if (bus_acc.Get_Role(Username, Password).Rows[0][0].ToString().Equals("Manager"))
                    {
                        MessageBox.Show("Hello my Boss!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Manager_Screen Manager = new Manager_Screen();
                        this.Hide();
                        Manager.ShowDialog();
                        this.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Username or Password not correct! Please enter again.", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
