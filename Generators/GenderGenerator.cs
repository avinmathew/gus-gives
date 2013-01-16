using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class GenderGenerator : Generator
    {
        private DistributionValue<Gender>[] _genders;

        public GenderGenerator(Random rand)
        {
            _rand = rand;
            _genders = new[] {
                new DistributionValue<Gender>(Gender.Male, 0.44),
                new DistributionValue<Gender>(Gender.Female, 1)
            };
        }

        public Gender GetGender()
        {
            return GetRandom(_genders);
        }
    }
}
