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
            a = a + b; 
            b = a - b; 
            a = a - b; 
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
