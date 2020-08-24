using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Pet
    {
        DTO_Pet dto_pet = new DTO_Pet();

        public DataTable Display(string CUS_ID)
        {
            return dto_pet.Display(CUS_ID);
        }

        public DataTable Display_CustomerName(string CUS_ID)
        {
            return dto_pet.Display_CustomerName(CUS_ID);
        }

        public bool Add(DTO_Pet dto_pet)
        {
            return dto_pet.Add();
        }

        public bool Edit(DTO_Pet dto_pet)
        {
            return dto_pet.Edit();
        }

        public bool Delete(string ID)
        {
            return dto_pet.Delete(ID);
        }

        public DataTable Search(string Cus_ID, string Pet_ID, string Pet_type, string Name)
        {
            return dto_pet.Search(Cus_ID, Pet_ID, Pet_type, Name);
        }

        public DataTable Display_PetID(string CUS_ID)
        {
            return dto_pet.Display_PetID(CUS_ID);
        }

        public DataTable Display_Pet(string PET_ID)
        {
            return dto_pet.Display_Pet(PET_ID);
        }
    }
}
