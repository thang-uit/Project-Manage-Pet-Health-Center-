using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_Customer : DBConnection
    {
        private string CUSTOMER_ID;
        private string NAME;
        private string BIRTHDAY;
        private string GENDER;
        private string ADDRESS;
        private string EMAIL;
        private string PHONE_NUMBER;

        public string _CUSTOMER_ID { get => CUSTOMER_ID; set => CUSTOMER_ID = value; }
        public string _NAME { get => NAME; set => NAME = value; }
        public string _BIRTHDAY { get => BIRTHDAY; set => BIRTHDAY = value; }
        public string _GENDER { get => GENDER; set => GENDER = value; }
        public string _ADDRESS { get => ADDRESS; set => ADDRESS = value; }
        public string _EMAIL { get => EMAIL; set => EMAIL = value; }
        public string _PHONE_NUMBER { get => PHONE_NUMBER; set => PHONE_NUMBER = value; }

        public DTO_Customer()
        {
        }

        public DTO_Customer(string CUSTOMER_ID, string NAME, string BIRTHDAY, string GENDER, string ADDRESS, string EMAIL, string PHONE_NUMBER)
        {
            this.CUSTOMER_ID = CUSTOMER_ID;
            this.NAME = NAME;
            this.BIRTHDAY = BIRTHDAY;
            this.GENDER = GENDER;
            this.ADDRESS = ADDRESS;
            this.EMAIL = EMAIL;
            this.PHONE_NUMBER = PHONE_NUMBER;
        }

        public DataTable Display()
        {
            DataTable tblCustomer = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = "Select * From CUSTOMER";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblCustomer);  //Fill vào bảng DataTable tblCustomer
                return tblCustomer;
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
                string SQL = string.Format("Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER) Values ('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}')", this._CUSTOMER_ID, this._NAME, this._BIRTHDAY, this._GENDER, this._ADDRESS, this._EMAIL, this._PHONE_NUMBER);

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

                string SQL = string.Format("Update CUSTOMER Set NAME = N'{1}', BIRTHDAY = '{2}', GENDER = N'{3}', ADDRESS = N'{4}', EMAIL = '{5}', PHONE_NUMBER = '{6}' Where CUSTOMER_ID = '{0}'", this._CUSTOMER_ID, this._NAME, this._BIRTHDAY, this._GENDER, this._ADDRESS, this._EMAIL, this._PHONE_NUMBER);

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
                string SQL = string.Format("Delete From CUSTOMER Where CUSTOMER_ID = '{0}'", ID);

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
            DataTable tblCustomer = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select * From CUSTOMER Where CUSTOMER_ID = '{0}' OR NAME = N'{1}'", ID, Name);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblCustomer);  //Fill vào bảng tblCustomer
                return tblCustomer;
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

        public DataTable Best_Search(string ID, string Name, string Birthday, string Gender, string Address, string Email, string Phone)
        {
            DataTable tblbestsearch= new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select * From CUSTOMER Where CUSTOMER_ID Like '%{0}%' Or NAME Like N'%{1}%' Or BIRTHDAY Like '%{2}%' Or GENDER Like N'%{3}%' Or ADDRESS Like N'%{4}%' Or EMAIL Like '%{5}%' Or PHONE_NUMBER Like '%{6}%'", ID, Name, Birthday, Gender, Address, Email, Phone);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblbestsearch);  //Fill vào bảng 
                return tblbestsearch;
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

        public DataTable Display_CustomerID()
        {
            DataTable tblComboboxCusID = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = "Select CUSTOMER_ID From CUSTOMER";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblComboboxCusID);  //Fill vào bảng DataTable 
                return tblComboboxCusID;
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

        public DataTable Display_Customer(string CUS_ID) // Hiển thị toàn bộ thông tin khách hàng sau khi chọn Mã khách hàng ở combobox (Booking)
        {
            DataTable txtCustomer = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select * From CUSTOMER Where CUSTOMER_ID = '{0}'", CUS_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(txtCustomer);  //Fill vào bảng DataTable 
                return txtCustomer;
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
