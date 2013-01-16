using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Generators
{
    public abstract class Generator
    {
        protected Random _rand;

        protected T GetRandom<T>(IEnumerable<DistributionValue<T>> values)
        {
            double rnd = _rand.NextDouble();
            for (int i = 0; i < values.Count(); i++)
            {
                if (rnd < values.ElementAt(i).Distribution)
                    return values.ElementAt(i).Value;
            }
            throw new InvalidOperationException();
        }

        protected T GetRandom<T>(IEnumerable<T> values)
        {
            int rnd = _rand.Next(values.Count() - 1);
            return values.ElementAt(rnd);
        }
    }
}
