using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class PropertyGenerator : Generator
    {
        private DistributionValue<bool>[] _isOwner;
        private DistributionValue<bool>[] _isUpgrade;
        private DistributionValue<PropertyUpgrade>[] _upgrades;
        private DistributionValue<int>[] _numberOfUpgrades;

        public PropertyGenerator(Random rand)
        {
            _rand = rand;

            _isOwner = new[] {
                new DistributionValue<bool>(true, 0.5),
                new DistributionValue<bool>(false, 1)
            };

            _isUpgrade = new[] {
                new DistributionValue<bool>(true, 0.5),
                new DistributionValue<bool>(false, 1)
            };

            _upgrades = new[] {
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.Kitchen, 1d/6*1),
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.Bathroom, 1d/6*2),
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.Bedroom, 1d/6*3),
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.LivingRoom, 1d/6*4),
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.Garden, 1d/6*5),
                new DistributionValue<PropertyUpgrade>(PropertyUpgrade.Pool, 1),
            };

            _numberOfUpgrades = new[] {
                new DistributionValue<int>(1, 0.5),
                new DistributionValue<int>(2, 0.75),
                new DistributionValue<int>(3, 0.875),
                new DistributionValue<int>(4, 0.9375),
                new DistributionValue<int>(5, 0.96875),
                new DistributionValue<int>(6, 1),
            };
        }

        public bool IsPropertyOwner()
        {
            return GetRandom(_isOwner);
        }

        public Property GetProperty(bool propertyOwner)
        {
            Property property = new Property();

            if (propertyOwner && (property.Upgrades = GetRandom(_isUpgrade)))
            {
                int num = GetRandom(_numberOfUpgrades);

                while (property.UpgradeAreas.Count < num)
                {
                    PropertyUpgrade rnd = GetRandom(_upgrades);
                    if (!property.UpgradeAreas.Contains(rnd))
                        property.UpgradeAreas.Add(rnd);
                }
            }

            return property;
        }
    }
}

