using System;
namespace ConditionalIfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 10;
            if (x < y)
            {
                Console.WriteLine("Y is the greater number.\n");
            }
            else if (y < x)
            {
                Console.WriteLine("Number X is the greater number.\n");
            }
            else if (x == y) // double == is correct for int, single = is bool, other conditional signs are >,<,!=,||,&&,<=,>=
            {
                Console.WriteLine("Number X and Y are equal.\n");
            }

            int a, b;
            a = 1; b = 3;
            Console.WriteLine("Enter input a = ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter input b = ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is greater than b.");
            }
            else if (b > a)
            {
                Console.WriteLine("a is smaller than  b.");
            }
            else // else if er place e else dibo mane uporer kono condition na hoiye onno jai ashuk else condition apply hobe tate
            {
                Console.WriteLine("a and b are equal.");
            }

                int s = 40;
                int d = 20;
                Console.WriteLine("Choose between the two numbers: {0} and {1}", s, d);
                int f = int.Parse(Console.ReadLine());

            //or directly take input value and change conditions to (s == 20), (f == 40), (s == 20 || f == 40), (s != 20 || f != 40)
            //s = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());
            Console.WriteLine(f);

                if (f == 20)
                {
                    Console.WriteLine("Great you chose the smaller value!");
                }
                else if (f == 40)
                {
                    Console.WriteLine("Ambitious, you chose the greater value!");
                }
                else if (f != 20 || f != 40)
                {
                    Console.WriteLine("Thinking out of the box I see!");
                }
        }
    }
}
