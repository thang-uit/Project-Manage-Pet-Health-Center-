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
    public class DTO_Pet : DBConnection
    {
        private string PET_ID;
        private string CUSTOMER_ID;
        private string NAME;
        private string AGE;
        private string GENDER;
        private string PET_TYPE;
        private string BREED;
        private string COLOR;
        private float WEIGHT;
        private string DISTINCTION;

        public string _PET_ID { get => PET_ID; set => PET_ID = value; }
        public string _NAME { get => NAME; set => NAME = value; }
        public string _AGE { get => AGE; set => AGE = value; }
        public string _GENDER { get => GENDER; set => GENDER = value; }
        public string _PET_TYPE { get => PET_TYPE; set => PET_TYPE = value; }
        public string _BREED { get => BREED; set => BREED = value; }
        public string _COLOR { get => COLOR; set => COLOR = value; }
        public float _WEIGHT { get => WEIGHT; set => WEIGHT = value; }
        public string _DISTINCTION { get => DISTINCTION; set => DISTINCTION = value; }
        public string _CUSTOMER_ID { get => CUSTOMER_ID; set => CUSTOMER_ID = value; }

        public DTO_Pet()
        {
        }

        public DTO_Pet(string PET_ID, string CUSTOMER_ID, string NAME, string AGE, string GENDER, string PET_TYPE, string BREED, string COLOR, float WEIGHT, string DISTINCTION)
        {
            this.PET_ID = PET_ID;
            this.CUSTOMER_ID = CUSTOMER_ID;
            this.NAME = NAME;
            this.AGE = AGE;
            this.GENDER = GENDER;
            this.PET_TYPE = PET_TYPE;
            this.BREED = BREED;
            this.COLOR = COLOR;
            this.WEIGHT = WEIGHT;
            this.DISTINCTION = DISTINCTION;
        }

        public DataTable Display(string CUS_ID) // Hiển thị lên Datagridview
        {
            DataTable tblPet = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select * From PET Where CUSTOMER_ID = '{0}'", CUS_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblPet);  //Fill vào bảng DataTable tblPet
                return tblPet;
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

        public DataTable Display_CustomerName(string CUS_ID) // Hiển thị tên khách hàng vào Textbox sau khi chọn mã KH từ Combobox
        {
            DataTable tblPet = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select NAME From CUSTOMER Where CUSTOMER_ID = '{0}'", CUS_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblPet);  //Fill vào bảng 
                return tblPet;
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
                string SQL = string.Format("Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) Values ('{0}','{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}',N'{7}','{8}',N'{9}')", this.PET_ID, this._CUSTOMER_ID, this._NAME, this._AGE, this._GENDER, this._PET_TYPE, this._BREED, this._COLOR, this._WEIGHT, this._DISTINCTION);

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

                string SQL = string.Format("Update PET Set NAME = N'{2}', AGE = '{3}', GENDER = N'{4}', PET_TYPE = N'{5}', BREED = N'{6}', COLOR = N'{7}', WEIGHT = '{8}', DISTINCTION = N'{9}' Where PET_ID = '{0}' And CUSTOMER_ID = '{1}'", this._PET_ID, this._CUSTOMER_ID, this._NAME, this._AGE, this._GENDER, this._PET_TYPE, this._BREED, this._COLOR, this._WEIGHT, this._DISTINCTION);

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
                string SQL = string.Format("Delete From PET Where PET_ID = '{0}'", ID);

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

        public DataTable Search(string Cus_ID, string Pet_ID, string Pet_type, string Name)
        {
            DataTable tblPet = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string SQL = string.Format("Select * From PET Where CUSTOMER_ID = '{0}' And (PET_ID = '{1}' OR PET_TYPE = N'{2}' OR NAME = N'{3}')", Cus_ID, Pet_ID, Pet_type, Name);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblPet);  //Fill vào bảng tblPet
                return tblPet;
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

        public DataTable Display_PetID(string CUS_ID)
        {
            DataTable tblComboboxPetID = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select PET_ID From PET Where CUSTOMER_ID = '{0}'", CUS_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblComboboxPetID);  //Fill vào bảng DataTable 
                return tblComboboxPetID;
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

        public DataTable Display_Pet(string PET_ID)
        {
            DataTable txtPet = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            string query = string.Format("Select * From PET Where PET_ID = '{0}'", PET_ID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(txtPet);  //Fill vào bảng DataTable 
                return txtPet;
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
