using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Customer
    {
        DTO_Customer dto_cus = new DTO_Customer();

        public DataTable Display()
        {
            return dto_cus.Display();
        }

        public bool Add(DTO_Customer dto_cus)
        {
            return dto_cus.Add();
        }

        public bool Edit(DTO_Customer dto_cus)
        {
            return dto_cus.Edit();
        }

        public bool Delete(string ID)
        {
            return dto_cus.Delete(ID);
        }

        public DataTable Search(string ID, string Name)
        {
            return dto_cus.Search(ID, Name);
        }

        public DataTable Best_Search(string ID, string Name, string Birthday, string Gender, string Address, string Email, string Phone)
        {
            return dto_cus.Best_Search(ID, Name, Birthday, Gender, Address, Email, Phone);
        }

        public DataTable Display_CustomerID()
        {
            return dto_cus.Display_CustomerID();
        }

        public DataTable Display_Customer(string CUS_ID)
        {
            return dto_cus.Display_Customer(CUS_ID);
        }
    }
}
