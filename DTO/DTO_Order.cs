using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Order : DBConnection
    {
        private string ORDER_ID;
        private string BOOKING_ID;
        private string CUSTOMER_ID;
        private string VET;
        private string PET_ID;
        private string EMPLOYEE_ID;
        private string ORDER_DATE;
        private long TOTAL_PRICE;

        public string _ORDER_ID { get => ORDER_ID; set => ORDER_ID = value; }
        public string _BOOKING_ID { get => BOOKING_ID; set => BOOKING_ID = value; }
        public string _CUSTOMER_ID { get => CUSTOMER_ID; set => CUSTOMER_ID = value; }
        public string _VET { get => VET; set => VET = value; }
        public string _PET_ID { get => PET_ID; set => PET_ID = value; }
        public string _EMPLOYEE_ID { get => EMPLOYEE_ID; set => EMPLOYEE_ID = value; }
        public string _ORDER_DATE { get => ORDER_DATE; set => ORDER_DATE = value; }
        public long _TOTAL_PRICE { get => TOTAL_PRICE; set => TOTAL_PRICE = value; }


        public DTO_Order()
        {
        }

        public DTO_Order(string ORDER_ID, string BOOKING_ID, string CUSTOMER_ID, string VET, string PET_ID, string EMPLOYEE_ID, string ORDER_DATE, long TOTAL_PRICE)
        {
            this.ORDER_ID = ORDER_ID;
            this.BOOKING_ID = BOOKING_ID;
            this.CUSTOMER_ID = CUSTOMER_ID;
            this.VET = VET;
            this.PET_ID = PET_ID;
            this.EMPLOYEE_ID = EMPLOYEE_ID;
            this.ORDER_DATE = ORDER_DATE;
            this.TOTAL_PRICE = TOTAL_PRICE;
        }

        public bool Save()
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE) Values ('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}')", this._ORDER_ID, this._BOOKING_ID, this._CUSTOMER_ID, this._VET, this._PET_ID, this._EMPLOYEE_ID, this._ORDER_DATE, this._TOTAL_PRICE);

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

        public DataTable Display_Order()
        {
            DataTable tblOrder = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select O.ORDER_ID, O.BOOKING_ID, O.EMPLOYEE_ID, E.NAME As CASHIER, O.CUSTOMER_ID, C.NAME As CUSTOMER, O.VET, O.PET_ID, P.PET_TYPE, P.NAME As PET, O.ORDER_DATE, O.TOTAL_PRICE From ORDERS O, EMPLOYEE E, CUSTOMER C, PET P Where O.EMPLOYEE_ID = E.EMPLOYEE_ID And O.CUSTOMER_ID = C.CUSTOMER_ID And O.PET_ID = P.PET_ID");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblOrder);  //Fill vào bảng DataTable 
                return tblOrder;
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

        public DataTable Display_SearchOrder(string Order_ID) // Receptionist
        {
            DataTable tblSearch = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select O.ORDER_ID, O.BOOKING_ID, O.EMPLOYEE_ID, E.NAME As CASHIER, O.CUSTOMER_ID, C.NAME As CUSTOMER, O.VET, O.PET_ID, P.PET_TYPE, P.NAME As PET, O.ORDER_DATE, O.TOTAL_PRICE From ORDERS O, EMPLOYEE E, CUSTOMER C, PET P Where O.EMPLOYEE_ID = E.EMPLOYEE_ID And O.CUSTOMER_ID = C.CUSTOMER_ID And O.PET_ID = P.PET_ID And O.ORDER_ID = '{0}'", Order_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblSearch);  //Fill vào bảng DataTable 
                return tblSearch;
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

        public DataTable Display_AllOrder() // Manager
        {
            DataTable tblAllOrder = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select O.ORDER_ID, O.BOOKING_ID, E.NAME As CASHIER, O.CUSTOMER_ID, C.NAME As CUSTOMER, O.VET, O.PET_ID, P.PET_TYPE, O.ORDER_DATE, O.TOTAL_PRICE  FROM ORDERS O JOIN EMPLOYEE E ON O.EMPLOYEE_ID = E.EMPLOYEE_ID JOIN CUSTOMER C ON O.CUSTOMER_ID = C.CUSTOMER_ID JOIN PET P ON O.PET_ID = P.PET_ID");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblAllOrder);  //Fill vào bảng DataTable 
                return tblAllOrder;
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

        public DataTable Display_FillOrder(string Month, string Year) // Manager
        {
            DataTable tblFillOrder = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select O.ORDER_ID, O.BOOKING_ID, E.NAME As CASHIER, O.CUSTOMER_ID, C.NAME As CUSTOMER, O.VET, O.PET_ID, P.PET_TYPE, O.ORDER_DATE, O.TOTAL_PRICE  FROM ORDERS O JOIN EMPLOYEE E ON O.EMPLOYEE_ID = E.EMPLOYEE_ID JOIN CUSTOMER C ON O.CUSTOMER_ID = C.CUSTOMER_ID JOIN PET P ON O.PET_ID = P.PET_ID Where MONTH(O.ORDER_DATE) = '{0}' And YEAR(O.ORDER_DATE) = '{1}'", Month, Year);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblFillOrder);  //Fill vào bảng DataTable
                return tblFillOrder;
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
