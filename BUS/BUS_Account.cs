using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Account
    {
        DTO_Account dto_acc = new DTO_Account();

        public DataTable Get_Role(string Username, string Password)
        {
            return dto_acc.Get_Role(Username, Password);
        }

        public DataTable Display_RecID(string Username, string Password)
        {
            return dto_acc.Display_RecID(Username, Password);
        }
    }
}
