using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
using BusıneesLogıcLayer;

namespace BusıneesLogıcLayer
{
  public  class BLLCUSTOMER
    {
        public static List<EntityCustomers> BllCustomerList()
        {
            return DalCustomer.CustomerList();
        }
        public static int AddCustomer(EntityCustomers p)
        {
            if (p.CustomerName1 !=" " && p.CustomerSurname1 !=" " && p.CustomerName1.Length <= 30)
            {
                return DalCustomer.AddCustomer(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool BllCustomerDelete(int par)
        {
            if (par <= 4)
            {
                return DalCustomer.DeleteCustomer(par);
            }
            return false;
        }
        public static List<EntityCustomers>BllBringCustomers(int p)
        {
            return DalCustomer.BringCustomers(p);
        }
        public static bool BllUpdateCustomer(EntityCustomers p)
        {
            if (p.CustomerName1 !="" &&p.CustomerSurname1 !="")
            {
                return DalCustomer.UpdateCustomer(p);
            }
            return false;
        }
    }
}
