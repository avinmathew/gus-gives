using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class ElectronicsGenerator : Generator
    {
        private DistributionValue<bool>[] _isPurchaser;
        private DistributionValue<ElectronicPurchase>[] _purchases;
        private DistributionValue<int>[] _numberOfPurchases;

        public ElectronicsGenerator(Random rand)
        {
            _rand = rand;

            _isPurchaser = new[] {
                new DistributionValue<bool>(true, 0.5),
                new DistributionValue<bool>(false, 1)
            };

            _purchases = new[] {
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.Television, 1d/8*1),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.HomeTheatre, 1d/8*2),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.MusicSystem, 1d/8*3),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.Computer, 1d/8*4),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.Dishwasher, 1d/8*5),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.Fridge, 1d/8*6),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.WashingMachine, 1d/8*7),
                new DistributionValue<ElectronicPurchase>(ElectronicPurchase.VacuumCleaner, 1)
            };

            _numberOfPurchases = new[] {
                new DistributionValue<int>(1, 0.5),
                new DistributionValue<int>(2, 0.75),
                new DistributionValue<int>(3, 0.875),
                new DistributionValue<int>(4, 0.9375),
                new DistributionValue<int>(5, 0.96875),
                new DistributionValue<int>(6, 0.984375),
                new DistributionValue<int>(7, 0.992188),
                new DistributionValue<int>(8, 1),
            };
        }

        public bool IsElectronicPurchaser()
        {
            return GetRandom(_isPurchaser);
        }

        public Electronics GetElectronics(bool electronicPurchaser)
        {
            Electronics electronics = new Electronics();

            if (electronicPurchaser)
            {
                int num = GetRandom(_numberOfPurchases);

                while (electronics.ElectronicPurchases.Count < num)
                {
                    ElectronicPurchase rnd = GetRandom(_purchases);
                    if (!electronics.ElectronicPurchases.Contains(rnd))
                        electronics.ElectronicPurchases.Add(rnd);
                }
            }

            return electronics;
        }
    }
}

