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
    public class DTO_OrderDetail : DBConnection
    {
        private string ORDER_ID;
        private string PRODUCT_NO;
        private int AMOUNT_OF_PRODUCT;
        private long TOTAL_AMOUNT;

        public string _ORDER_ID { get => ORDER_ID; set => ORDER_ID = value; }
        public string _PRODUCT_NO { get => PRODUCT_NO; set => PRODUCT_NO = value; }
        public int _AMOUNT_OF_PRODUCT { get => AMOUNT_OF_PRODUCT; set => AMOUNT_OF_PRODUCT = value; }
        public long _TOTAL_AMOUNT { get => TOTAL_AMOUNT; set => TOTAL_AMOUNT = value; }

        public DTO_OrderDetail()
        {
        }

        public DTO_OrderDetail(string ORDER_ID, string PRODUCT_NO, int AMOUNT_OF_PRODUCT, long TOTAL_AMOUNT)
        {
            this.ORDER_ID = ORDER_ID;
            this.PRODUCT_NO = PRODUCT_NO;
            this.AMOUNT_OF_PRODUCT = AMOUNT_OF_PRODUCT;
            this.TOTAL_AMOUNT = TOTAL_AMOUNT;
        }

        public DataTable Display_ORDERDETAIL(string ORDER_ID)
        {
            DataTable tbl_showOrderDetail = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select ORDD.ORDER_ID, ORDD.PRODUCT_NO, PRO.PRODUCT_TYPE, PRO.NAME, ORDD.AMOUNT_OF_PRODUCT, PRO.PRICE, ORDD.TOTAL_AMOUNT From ORDER_DETAIL ORDD Join PRODUCT PRO ON ORDD.PRODUCT_NO = PRO.PRODUCT_NO Where ORDER_ID = '{0}'", ORDER_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tbl_showOrderDetail);  //Fill vào bảng DataTable tblOrderDetail
                return tbl_showOrderDetail;
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

        public DataTable Refresh_OrderDetail_Empty()
        {
            DataTable tblOrderDetail = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select ORDER_ID, ORDD.PRODUCT_NO, PRO.PRODUCT_TYPE, PRO.NAME, AMOUNT_OF_PRODUCT, PRO.PRICE, TOTAL_AMOUNT From ORDER_DETAIL ORDD Join PRODUCT PRO ON ORDD.PRODUCT_NO = PRO.PRODUCT_NO Where ORDER_ID = ''");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblOrderDetail);  //Fill vào bảng DataTable 
                return tblOrderDetail;
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
                string SQL = string.Format("Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT) Values ('{0}','{1}','{2}','{3}')", this._ORDER_ID, this._PRODUCT_NO, this._AMOUNT_OF_PRODUCT, this._TOTAL_AMOUNT);

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

                string SQL = string.Format("Update ORDER_DETAIL Set AMOUNT_OF_PRODUCT = '{2}', TOTAL_AMOUNT = '{3}' Where ORDER_ID = '{0}' And PRODUCT_NO = '{1}'", this._ORDER_ID, this._PRODUCT_NO, this._AMOUNT_OF_PRODUCT, this._TOTAL_AMOUNT);

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

        public bool Delete(string OrderID, string ProductID)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Delete From ORDER_DETAIL Where ORDER_ID = '{0}' And PRODUCT_NO = '{1}'", OrderID, ProductID);

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
    }
}
