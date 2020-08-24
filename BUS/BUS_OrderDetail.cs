using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_OrderDetail
    {
        DTO_OrderDetail dto_ordd = new DTO_OrderDetail();

        public DataTable Display_ORDERDETAIL(string ORDER_ID)
        {
            return dto_ordd.Display_ORDERDETAIL(ORDER_ID);
        }

        public DataTable Refresh_OrderDetail_Empty()
        {
            return dto_ordd.Refresh_OrderDetail_Empty();
        }

        public bool Add(DTO_OrderDetail dto_ordd)
        {
            return dto_ordd.Add();
        }

        public bool Edit(DTO_OrderDetail dto_ordd)
        {
            return dto_ordd.Edit();
        }

        public bool Delete(string OrderID, string ProductID)
        {
            return dto_ordd.Delete(OrderID, ProductID);
        }
    }
}
