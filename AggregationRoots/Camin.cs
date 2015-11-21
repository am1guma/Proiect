using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace AggregationRoots
{
    public class Camin
    {
        public Administrator Administrator { get; internal set; }
        public NumeCamin NumeCamin { get; }
        internal Camin(NumeCamin nc)
        {
            NumeCamin = nc;
        }
        public void CreeazaAdministrator(Administrator admin)
        {
            Administrator = admin;
        }

        public string SelectareStudentiCamin(List<Student> lista, int min, int max)
        {
            List<Student> cazati = lista.OrderByDescending(o => o.Medie()).ToList().FindAll
                (c => (c.Medie() <= max) && (c.Medie() >= min));
            StringBuilder sb = new StringBuilder();
            sb.Append("Studenti cazati:\n");
            foreach (Student s in cazati)
                sb.Append("     " + s.Nume + " " + s.Prenume+"\n");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            var admin = (Camin)obj;
            return Administrator.Equals(admin.Administrator);
        }
        public override int GetHashCode()
        {
            return NumeCamin.GetHashCode();
        }
        public override string ToString()
        {
            return NumeCamin.ToString();
        }
    }
    
}
