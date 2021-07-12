using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
  public  class ConnectionClass
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-QVJLJII\SQLEXPRESS;Initial Catalog=OOPDbStaff;Integrated Security=True");
        
    }
}
