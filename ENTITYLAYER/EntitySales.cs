using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class EntitySales
    {
        private int SaleId;
        private int Product;
        private int Staff;
        private decimal Amount;
        private int Customer;
        private string CustomerName;
        private string CustomerSurname;
        private string ProductName;
        private string StaffName;
        private string StaffSurname;

        public int SaleId1 { get => SaleId; set => SaleId = value; }
        public int Product1 { get => Product; set => Product = value; }
        public int Staff1 { get => Staff; set => Staff = value; }
        public decimal Amount1 { get => Amount; set => Amount = value; }
        public int Customer1 { get => Customer; set => Customer = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string CustomerSurname1 { get => CustomerSurname; set => CustomerSurname = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string StaffName1 { get => StaffName; set => StaffName = value; }
        public string StaffSurname1 { get => StaffSurname; set => StaffSurname = value; }
    }
}
