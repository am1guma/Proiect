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
            Facultati = new List<Facultate>();
        }
        public void CreeazaFacultate(Facultate fac)
        {
            Facultati.Add(fac);
        }
        public override bool Equals(object obj)
        {
            var univ = (Universitate)obj;
            return NumeUniversitate.Equals(univ.NumeUniversitate);
        }
        public override int GetHashCode()
        {
            return NumeUniversitate.GetHashCode();
        }
        public override string ToString()
        {
            return NumeUniversitate.ToString();
        }
    }
}
