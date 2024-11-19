using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swappingelements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            // Swap without temp variable using addition and subtraction
            a = a + b; // a becomes 15
            b = a - b; // b becomes 5 (original value of a)
            a = a - b; // a becomes 10 (original value of b)

            Console.WriteLine($"a: {a}, b: {b}");

        }
    }
}
