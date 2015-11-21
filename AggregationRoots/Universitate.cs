using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace AggregationRoots
{
    public class Universitate
    {
        public List<Facultate> Facultati { get; }
        public NumeUniversitate NumeUniversitate { get; }
        internal Universitate(NumeUniversitate nu)
        {
            NumeUniversitate = nu;
        }
        public void CreeazaFacultate(Facultate fac)
        {
            Facultati.Add(fac);
        }
    }
}
