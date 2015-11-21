using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Administrator
    {
        public NumeAdministrator NumeAdministrator { get; }
        public Administrator(NumeAdministrator na)
        {
            NumeAdministrator = na;
        }
        public override bool Equals(object obj)
        {
            var admin = (Administrator)obj;
            return NumeAdministrator.Equals(admin.NumeAdministrator);
        }
        public override int GetHashCode()
        {
            return NumeAdministrator.GetHashCode();
        }
        public override string ToString()
        {
            return NumeAdministrator.ToString();
        }
    }
}
