using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Entities
{
    public class Secretariat
    {
        public List<Student> Studenti { get; }
        public List<Profesor> Profesori { get; }
        public NumeSecretariat NumeSecretariat { get; }
        public Secretariat(NumeSecretariat ns)
        {
            NumeSecretariat = ns;
            Studenti = new List<Student>();
            Profesori = new List<Profesor>();
        }
        public void CreeazaStudent(Student stu)
        {
            Studenti.Add(stu);
        }
        public void CreeazaProfesor(Profesor pro)
        {
            Profesori.Add(pro);
        }
        public override bool Equals(object obj)
        {
            var secretariat = (Secretariat)obj;
            return NumeSecretariat.Equals(secretariat.NumeSecretariat);
        }
        public override int GetHashCode()
        {
            return NumeSecretariat.GetHashCode();
        }
        public override string ToString()
        {
            return NumeSecretariat.ToString();
        }
    }
}
