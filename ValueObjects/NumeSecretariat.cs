using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumeSecretariat
    {
        public string NumeSec { get; }

        public NumeSecretariat(string numeSec)
        {
            NumeSec = numeSec;
        }

        public override bool Equals(object obj)
        {
            var numeSec = (NumeSecretariat)obj;
            return NumeSec.Equals(numeSec.NumeSec);
        }

        public override int GetHashCode()
        {
            return NumeSec.GetHashCode();
        }

        public override string ToString()
        {
            return NumeSec;
        }
    }
}
