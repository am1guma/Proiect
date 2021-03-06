﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjects;

namespace Entities
{
    public class Facultate
    {
        public Secretariat Secretariat { get; internal set; }
        public NumeFacultate NumeFacultate { get; }
        public Facultate(NumeFacultate nf)
        {
            NumeFacultate = nf;
        }
        public void CreeazaSecretariat(Secretariat sec)
        {
            Secretariat = sec;
        }
        public override bool Equals(object obj)
        {
            var facultate = (Facultate)obj;
            return NumeFacultate.Equals(facultate.NumeFacultate);
        }
        public override int GetHashCode()
        {
            return NumeFacultate.GetHashCode();
        }
        public override string ToString()
        {
            return NumeFacultate.ToString();
        }
    }
}
