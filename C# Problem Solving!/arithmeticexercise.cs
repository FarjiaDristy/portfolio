 //doing arithmetic operations using user input:
using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int add, sub, mult, rem;
            float div;
            Console.WriteLine("\n" + "Enter No 1: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no 2: ");
            y = int.Parse(Console.ReadLine());

            add = x + y;
            Console.WriteLine(x + " + " + y + " = " + add);

            sub = x - y;
            Console.WriteLine(x + " - " + y + " = " + sub);

            mult = x * y;
            Console.WriteLine(x + " * " + y + " = " + mult);

            div = (float)x / (float)y;
            Console.WriteLine(x + " / " + y + " = " + div);

            rem = x % y;
            Console.WriteLine(x + " % " + y + " = " + rem);
        }
    }
}
