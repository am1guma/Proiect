using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Entities
{
    public class Facultate
    {
        public List<Secretariat> Secretariate { get; }
        public NumeFacultate NumeFacultate { get; }
        internal Facultate(NumeFacultate nf)
        {
            NumeFacultate = nf;
        }
        public void CreeazaSecretariat(Secretariat sec)
        {
            Secretariate.Add(sec);
        }
    }
}
