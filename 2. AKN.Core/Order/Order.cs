using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AKN.Core.Order
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreateAt { get; set; }

        public string PaymentType { get; set; }

        public Boolean Status { get; set; }

        public Boolean IsCancel { get; set; }

        public Boolean InCargo { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
