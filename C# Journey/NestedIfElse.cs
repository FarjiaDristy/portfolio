using System;
namespace ComparisonOperatorsWithNestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==, !=, >, <, >=, <= (equal, not equal, greater, less than, greater or equal to, less than or equal to)
            int x, y;
            Console.WriteLine("Insert value of x = ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert value of y = ");
            y = int.Parse(Console.ReadLine());

            if (x == y) //just if condition e {} na dileo hoy
                Console.WriteLine("x is equal to y.");
            else if (x != y) 
            {
                if (x < y)//nested elseif
                {
                    Console.WriteLine("x is smaller than y.");
                }
                else if (x > y)
                {
                    Console.WriteLine("y is smaller than x.");
                }
            }

            int a, b;
            Console.WriteLine("choose the values for a and b inputs.");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("values are the same");
            else if (a != b)
            {
                if (a < b)
                {
                    Console.WriteLine("A is smaller than B.");
                }
                else if (a > b)
                {
                    Console.WriteLine("b is smaller than and a");
                }
            }
        }
    }
}

