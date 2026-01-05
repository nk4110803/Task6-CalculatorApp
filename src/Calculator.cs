using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Calculator
    { 

        private readonly IOperationFactory _operationFactory;
        public Calculator(IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
        }
        public int Calculate(string s)
        {
            s = s.Replace(" ", "");
            if (string.IsNullOrEmpty(s)) return 0;
            char[] operators = { '+', '-', '*', '/' };
            foreach (var op in operators)
            {
                int opIndex = s.LastIndexOf(op);
                if (opIndex > 0)
                {
                    string leftSide = s.Substring(0, opIndex);
                    string rightSide = s.Substring(opIndex + 1);
                    int leftValue = Calculate(leftSide);
                    int rightValue = Calculate(rightSide);
                    var operation = _operationFactory.GetOperation(op);
                    return operation.Execute(leftValue, rightValue);
                }
            }
            return int.Parse(s);
        }
    }

}
