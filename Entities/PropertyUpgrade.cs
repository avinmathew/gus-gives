using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class PropertyUpgrade
    {
        public static readonly PropertyUpgrade Kitchen = new PropertyUpgrade("Kitchen");
        public static readonly PropertyUpgrade Bathroom = new PropertyUpgrade("Bathroom");
        public static readonly PropertyUpgrade Bedroom = new PropertyUpgrade("Bedroom");
        public static readonly PropertyUpgrade LivingRoom = new PropertyUpgrade("Living Room");
        public static readonly PropertyUpgrade Garden = new PropertyUpgrade("Garden/Landscaping");
        public static readonly PropertyUpgrade Pool = new PropertyUpgrade("Pool");

        public string Name { get; set; }

        public PropertyUpgrade(string name)
        {
            Name = name;
        }
    }
}
