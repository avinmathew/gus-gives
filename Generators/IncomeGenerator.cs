using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class IncomeGenerator : Generator
    {
        private DistributionValue<string>[] _ranges;

        public IncomeGenerator(Random rand)
        {
            _rand = rand;

            _ranges = new[] {
                new DistributionValue<string>("<25,000", 0.143),
                new DistributionValue<string>("25,001-40,000", 0.308),
                new DistributionValue<string>("40,001-55,000", 0.421),
                new DistributionValue<string>("55,001-70,000", 0.488),
                new DistributionValue<string>("70,001-85,000", 0.583),
                new DistributionValue<string>("85,001-100,000", 0.667),
                new DistributionValue<string>("100,001-120,000", 0.780),
                new DistributionValue<string>("120,001-140,000", 0.813),
                new DistributionValue<string>("140,001+", 1)
            };
        }

        public string GetIncome()
        {
            return GetRandom(_ranges);
        }
    }
}
