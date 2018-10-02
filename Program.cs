using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static int result;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jaka operacja? ");
            string operation = Console.ReadLine();

            Console.WriteLine("Podaj b: ");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Math m = new Math(A, B, operation);

            switch (operation)
            {
                case "+":
                    result = m.intPlus(A, B);
                    break;
                case "-":
                    result = m.intMinus(A, B);
                    break;
                case "*":
                    result = m.intMultiply(A, B);
                    break;

                case "/":
                    result = m.intDivision(A, B);
                    break;
            }

            Console.WriteLine("Twoj wynik to : " + result);
            Console.ReadKey();
        }
    }
}
