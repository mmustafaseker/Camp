using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Tüzel müşteri
    //inheritance - miras
    class CoorprateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
