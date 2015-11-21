using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Disciplina
    {
        public Materia Materia { get; }
        public TipPredare TipPredare { get; }
        public Disciplina(Materia materia, TipPredare tp)
        {
            Materia = materia;
            TipPredare = tp;
        }
    }
}
