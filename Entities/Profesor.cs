using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Entities
{
    public class Profesor
    {
        public List<Disciplina> Discipline { get; }
        public Nume Nume { get; }
        public Prenume Prenume { get; }
        public DataNasterii DataNasterii { get; }
        public CNP CNP { get; }
        public Profesor(Nume nume, Prenume prenume, DataNasterii dn, CNP cnp)
        {
            Nume = nume;
            Prenume = prenume;
            DataNasterii = dn;
            CNP = cnp;
        }
        public void CreeazaDisciplina(Disciplina dis)
        {
            Discipline.Add(dis);
        }
        public void CreeazaSituatie(Student stu,Materia materia,Nota nota)
        {
            stu.Situatii.Add(new Situatie(materia,nota));
        }
        public override bool Equals(object obj)
        {
            var prof = (Profesor)obj;
            return CNP.Equals(prof.CNP);
        }
        public override int GetHashCode()
        {
            return CNP.GetHashCode();
        }
        public override string ToString()
        {
            return CNP.ToString();
        }
    }
}
