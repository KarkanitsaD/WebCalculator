using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Services
{
    public class CalculatorService: ICalculatorService
    {
        private static CalculatorService instance = null;
        private CalculatorService()
        {

        }

        public double Difference(double x, double y)
        {
            return x - y;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }

        public static CalculatorService GetCalculatorService()
        {
            if (instance == null)
                instance = new CalculatorService();
            return instance;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Reverse(double x)
        {
            if (x == 0)
                throw new ArgumentOutOfRangeException("На наль делить нельзя!");
            return 1 / x;
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
