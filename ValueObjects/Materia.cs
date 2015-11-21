using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Materia
    {
        public string Denumire { get; }

        public Materia(string materia)
        {
            Denumire = materia;
        }

        public override bool Equals(object obj)
        {
            var mat = (Materia)obj;
            return Denumire.Equals(mat.Denumire);
        }

        public override int GetHashCode()
        {
            return Denumire.GetHashCode();
        }

        public override string ToString()
        {
            return Denumire;
        }
    }
}
