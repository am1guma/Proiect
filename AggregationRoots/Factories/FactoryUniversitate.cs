using AggregationRoots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace AggregationRoots.Factories
{
    class FactoryUniversitate
    {
        public static readonly FactoryUniversitate Instance=new FactoryUniversitate();
        private FactoryUniversitate()
        {

        }
        public Universitate CreeazaUniversitate(NumeUniversitate nu)
        {
            return new Universitate(nu);
        }
    }
}
