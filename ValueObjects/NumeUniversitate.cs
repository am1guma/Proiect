using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumeUniversitate
    {
        public string NumeUni { get; }

        public NumeUniversitate(string numeUni)
        {
            NumeUni = numeUni;
        }

        public override bool Equals(object obj)
        {
            var numeUni = (NumeUniversitate)obj;
            return NumeUni.Equals(numeUni.NumeUni);
        }

        public override int GetHashCode()
        {
            return NumeUni.GetHashCode();
        }

        public override string ToString()
        {
            return NumeUni;
        }
    }
}
