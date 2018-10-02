using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math
    {
        private int _a;
        private int _b;
        public string _operation;

        public int A { get { return _a; } }
        public int B { get { return _b; } }

        public Math(int a, int b, string operation)
        {
            _a = a;
            _b = b;
            _operation = operation;
        }
                
        public int intPlus(int a, int b)
        {
            return a + b;
        }

        public int intMinus(int a, int b)
        {
            return a - b;
        }

        public int intMultiply(int a, int b)
        {
            return a * b;
        }

        public int intDivision(int a, int b)
        {
            return a / b;
        }


    }
}
