using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;

namespace GUSGives.Generators
{
    public class MembershipStatusGenerator : Generator
    {
        private DistributionValue<MembershipStatus>[] _status;
        private DistributionValue<OptionalExtras>[] _extras;

        public MembershipStatusGenerator(Random rand)
        {
            _rand = rand;

            _status = new[] {
                new DistributionValue<MembershipStatus>(MembershipStatus.Free, 0.5),
                new DistributionValue<MembershipStatus>(MembershipStatus.Paying, 1)
            };

            _extras = new[] {
                new DistributionValue<OptionalExtras>(OptionalExtras.Yes, 0.5),
                new DistributionValue<OptionalExtras>(OptionalExtras.No, 1)
            };
        }

        public MembershipStatus GetMembershipStatus()
        {
            return GetRandom(_status);
        }

        public OptionalExtras GetOptionalExtras()
        {
            return GetRandom(_extras);
        }
    }
}
