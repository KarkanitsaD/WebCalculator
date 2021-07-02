using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class SquareRoot : IOneargumentalOperation
    {
        public double Argument { get; set; }

        public IOperation Clone()
        {
            double a = Argument;
            return new SquareRoot() { Argument = a };
        }

        public double GetResult()
        {
            return Math.Sqrt(Argument);
        }

        public string GetSymbolString()
        {
            return "squareRoot:";
        }

        public override string ToString()
        {
            return "sqrt(" + Argument + ") = ";
        }
    }
}
