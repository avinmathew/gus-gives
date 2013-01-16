using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Household
    {
        public int NumberOfAdults { get; set; }
        public int NumberOfTeenagers { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfBabies { get; set; }

        public int Total
        {
            get
            {
                return NumberOfAdults + NumberOfTeenagers + NumberOfChildren + NumberOfBabies;
            }
        }
    }
}
