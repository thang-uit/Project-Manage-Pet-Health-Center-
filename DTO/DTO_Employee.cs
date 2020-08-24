using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public class DTO_Employee : DBConnection
    {
        private string EMPLOYEE_ID;
        private string NAME;
        private string BIRTHDAY;
        private string GENDER;
        private string ADDRESS;
        private string EMAIL;
        private string PHONE_NUMBER;
        private string TITLE;
        private long SALARY;

        public string _EMPLOYEE_ID { get => EMPLOYEE_ID; set => EMPLOYEE_ID = value; }
        public string _NAME { get => NAME; set => NAME = value; }
        public string _BIRTHDAY { get => BIRTHDAY; set => BIRTHDAY = value; }
        public string _GENDER { get => GENDER; set => GENDER = value; }
        public string _ADDRESS { get => ADDRESS; set => ADDRESS = value; }
        public string _EMAIL { get => EMAIL; set => EMAIL = value; }
        public string _PHONE_NUMBER { get => PHONE_NUMBER; set => PHONE_NUMBER = value; }
        public string _TITLE { get => TITLE; set => TITLE = value; }
        public long _SALARY { get => SALARY; set => SALARY = value; }

        public DTO_Employee()
        {
        }

        public DTO_Employee(string EMPLOYEE_ID, string NAME, string BIRTHDAY, string GENDER, string ADDRESS, string EMAIL, string PHONE_NUMBER, string TITLE, long SALARY)
        {
            this.EMPLOYEE_ID = EMPLOYEE_ID;
            this.NAME = NAME;
            this.BIRTHDAY = BIRTHDAY;
            this.GENDER = GENDER;
            this.ADDRESS = ADDRESS;
            this.EMAIL = EMAIL;
            this.PHONE_NUMBER = PHONE_NUMBER;
            this.TITLE = TITLE;
            this.SALARY = SALARY;
        }

        public DataTable Display_Employee()
        {
            DataTable tblEmployee = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = "Select * From EMPLOYEE";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblEmployee);  //Fill vào bảng DataTable 
                return tblEmployee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public bool Add()
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY) Values ('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}',N'{7}','{8}')", this._EMPLOYEE_ID, this._NAME, this._BIRTHDAY, this._GENDER, this._ADDRESS, this._EMAIL, this._PHONE_NUMBER, this._TITLE, this._SALARY);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool Edit()
        {
            try
            {
                con.Open();

                string SQL = string.Format("Update EMPLOYEE Set NAME = N'{1}', BIRTHDAY = '{2}', GENDER = N'{3}', ADDRESS = N'{4}', EMAIL = '{5}', PHONE_NUMBER = '{6}', TITLE = N'{7}', SALARY = '{8}' Where EMPLOYEE_ID = '{0}'", this._EMPLOYEE_ID, this._NAME, this._BIRTHDAY, this._GENDER, this._ADDRESS, this._EMAIL, this._PHONE_NUMBER, this._TITLE, this._SALARY);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool Delete(string ID)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Delete From EMPLOYEE Where EMPLOYEE_ID = '{0}'", ID);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public DataTable Search(string ID, string Name)
        {
            DataTable tblEmployee = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select * From EMPLOYEE Where EMPLOYEE_ID = '{0}' OR NAME = N'{1}'", ID, Name);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblEmployee);  //Fill vào bảng tblEmployee
                return tblEmployee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable Display_VetID()
        {
            DataTable tblComboboxVet = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = "Select EMPLOYEE_ID From EMPLOYEE Where TITLE = 'Vet'";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblComboboxVet);  //Fill vào bảng DataTable 
                return tblComboboxVet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable Display_VetName(string VET_ID)
        {
            DataTable txtVetName = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select NAME From EMPLOYEE Where EMPLOYEE_ID ='{0}'", VET_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(txtVetName);  //Fill vào bảng DataTable 
                return txtVetName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable Display_ReceptionistName(string REC_ID)
        {
            DataTable txtEmpName = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select NAME From EMPLOYEE Where EMPLOYEE_ID ='{0}'", REC_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(txtEmpName);  //Fill vào bảng DataTable 
                return txtEmpName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}
