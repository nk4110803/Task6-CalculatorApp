using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Calculator
    {
        public int Add(string s)
        {
            string[]parts= cleanInput(s).Split('+');
            int a=int.Parse (parts[0]);
            int b=int.Parse (parts[1]);
            return a + b;
        }
        public int Subtraction(string s)
        {
            string[] parts = cleanInput(s).Split('-');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            return a - b;
        }
        public int multiplication(string s)
        {

            string[] parts = cleanInput(s).Split('*');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            return a * b;
        }
        public int Division(string s)
        {

            string[] parts = cleanInput(s).Split('/');
            int b = int.Parse(parts[1]);
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            int a = int.Parse(parts[0]);
            return a / b;
        }

        private string cleanInput(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return "";
            }
            return s.Replace(" ", "");
        }

    }

}
