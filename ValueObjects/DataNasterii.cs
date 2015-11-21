using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class DataNasterii
    {
        public DateTime Dn { get; }

        public DataNasterii(DateTime dn)
        {
            Dn = dn;
        }

        public override bool Equals(object obj)
        {
            var au = (DataNasterii)obj;
            return Dn.Equals(au.Dn);
        }

        public override int GetHashCode()
        {
            return Dn.GetHashCode();
        }

        public override string ToString()
        {
            return Dn.ToString();
        }
    }
}
