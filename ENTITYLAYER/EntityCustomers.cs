using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class EntityCustomers
    {
        private int CustomerId;
        private string CustomerName;
        private string CustomerSurname;

        public int CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string CustomerSurname1 { get => CustomerSurname; set => CustomerSurname = value; }
    }
}
