using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //gerçek müşteri
    //inheritance
    class IndividualCustomer : Customer
    {
        public string TcNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
