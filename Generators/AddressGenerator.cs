using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUSGives.Entities;
using System.IO;

namespace GUSGives.Generators
{
    public class AddressGenerator : Generator
    {
        private DistributionValue<string>[] _countries;
        private DistributionValue<string>[] _auStates;
        private DistributionValue<Tuple<int, int>>[] _unitNumbers;

        private string[] _auStreets;
        private string[] _gbStreets;
        private string[] _nzStreets;

        private Address[] _auSuburbs;
        private string[] _gbSuburbs;
        private Address[] _nzSuburbs;

        public AddressGenerator(Random rand)
        {
            _rand = rand;

            _countries = new[] {
                new DistributionValue<string>("New Zealand", 0.01),
                new DistributionValue<string>("England", 0.03),
                new DistributionValue<string>("Australia", 1)
            };

            _auStates = new[] {
                new DistributionValue<string>("NT", 0.01),
                new DistributionValue<string>("ACT", 0.02),
                new DistributionValue<string>("TAS", 0.03),
                new DistributionValue<string>("SA", 0.07),
                new DistributionValue<string>("WA", 0.12),
                new DistributionValue<string>("VIC", 0.24),
                new DistributionValue<string>("NSW", 0.40),
                new DistributionValue<string>("QLD", 1),
            };

            _unitNumbers = new[] {
                new DistributionValue<Tuple<int, int>>(Tuple.Create(1, 6), 0.5),
                new DistributionValue<Tuple<int, int>>(Tuple.Create(7, 12), 0.75),
                new DistributionValue<Tuple<int, int>>(Tuple.Create(13, 18), 0.9),
                new DistributionValue<Tuple<int, int>>(Tuple.Create(19, 24), 1)
            };
        }

        public void Load(string auStreetsFile, string auSuburbsFile, string gbStreetsFile, string gbSuburbsFile, string nzStreetsFile, string nzSuburbsFile)
        {
            _auStreets = ReadFile(auStreetsFile);
            _gbStreets = ReadFile(gbStreetsFile);
            _nzStreets = ReadFile(nzStreetsFile);

            _auSuburbs = ReadAuSuburbs(auSuburbsFile);
            _gbSuburbs = ReadFile(gbSuburbsFile);
            _nzSuburbs = ReadNzSuburbs(nzSuburbsFile);
        }

        public string[] ReadFile(string file)
        {
            List<string> streets = new List<string>();
            using (TextReader reader = File.OpenText(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    streets.Add(line);
                }
            }
            return streets.ToArray();
        }

        public Address[] ReadAuSuburbs(string file)
        {
            List<Address> suburbs = new List<Address>();
            using (TextReader reader = File.OpenText(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] split = line.Split('\t');
                    Address address = new Address()
                    {
                        Suburb = split[0],
                        PostCode = split[1],
                        State = split[2]
                    };
                    suburbs.Add(address);
                }
            }
            return suburbs.ToArray();
        }

        public Address[] ReadNzSuburbs(string file)
        {
            List<Address> suburbs = new List<Address>();
            using (TextReader reader = File.OpenText(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] split = line.Split('\t');
                    Address address = new Address()
                    {
                        Suburb = split[0],
                        PostCode = split[1]
                    };
                    suburbs.Add(address);
                }
            }
            return suburbs.ToArray();
        }

        public Address GetAddress(Age age)
        {
            Address address = new Address();
            address.Country = GetRandom(_countries);

            if (address.Country == "Australia")
            {
                address.Street = GetRandom(_auStreets);
                address.State = GetRandom(_auStates);
                Address rndSuburb = GetRandom(_auSuburbs.Where(a => a.State == address.State));
                address.Suburb = rndSuburb.Suburb;
                address.PostCode = rndSuburb.PostCode;
            }
            else if (address.Country == "England")
            {
                address.Street = GetRandom(_gbStreets);
                address.Suburb = GetRandom(_gbSuburbs);
            }
            else
            {
                address.Street = GetRandom(_nzStreets);
                Address rndSuburb = GetRandom(_nzSuburbs);
                address.Suburb = rndSuburb.Suburb;
                address.PostCode = rndSuburb.PostCode;
            }

            address.Number = _rand.Next(1, 100).ToString();

            double rnd = _rand.NextDouble();
            if ((age == Age.Range1 && rnd < 0.2)
                || (age == Age.Range2 && rnd < 0.3)
                || (age == Age.Range3 && rnd < 0.1)
                || (age == Age.Range4 && rnd < 0.1)
                || (age == Age.Range5 && rnd < 0.1)
                || (age == Age.Range6 && rnd < 0.25)
                )
            {
                Tuple<int, int> value = GetRandom(_unitNumbers);
                address.Unit = _rand.Next(value.Item1, value.Item2).ToString();
            }

            return address;
        }
    }
}
