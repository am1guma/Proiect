using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Nota
    {
        public int Valoare { get; }

        public Nota(int val)
        {
            Valoare = val;
        }

        public override bool Equals(object obj)
        {
            var val = (Nota)obj;
            return Valoare.Equals(val.Valoare);
        }

        public override int GetHashCode()
        {
            return Valoare.GetHashCode();
        }

        public override string ToString()
        {
            return Valoare.ToString();
        }
    }
}
