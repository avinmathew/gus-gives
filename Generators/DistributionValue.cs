using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Generators
{
    public class DistributionValue<T>
    {
        public DistributionValue(T value, double distribution)
        {
            Value = value;
            Distribution = distribution;
        }
        public T Value { get; set; }
        public double Distribution { get; set; }
    }
}
