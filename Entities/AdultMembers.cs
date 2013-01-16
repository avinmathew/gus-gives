using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class AdultMembers
    {
        public int WorkingFullTime { get; set; }
        public int WorkingPartTime { get; set; }
        public int Retired { get; set; }
        public int Unemployed { get; set; }
        public int Student { get; set; }

        public int Total
        {
            get
            {
                return WorkingFullTime + WorkingPartTime + Retired + Unemployed + Student;
            }
        }
    }
}
