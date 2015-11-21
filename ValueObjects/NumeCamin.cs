using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class NumeCamin
    {
        public string NumCamin { get; }

        public NumeCamin(string numCamin)
        {
            NumCamin = numCamin;
        }

        public override bool Equals(object obj)
        {
            var numCamin = (NumeCamin)obj;
            return NumCamin.Equals(numCamin.NumCamin);
        }

        public override int GetHashCode()
        {
            return NumCamin.GetHashCode();
        }

        public override string ToString()
        {
            return NumCamin;
        }
    }
}
