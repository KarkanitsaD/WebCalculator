using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class Square : IOneargumentalOperation
    {
        public double Argument { get; set; }

        public IOperation Clone()
        {
            double a = Argument;
            return new Square() { Argument = a };
        }

        public double GetResult()
        {
            return Argument * Argument;
        }

        public string GetSymbolString()
        {
            return "square:";
        }

        public override string ToString()
        {
            return "square(" + Argument + ") = ";
        }
    }
}
