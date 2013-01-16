using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Property
    {
        public bool Upgrades { get; set; }
        public HashSet<PropertyUpgrade> UpgradeAreas { get; set; }

        public bool UpgradeKitchen
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.Kitchen); }
        }

        public bool UpgradeBathroom
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.Bathroom); }
        }

        public bool UpgradeBedroom
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.Bedroom); }
        }

        public bool UpgradeLivingRoom
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.LivingRoom); }
        }

        public bool UpgradeGarden
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.Garden); }
        }

        public bool UpgradePool
        {
            get { return UpgradeAreas.Contains(PropertyUpgrade.Pool); }
        }

        public Property()
        {
            UpgradeAreas = new HashSet<PropertyUpgrade>();
        }
    }
}
