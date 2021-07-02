using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculator.Models
{
    public class Calculator : ICalculator, IEnumerable
    {
        private Stack<IOperation> operations = new Stack<IOperation>();
        public IOperation CurrentOperation { get; set; }

        public double Calculate()
        {
            operations.Push(CurrentOperation.Clone());
            return CurrentOperation.GetResult();
        }

        public void ClearOperations()
        {
            operations.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return operations.GetEnumerator();
        }

        public IOperation GetLastOperation()
        {
            return operations.Peek();
        }
    }
}
