using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class ElectronicPurchase
    {
        public static readonly ElectronicPurchase Television = new ElectronicPurchase("Television");
        public static readonly ElectronicPurchase HomeTheatre = new ElectronicPurchase("Home Theatre");
        public static readonly ElectronicPurchase MusicSystem = new ElectronicPurchase("Music System");
        public static readonly ElectronicPurchase Computer = new ElectronicPurchase("Computer");
        public static readonly ElectronicPurchase Dishwasher = new ElectronicPurchase("Dishwasher");
        public static readonly ElectronicPurchase Fridge = new ElectronicPurchase("Fridge");
        public static readonly ElectronicPurchase WashingMachine = new ElectronicPurchase("Washing Machine");
        public static readonly ElectronicPurchase VacuumCleaner = new ElectronicPurchase("Vacuum Cleaner");

        public string Name { get; set; }

        public ElectronicPurchase(string name)
        {
            Name = name;
        }
    }
}
