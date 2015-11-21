using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace AggregationRoots
{
    public class Camin
    {
        public Administrator Administrator { get; internal set; }
        public NumeCamin NumeCamin { get; }
        internal Camin(NumeCamin nc)
        {
            NumeCamin = nc;
        }
        public void CreeazaAdministrator(Administrator admin)
        {
            Administrator = admin;
        }
        public override bool Equals(object obj)
        {
            var admin = (Camin)obj;
            return Administrator.Equals(admin.Administrator);
        }
        public override int GetHashCode()
        {
            return Administrator.GetHashCode();
        }
        public override string ToString()
        {
            return Administrator.ToString();
        }
    }
    
}
