using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class AgeGenerator : Generator
    {
        private DistributionValue<Age>[] _femaleAges;
        private DistributionValue<Age>[] _maleAges;

        public AgeGenerator(Random rand)
        {
            _rand = rand;

            _femaleAges = new[] {
                new DistributionValue<Age>(Age.Range1, 0.2),
                new DistributionValue<Age>(Age.Range2, 0.3),
                new DistributionValue<Age>(Age.Range3, 0.5),
                new DistributionValue<Age>(Age.Range4, 0.7),
                new DistributionValue<Age>(Age.Range5, 0.8),
                new DistributionValue<Age>(Age.Range6, 1)
            };

            _maleAges = new[] {
                new DistributionValue<Age>(Age.Range1, 0.2),
                new DistributionValue<Age>(Age.Range2, 0.3),
                new DistributionValue<Age>(Age.Range3, 0.5),
                new DistributionValue<Age>(Age.Range4, 0.7),
                new DistributionValue<Age>(Age.Range5, 0.8),
                new DistributionValue<Age>(Age.Range6, 1)
            };
        }

        public Age GetAge(Gender gender)
        {
            if (gender == Gender.Female)
                return GetRandom(_femaleAges);
            else
                return GetRandom(_maleAges);
        }
    }
}
