using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AKN.Core.Adress
{
    public class Adress
    {
        public int Id { get; set; }

        public string AdressName { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string PostCode { get; set; }

        public string PhoneNumber { get; set; }

        public Boolean InvoiceAdress { get; set; }
    }
}
