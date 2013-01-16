using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GUSGives.Generators
{
    public class NameGenerator : Generator
    {
        private string LastNameFile { get; set; }
        private string FemaleNameFile { get; set; }
        private string MaleNameFile { get; set; }

        private DistributionValue<string>[] _lastNames;
        private DistributionValue<string>[] _femaleNames;
        private DistributionValue<string>[] _maleNames;

        public NameGenerator(Random rand)
        {
            _rand = rand;
        }

        public void Load(string lastNameFile, string femaleNameFile, string maleNameFile)
        {
            _lastNames = ReadFile(lastNameFile);
            _femaleNames = ReadFile(femaleNameFile);
            _maleNames = ReadFile(maleNameFile);
        }

        private DistributionValue<string>[] ReadFile(string nameFile)
        {
            List<DistributionValue<string>> values = new List<DistributionValue<string>>();
            using (TextReader reader = File.OpenText(nameFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    DistributionValue<string> value = new DistributionValue<string>(split[0], double.Parse(split[2]));
                    values.Add(value);
                }
            }
            return values.ToArray();
        }

        public string GetLastName()
        {
            return GetRandomName(_lastNames);
        }

        public string GetFemaleName()
        {
            return GetRandomName(_femaleNames);
        }

        public string GetMaleName()
        {
            return GetRandomName(_maleNames);
        }

        private string GetRandomName(DistributionValue<string>[] values)
        {
            double rnd = _rand.NextDouble() * values[values.Length - 1].Distribution;
            for (int i = 0; i < _lastNames.Length; i++)
            {
                if (rnd < values[i].Distribution)
                    return values[i].Value;
            }
            throw new InvalidOperationException();
        }
    }
}
