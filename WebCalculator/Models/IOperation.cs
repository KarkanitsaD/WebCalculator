using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public interface IOperation
    {
        string GetSymbolString();
        IOperation Clone();
        double GetResult();
    }
}
