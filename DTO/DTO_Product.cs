using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product : DBConnection
    {
        private string PRODUCT_NO;
        private string PRODUCT_TYPE;
        private string NAME;
        private string SUPPLIER;
        private string NATION;
        private long PRICE;

        public string _PRODUCT_NO { get => PRODUCT_NO; set => PRODUCT_NO = value; }
        public string _PRODUCT_TYPE { get => PRODUCT_TYPE; set => PRODUCT_TYPE = value; }
        public string _NAME { get => NAME; set => NAME = value; }
        public string _SUPPLIER { get => SUPPLIER; set => SUPPLIER = value; }
        public string _NATION { get => NATION; set => NATION = value; }
        public long _PRICE { get => PRICE; set => PRICE = value; }

        public DTO_Product()
        {
        }

        public DTO_Product(string PRODUCT_NO, string PRODUCT_TYPE, string NAME, string SUPPLIER, string NATION, long PRICE)
        {
            this.PRODUCT_NO = PRODUCT_NO;
            this.PRODUCT_TYPE = PRODUCT_TYPE;
            this.NAME = NAME;
            this.SUPPLIER = SUPPLIER;
            this.NATION = NATION;
            this.PRICE = PRICE;
        }

        public DataTable Display()
        {
            DataTable tblProduct = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select * From PRODUCT");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblProduct);
                return tblProduct;
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
                string SQL = string.Format("Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE) Values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}')", this._PRODUCT_NO, this._PRODUCT_TYPE, this._NAME, this._SUPPLIER, this._NATION, this._PRICE);

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

                string SQL = string.Format("Update PRODUCT Set PRODUCT_TYPE = N'{1}', NAME = N'{2}', SUPPLIER = N'{3}', NATION = N'{4}', PRICE = '{5}' Where PRODUCT_NO = '{0}'", this._PRODUCT_NO, this._PRODUCT_TYPE, this._NAME, this._SUPPLIER, this._NATION, this._PRICE);

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
                string SQL = string.Format("Delete From PRODUCT Where PRODUCT_NO = '{0}'", ID);

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

        public DataTable Search(string ID, string Product_type, string Name)
        {
            DataTable tblProduct = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select * From PRODUCT Where PRODUCT_NO = '{0}' OR PRODUCT_TYPE = N'{1}' OR NAME = N'{2}'", ID, Product_type, Name);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblProduct);  //Fill vào bảng tblProduct
                return tblProduct;
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

        public DataTable Display_ProductID()
        {
            DataTable tblComboboxProID = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select PRODUCT_NO From PRODUCT");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblComboboxProID);
                return tblComboboxProID;
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

        public DataTable Display_Products(string PRO_ID)
        {
            DataTable txtPro = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select PRODUCT_TYPE, NAME, PRICE From PRODUCT Where PRODUCT_NO = '{0}'", PRO_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(txtPro);  //Fill vào bảng DataTable 
                return txtPro;
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
