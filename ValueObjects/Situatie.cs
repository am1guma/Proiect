using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Situatie
    {
        public Materia Materia { get; }
        public Nota Nota { get; }
        public Situatie(Materia materia, Nota nota)
        {
            Materia = materia;
            Nota = nota;
        }

        public override bool Equals(object obj)
        {
            var situatie = (Situatie)obj;
            return Materia.Equals(situatie.Materia)&&Nota.Equals(situatie.Nota);
        }

        public override int GetHashCode()
        {
            return Materia.GetHashCode();
        }

        public override string ToString()
        {
            return Materia.ToString();
        }
    }
}
