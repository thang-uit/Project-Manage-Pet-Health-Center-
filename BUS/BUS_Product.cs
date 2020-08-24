using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Product
    {
        DTO_Product dto_pro = new DTO_Product();

        public DataTable Display()
        {
            return dto_pro.Display();
        }

        public bool Add(DTO_Product dto_pro)
        {
            return dto_pro.Add();
        }

        public bool Edit(DTO_Product dto_pro)
        {
            return dto_pro.Edit();
        }

        public bool Delete(string ID)
        {
            return dto_pro.Delete(ID);
        }

        public DataTable Search(string ID, string Product_type, string Name)
        {
            return dto_pro.Search(ID, Product_type, Name);
        }

        public DataTable Display_ProductID()
        {
            return dto_pro.Display_ProductID();
        }

        public DataTable Display_Products(string PRO_ID)
        {
            return dto_pro.Display_Products(PRO_ID);
        }
    }
}
