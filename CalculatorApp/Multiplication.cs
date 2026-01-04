using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Multiplication: IOperation
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
