using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class EntityProduct
    {
        private int ProductId;
        private string ProductName;
        private decimal ProductPrice;
        private int ProductPiece;

        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public decimal ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }
        public int ProductPiece1 { get => ProductPiece; set => ProductPiece = value; }
    }
}
