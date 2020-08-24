using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Employee
    {
        DTO_Employee dto_emp = new DTO_Employee();

        public DataTable Display_Employee()
        {
            return dto_emp.Display_Employee();
        }

        public bool Add(DTO_Employee dto_emp)
        {
            return dto_emp.Add();
        }

        public bool Edit(DTO_Employee dto_emp)
        {
            return dto_emp.Edit();
        }

        public bool Delete(string ID)
        {
            return dto_emp.Delete(ID);
        }

        public DataTable Search(string ID, string Name)
        {
            return dto_emp.Search(ID, Name);
        }

        public DataTable Display_VetID()
        {
            return dto_emp.Display_VetID();
        }

        public DataTable Display_VetName(string VET_ID)
        {
            return dto_emp.Display_VetName(VET_ID);
        }

        public DataTable Display_ReceptionistName(string REC_ID)
        {
            return dto_emp.Display_ReceptionistName(REC_ID);
        }
    }
}
