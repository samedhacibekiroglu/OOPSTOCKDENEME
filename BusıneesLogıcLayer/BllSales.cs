using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;

namespace BusıneesLogıcLayer
{
 public   class BllSales
    {
        public static List<EntitySales> BllSalesList()
        {
            return DalSales.SalesList();
        }
    }
}
