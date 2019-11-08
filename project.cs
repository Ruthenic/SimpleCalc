using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // cast all variables
            int num1 = 0;
            int num2 = 0;
            string expression = "+";
            int answer = 0;

            // ask for numbers
            Console.WriteLine("Enter first number (integer):");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter expression (+, x, -):");
            expression = Console.ReadLine();
            Console.WriteLine("Enter second number (integer):");
            num2 = Convert.ToInt32(Console.ReadLine());

            // figure out what expression(operation) to use, then do the expression
            if (expression == "+")
            {
                answer = num1 + num2;
            }
            if (expression == "-")
            {
                answer = num1 - num2;
            }
            if (expression == "x")
            {
                answer = num1 * num2;
            }

            // display answer
            Console.Write("The answer is: ");
            Console.Write(answer);

            //wait until key pressed and shutdown program
            Console.WriteLine("");
            Console.WriteLine("Press any key to shutdown the program");
            Console.ReadKey();
        }
    }
}
