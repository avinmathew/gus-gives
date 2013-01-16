using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Address
    {
        public string Unit { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
