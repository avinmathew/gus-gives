using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Generators
{
    public class EmailGenerator : Generator
    {
        private DistributionValue<string>[] _auEmails;
        private DistributionValue<string>[] _otherEmails;

        public EmailGenerator(Random rand)
        {
            _rand = rand;

            _auEmails = new[] {
                new DistributionValue<string>("yahoo.com", 0.15),
                new DistributionValue<string>("yahoo.com.au", 0.25),
                new DistributionValue<string>("hotmail.com", 0.5),
                new DistributionValue<string>("gmail.com", 0.65),
                new DistributionValue<string>("bigpond.net", 0.75),
                new DistributionValue<string>("iinet.net.au", 0.85),
                new DistributionValue<string>("optusnet.net.au", 0.93),
                new DistributionValue<string>("tpg.com.au", 0.97),
                new DistributionValue<string>("internode.on.net", 1),
            };

            _otherEmails = new[] {
                new DistributionValue<string>("yahoo.com", 0.38),
                new DistributionValue<string>("hotmail.com", 0.76),
                new DistributionValue<string>("gmail.com", 1),
            };
        }

   
        public string GetEmail(string firstName, string lastName, string country, HashSet<string> allEmails)
        {
            string user;
            int number;
            string fullUser;
            string domain;

            if (country == "Australia")
                domain = GetRandom(_auEmails);
            else
                domain = GetRandom(_otherEmails);

            number = 0;
            do
            {
                if (_rand.NextDouble() < 0.7)
                {
                    user = firstName.ToLower() + "." + lastName.ToLower();
                }
                else
                {
                    user = firstName.ToLower()[0] + lastName.ToLower();
                }

                if (number > 0)
                    fullUser = user + number;
                else
                    fullUser = user;

                number++;
            }
            while (allEmails.Contains(fullUser + "@" + domain));

            return fullUser + "@" + domain;
        }
    }
}
