using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace src
{
    public class OperationFactory: IOperationFactory
    {
        private readonly Dictionary<char, IOperation> _operations = new()
        {
            { '+', new Addition() },
            { '-', new Subtraction() },
            { '*', new Multiplication() },
            { '/', new Division() }
        };
        public IOperation GetOperation(char operatorChar)
        {
            if (_operations.ContainsKey(operatorChar))
                return _operations[operatorChar];
            throw new NotSupportedException($"Operation {operatorChar}is not supported");
        }
    }
}
