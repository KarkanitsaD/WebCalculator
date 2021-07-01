using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Services
{
    interface ICalculatorService
    {
        public double Reverse(double x);
        public double Square(double x);
        public double SquareRoot(double x);
        public double Division(double x, double y);
        public double Multiplication(double x, double y);
        public double Sum(double x, double y);
        public double Difference(double x, double y);

    }
}
