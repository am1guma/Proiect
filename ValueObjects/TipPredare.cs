using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjects
{
    public class TipPredare
    {
        public string TipPred { get; }

        public TipPredare(string tipPred)
        {
            TipPred = tipPred;
        }

        public override bool Equals(object obj)
        {
            var tipPred = (TipPredare)obj;
            return TipPred.Equals(tipPred.TipPred);
        }

        public override int GetHashCode()
        {
            return TipPred.GetHashCode();
        }

        public override string ToString()
        {
            return TipPred;
        }
    }
}
