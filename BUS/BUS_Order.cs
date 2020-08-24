using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Order
    {
        DTO_Order dto_ord = new DTO_Order();

        public bool Save(DTO_Order dto_ord)
        {
            return dto_ord.Save();
        }

        public DataTable Display_Order()
        {
            return dto_ord.Display_Order();
        }
            
        public DataTable Display_SearchOrder(string Order_ID)
        {
            return dto_ord.Display_SearchOrder(Order_ID);
        }

        public DataTable Display_AllOrder()
        {
            return dto_ord.Display_AllOrder();
        }

        public DataTable Display_FillOrder(string Month, string Year)
        {
            return dto_ord.Display_FillOrder(Month, Year);
        }
    }
}
