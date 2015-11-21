using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Sectie
    {
        public string Sect { get; }

        public Sectie(string sect)
        {
            Sect = sect;
        }

        public override bool Equals(object obj)
        {
            var sect = (Sectie)obj;
            return Sect.Equals(sect.Sect);
        }

        public override int GetHashCode()
        {
            return Sect.GetHashCode();
        }

        public override string ToString()
        {
            return Sect;
        }
    }
}
