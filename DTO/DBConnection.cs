using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBConnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=THANGUIT;Initial Catalog=MANAGE_PET_HEALTH_CENTER;Integrated Security=True");
    }
}
