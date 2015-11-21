using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class Nume
    {
        public string Num { get; }

        public Nume(string num)
        {
            Num = num;
        }

        public override bool Equals(object obj)
        {
            var num = (Nume)obj;
            return Num.Equals(num.Num);
        }

        public override int GetHashCode()
        {
            return Num.GetHashCode();
        }

        public override string ToString()
        {
            return Num;
        }
    }
}
