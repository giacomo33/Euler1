using Euler1.Extensions;
using System;
using System.Linq;

namespace Euler1
{
    class Program
    {
        //The problem:
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.

        static void Main(string[] args)
        {
            Console.WriteLine("Application will sum multiples of 3 or 5 for any given integer");
            CalculateEuler1();
           
        }

        static void CalculateEuler1()
        {
            Console.WriteLine("Enter an Integer: ");
            string textEntered = Console.ReadLine();
            int numEntered = textEntered.ReadOnlyNumbers();
            int sum= numEntered.GetNumbersMultiple3or5()
               .Sum();
            Console.WriteLine("Euler1: {0}", sum);
            Console.WriteLine("Enter another number Y or N");
            ConsoleKeyInfo selection = Console.ReadKey();
            if (selection.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                CalculateEuler1();
            }
            else if (selection.Key == ConsoleKey.N)
                return;
        }
    }
}
