using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace AggregationRoots.Factories
{
    public class FactoryCamin
    {
        public static readonly FactoryCamin Instance = new FactoryCamin();
        private FactoryCamin()
        {

        }
        public Camin CreeazaCamin(NumeCamin nc)
        {
            return new Camin(nc);
        }
    }
}
