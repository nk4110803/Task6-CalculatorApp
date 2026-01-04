using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Calculator
    { 

        private readonly OperationFactory _operationFactory=new OperationFactory();
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

        //public int Add(string s)
        //{
        //    string[]parts= cleanInput(s).Split('+');
        //    int a=int.Parse (parts[0]);
        //    int b=int.Parse (parts[1]);
        //    return a + b;
        //}
        //public int Subtraction(string s)
        //{
        //    string[] parts = cleanInput(s).Split('-');
        //    int a = int.Parse(parts[0]);
        //    int b = int.Parse(parts[1]);
        //    return a - b;
        //}
        //public int multiplication(string s)
        //{

        //    string[] parts = cleanInput(s).Split('*');
        //    int a = int.Parse(parts[0]);
        //    int b = int.Parse(parts[1]);
        //    return a * b;
        //}
        //public int Division(string s)
        //{

        //    string[] parts = cleanInput(s).Split('/');
        //    int b = int.Parse(parts[1]);
        //    if (b == 0)
        //    {
        //        throw new DivideByZeroException();
        //    }
        //    int a = int.Parse(parts[0]);
        //    return a / b;
        //}

        //private string cleanInput(string s)
        //{
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        return "";
        //    }
        //    return s.Replace(" ", "");
        //}
    }

}
