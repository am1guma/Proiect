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
    }
}
