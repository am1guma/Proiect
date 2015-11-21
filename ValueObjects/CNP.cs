using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class CNP
    {
        public string Cnp { get; }

        public CNP(string cnp)
        {
            Cnp = cnp;
        }

        public override bool Equals(object obj)
        {
            var au = (CNP)obj;
            return Cnp.Equals(au.Cnp);
        }

        public override int GetHashCode()
        {
            return Cnp.GetHashCode();
        }

        public override string ToString()
        {
            return Cnp;
        }
    }
}
