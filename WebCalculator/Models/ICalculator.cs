using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public interface ICalculator
    {
        double Calculate();
        IOperation GetLastOperation();
        void ClearOperations();
        IOperation CurrentOperation { get; set; }
    }
}
