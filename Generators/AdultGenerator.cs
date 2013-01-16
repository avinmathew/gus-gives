using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class AdultGenerator : Generator
    {
        private enum AdultOccupations
        {
            WorkingFullTime,
            WorkingPartTime,
            Retired,
            Unemployed,
            Student
        }

        private DistributionValue<AdultOccupations>[] _occupations;

        public AdultGenerator(Random rand)
        {
            _rand = rand;

            _occupations = new[] {
                new DistributionValue<AdultOccupations>(AdultOccupations.WorkingFullTime, 0.4),
                new DistributionValue<AdultOccupations>(AdultOccupations.WorkingPartTime, 0.7),
                new DistributionValue<AdultOccupations>(AdultOccupations.Retired, 0.75),
                new DistributionValue<AdultOccupations>(AdultOccupations.Unemployed, 0.85),
                new DistributionValue<AdultOccupations>(AdultOccupations.Student, 1)
            };
        }

        public AdultMembers GetAdultMembers(Age age, Household household)
        {
            AdultMembers adults = new AdultMembers();
            if (age == Age.Range1)
            {
                adults.Student++;
            }
            else if (age == Age.Range6)
            {
                adults.Retired++;
            }
            while (adults.Total < household.NumberOfAdults)
            {
                AdultOccupations occupation = GetRandom(_occupations);
                if (occupation == AdultOccupations.WorkingFullTime)
                {
                    adults.WorkingFullTime++;
                }
                else if (occupation == AdultOccupations.WorkingPartTime)
                {
                    adults.WorkingPartTime++;
                }
                else if (occupation == AdultOccupations.Retired)
                {
                    adults.Retired++;
                }
                else if (occupation == AdultOccupations.Unemployed)
                {
                    adults.Unemployed++;
                }
                else if (occupation == AdultOccupations.Student)
                {
                    adults.Student++;
                }
            }

            return adults;
        }
    }
}
