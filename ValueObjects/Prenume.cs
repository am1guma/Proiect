using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Prenume
    {
        public string Pren { get; }

        public Prenume(string pren)
        {
            Pren = pren;
        }

        public override bool Equals(object obj)
        {
            var pren = (Prenume)obj;
            return Pren.Equals(pren.Pren);
        }

        public override int GetHashCode()
        {
            return Pren.GetHashCode();
        }

        public override string ToString()
        {
            return Pren;
        }
    }
}
