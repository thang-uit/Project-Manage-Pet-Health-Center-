using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public class DTO_Account : DBConnection
    {
        private string EMPLOYEE_ID;
        private string USERNAME;
        private string PASSWORD;
        private string ROLE;

        public string _EMPLOYEE_ID { get => EMPLOYEE_ID; set => EMPLOYEE_ID = value; }
        public string _USERNAME { get => USERNAME; set => USERNAME = value; }
        public string _PASSWORD { get => PASSWORD; set => PASSWORD = value; }
        public string _ROLE { get => ROLE; set => ROLE = value; }

        public DTO_Account()
        {
        }

        public DTO_Account(string EMPLOYEE_ID, string USERNAME, string PASSWORD, string ROLE)
        {
            this.EMPLOYEE_ID = EMPLOYEE_ID;
            this.USERNAME = USERNAME;
            this.PASSWORD = PASSWORD;
            this.ROLE = ROLE;
        }

        public DataTable Get_Role(string Username, string Password)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select ROLE From ACCOUNT Where USERNAME = '{0}' And PASSWORD = '{1}'", Username, Password);
            try
            {
                con.Open();                
                SqlCommand cmd = new SqlCommand(SQL, con);               
                adt.SelectCommand = cmd;
                adt.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable Display_RecID(string Username, string Password)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select EMPLOYEE_ID From ACCOUNT Where USERNAME = '{0}' And PASSWORD = '{1}'", Username, Password);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}
