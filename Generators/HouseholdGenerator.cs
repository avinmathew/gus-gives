using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class HouseholdGenerator : Generator
    {
        private DistributionValue<int>[] _adults;
        private DistributionValue<int>[] _minors;

        public HouseholdGenerator(Random rand)
        {
            _rand = rand;

            _adults = new[] {
                new DistributionValue<int>(1, 0.3),
                new DistributionValue<int>(2, 0.85),
                new DistributionValue<int>(3, 0.95),
                new DistributionValue<int>(3, 1)
            };

            _minors = new[] {
                new DistributionValue<int>(0, 0.4),
                new DistributionValue<int>(1, 0.7),
                new DistributionValue<int>(2, 0.9),
                new DistributionValue<int>(3, 1)
            };
        }

        public Household GetHousehold(Age age)
        {
            Household household = new Household();

            household.NumberOfAdults = GetRandom(_adults);
            household.NumberOfTeenagers = GetRandom(_minors);
            while (age == Age.Range1 && household.NumberOfTeenagers == 0)
            {
                household.NumberOfTeenagers = GetRandom(_minors);
            }
            household.NumberOfChildren = GetRandom(_minors);
            household.NumberOfBabies = GetRandom(_minors);

            return household;
        }
    }
}
