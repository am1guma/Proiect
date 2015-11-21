using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class AnUniversitar
    {
        public int An { get; }

        public AnUniversitar(int an)
        {
            An = an;
        }

        public override bool Equals(object obj)
        {
            var au = (AnUniversitar)obj;
            return An.Equals(au.An);
        }

        public override int GetHashCode()
        {
            return An.GetHashCode();
        }

        public override string ToString()
        {
            return An.ToString();
        }
    }
}
