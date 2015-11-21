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
        }
        public List<Situatie> VizualizeazaSituatie()
        {
            return Situatii;
        }
    }
}
