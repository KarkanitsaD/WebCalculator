using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public interface IBiargumentalOperation: IOperation
    {
        
        double FirstArgument { get; set; }
        double SecondArgument { get; set; }
    }
}
