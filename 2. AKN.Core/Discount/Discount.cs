using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AKN.Core.Discount
{
    public class Discount
    {
        public int Id { get; set; }

        public string DiscountName { get; set; }

        public decimal DiscountValue { get; set; }

        public DiscountType DiscountType { get; set; }


    }
}
