using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math : IMath
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
                
        public int intPlus(int A, int B)
        {
            return A + B;
        }

        public int intMinus(int A, int B)
        {
            return A - B;
        }

        public int intMultiply(int A, int B)
        {
            return A * B;
        }

        public int intDivision(int A, int B)
        {
            return A / B;
        }


    }
}
