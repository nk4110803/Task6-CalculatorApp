using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public interface IOperationFactory
    {
        IOperation GetOperation(char operatorChar);
    }
}