using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialCount = 1;
            Console.WriteLine("Enter a number to check its Factorial: ");
            int number=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorialCount *= i;
            }
            Console.WriteLine("Factorial of " + number + " is " +factorialCount);
        }
    }
}
