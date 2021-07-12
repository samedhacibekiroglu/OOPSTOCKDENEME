using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;

namespace BusıneesLogıcLayer
{
    public class BllProduct
    {
        public static List<EntityProduct> BllListProduct()
        {
            return DalProduct.ProductList();
        }
        public static int AddProduct(EntityProduct p)
        {
            if (p.ProductName1 != " " && p.ProductPiece1 != 0 && p.ProductPrice1 != 0)
            {
                return DalProduct.AddProduct(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
