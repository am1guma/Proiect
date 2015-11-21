using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Grupa
    {
        public int Grup { get; }

        public Grupa(int grupa)
        {
            Grup = grupa;
        }

        public override bool Equals(object obj)
        {
            var grupa = (Grupa)obj;
            return Grup.Equals(grupa.Grup);
        }

        public override int GetHashCode()
        {
            return Grup.GetHashCode();
        }

        public override string ToString()
        {
            return Grup.ToString();
        }
    }
}
