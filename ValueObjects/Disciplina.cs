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

        public override bool Equals(object obj)
        {
            var disciplina = (Disciplina)obj;
            return Materia.Equals(disciplina.Materia)&& TipPredare.Equals(disciplina.TipPredare);
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
