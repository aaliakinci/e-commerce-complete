using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AKN.Core.Product
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitStock { get; set; }

        public string ProductImage { get; set; }

        public string Description { get; set; }

        public string Proporties { get; set; }

        public int PurchaseQuantity { get; set; }

    }
}
