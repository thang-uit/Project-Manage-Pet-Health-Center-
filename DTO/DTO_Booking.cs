using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Booking : DBConnection
    {
        private string BOOKING_ID;
        private string CUSTOMER_ID;
        private string PET_ID;
        private string DATE;
        private string VET_ID;

        public string _BOOKING_ID { get => BOOKING_ID; set => BOOKING_ID = value; }
        public string _CUSTOMER_ID { get => CUSTOMER_ID; set => CUSTOMER_ID = value; }
        public string _PET_ID { get => PET_ID; set => PET_ID = value; }
        public string _DATE { get => DATE; set => DATE = value; }
        public string _VET_ID { get => VET_ID; set => VET_ID = value; }


        public DTO_Booking()
        {
        }

        public DTO_Booking(string BOOKING_ID, string CUSTOMER_ID, string PET_ID, string DATE, string VET_ID)
        {
            this.BOOKING_ID = BOOKING_ID;
            this.CUSTOMER_ID = CUSTOMER_ID;
            this.PET_ID = PET_ID;
            this.DATE = DATE;
            this.VET_ID = VET_ID;
        }

        public DataTable Display_Booking()
        {
            DataTable tblBooking = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select BOOKING_ID, B.CUSTOMER_ID, C.NAME AS CUSTOMER, B.PET_ID, P.PET_TYPE, B.DATE, E.NAME AS VET From BOOKING B, CUSTOMER C, PET P, EMPLOYEE E Where B.CUSTOMER_ID = C.CUSTOMER_ID And B.PET_ID = P.PET_ID And B.VET_ID = E.EMPLOYEE_ID And E.TITLE = 'Vet'");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblBooking);  //Fill vào bảng DataTable tblBooking
                return tblBooking;
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

        public DataTable Display_BookingID()
        {
            DataTable tblBooking = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select BOOKING_ID From BOOKING Where BOOKING_ID In (Select BOOKING_ID From BOOKING Except Select BOOKING_ID From ORDERS)");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblBooking);  //Fill vào bảng DataTable tblBooking
                return tblBooking;
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

        public DataTable Display_InfoBooking(string ID) // Hiển thị những thông tin ở Booking vào phần payment
        {
            DataTable tblBooking = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select B.CUSTOMER_ID, C.GENDER, C.NAME AS CUSTOMER, B.PET_ID, P.PET_TYPE, P.NAME, E.NAME AS VET  From BOOKING B, CUSTOMER C, PET P, EMPLOYEE E  Where B.CUSTOMER_ID = C.CUSTOMER_ID And B.PET_ID = P.PET_ID And B.VET_ID = E.EMPLOYEE_ID And E.TITLE = 'Vet' And BOOKING_ID = '{0}'", ID);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblBooking);  //Fill vào bảng DataTable tblBooking
                return tblBooking;
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
                string SQL = string.Format("Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID) Values ('{0}','{1}','{2}','{3}','{4}')", this._BOOKING_ID, this._CUSTOMER_ID, this._PET_ID, this._DATE, this._VET_ID);

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

                string SQL = string.Format("Update BOOKING Set CUSTOMER_ID = '{1}', PET_ID = '{2}', DATE = '{3}', VET_ID = '{4}' Where BOOKING_ID = '{0}'", this._BOOKING_ID, this._CUSTOMER_ID, this._PET_ID, this._DATE, this._VET_ID);

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
                string SQL = string.Format("Delete From BOOKING Where BOOKING_ID = '{0}'", ID);

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

        public DataTable Search_Booking(string ID, string Name)
        {
            DataTable tblBooking = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select BOOKING_ID, B.CUSTOMER_ID, C.NAME AS CUSTOMER, B.PET_ID, P.PET_TYPE, B.DATE, E.NAME AS VET From BOOKING B, CUSTOMER C, PET P, EMPLOYEE E Where B.CUSTOMER_ID = C.CUSTOMER_ID And B.PET_ID = P.PET_ID And B.VET_ID = E.EMPLOYEE_ID And E.TITLE = 'Vet' And (BOOKING_ID = '{0}' OR C.NAME = N'{1}')", ID, Name);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblBooking);  //Fill vào bảng DataTable tblBooking
                return tblBooking;
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
