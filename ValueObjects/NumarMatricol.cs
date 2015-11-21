using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumarMatricol
    {
        public int NrMatricol { get; }

        public NumarMatricol(int nm)
        {
            NrMatricol = nm;
        }

        public override bool Equals(object obj)
        {
            var nm = (Grupa)obj;
            return NrMatricol.Equals(nm.NrMatricol);
        }

        public override int GetHashCode()
        {
            return NrMatricol.GetHashCode();
        }

        public override string ToString()
        {
            return NrMatricol.ToString();
        }
    }
}
