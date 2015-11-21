using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Entities
{
    public class Student
    {
        public List<Situatie> Situatii { get; }
        public NumarMatricol NumarMatricol { get; }
        public Nume Nume { get; }
        public Prenume Prenume { get; }
        public DataNasterii DataNasterii { get; }
        public CNP CNP { get; }
        public Sectie Sectie { get; }
        public AnUniversitar AnUniversitar { get; }
        public Grupa Grupa { get; }
        public Student(NumarMatricol nm, Nume nume, Prenume prenume, DataNasterii dn, 
            CNP cnp, Sectie sectie, AnUniversitar au, Grupa grupa)
        {
            NumarMatricol = nm;
            Nume = nume;
            Prenume = prenume;
            DataNasterii = dn;
            CNP = cnp;
            Sectie = sectie;
            AnUniversitar = au;
            Grupa = grupa;
            Situatii = new List<Situatie>();
        }
        public string VizualizeazaSituatie()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Situatie:\n");
            foreach (Situatie s in Situatii)
                sb.Append("     "+s.Materia + ": " + s.Nota+"\n");
            return sb.ToString();
        }
        public double Medie()
        {
            double medie = 0;
            foreach (Situatie s in Situatii)
                medie += s.Nota.Valoare;
            return Math.Round(medie / Situatii.Count, 2);
        }
        public override bool Equals(object obj)
        {
            var stud = (Student)obj;
            return NumarMatricol.Equals(stud.NumarMatricol);
        }
        public override int GetHashCode()
        {
            return NumarMatricol.GetHashCode();
        }
        public override string ToString()
        {
            return Nume.ToString()+" "+Prenume.ToString();
        }
    }
}
