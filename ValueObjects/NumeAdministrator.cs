using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumeAdministrator
    {
        public string NumeAdmin { get; }

        public NumeAdministrator(string numeAdmin)
        {
            NumeAdmin = numeAdmin;
        }

        public override bool Equals(object obj)
        {
            var numeadmin = (NumeAdministrator)obj;
            return NumeAdmin.Equals(numeadmin.NumeAdmin);
        }

        public override int GetHashCode()
        {
            return NumeAdmin.GetHashCode();
        }

        public override string ToString()
        {
            return NumeAdmin;
        }
    }
}
