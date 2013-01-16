using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Age
    {
        public static readonly Age Range1 = new Age("16-25");
        public static readonly Age Range2 = new Age("26-35");
        public static readonly Age Range3 = new Age("36-45");
        public static readonly Age Range4 = new Age("46-55");
        public static readonly Age Range5 = new Age("56-65");
        public static readonly Age Range6 = new Age("65+");

        public string Name { get; set; }

        public Age(string name)
        {
            Name = name;
        }
    }
}
