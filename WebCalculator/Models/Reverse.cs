using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class Reverse : IOneargumentalOperation
    {
        public double Argument { get; set; }

        public IOperation Clone()
        {
            double a = Argument;
            return new Reverse() { Argument = a };
        }

        public double GetResult()
        {
            return 1 / Argument;
        }

        public string GetSymbolString()
        {
            return "reverse:";
        }

        public override string ToString()
        {
            return "reverse(" + Argument + ") = ";
        }
    }
}
