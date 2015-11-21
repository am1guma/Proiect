using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumeFacultate
    {
        public string NumeFac { get; }

        public NumeFacultate(string numeFac)
        {
            NumeFac = numeFac;
        }

        public override bool Equals(object obj)
        {
            var numeFac = (NumeFacultate)obj;
            return NumeFac.Equals(numeFac.NumeFac);
        }

        public override int GetHashCode()
        {
            return NumeFac.GetHashCode();
        }

        public override string ToString()
        {
            return NumeFac;
        }
    }
}
