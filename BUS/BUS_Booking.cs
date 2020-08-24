using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Booking
    {
        DTO_Booking dto_boo = new DTO_Booking();

        public DataTable Display_Booking()
        {
            return dto_boo.Display_Booking();
        }

        public DataTable Display_BookingID()
        {
            return dto_boo.Display_BookingID();
        }

        public DataTable Display_InfoBooking(string ID)
        {
            return dto_boo.Display_InfoBooking(ID);
        }

        public bool Add(DTO_Booking dto_boo)
        {
            return dto_boo.Add();
        }

        public bool Edit(DTO_Booking dto_boo)
        {
            return dto_boo.Edit();
        }

        public bool Delete(string ID)
        {
            return dto_boo.Delete(ID);
        }

        public DataTable Search_Booking(string ID, string Name)
        {
            return dto_boo.Search_Booking(ID, Name);
        }
    }
}
