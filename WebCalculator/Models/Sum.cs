using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class Sum: IBiargumentalOperation
    {
        public double FirstArgument { get; set; }
        public double SecondArgument { get; set; }

        public IOperation Clone()
        {
            double f = FirstArgument;
            double s = SecondArgument;
            return new Sum() { FirstArgument = f, SecondArgument = s};
        }

        public double GetResult()
        {
            return FirstArgument + SecondArgument;
        }

        public string GetSymbolString()
        {
            return "+";
        }


        public override string ToString()
        {
            return FirstArgument.ToString() + " " + GetSymbolString() + " " + SecondArgument.ToString() + " " + "=" + " ";
        }
    }
}
