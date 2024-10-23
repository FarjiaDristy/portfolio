using System;
namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is while loop.");
            //syntax: initialize; while(condition) {statement1; statement2; increment;};
          
            //1, 2 ... 10
            int y = 0;
            while (y <= 10)
            {
                Console.WriteLine($"this is line no {y} in While Loop."); 
                y++; 
            }
            Console.WriteLine("-----");
          
            // 10, 9 ... 1
            int a = 10;
            while (a >= 0)
            {
                Console.WriteLine(a); 
                a--;
            }
            Console.WriteLine("-----");
          
            // noob style even number
            int x = 0;
            while (x % 2 == 0 && x <= 10) 
            {
                Console.WriteLine(x + " is an even number.");
                x += 2;
            }
            Console.WriteLine("-----");

            int brek = 10;
            while (brek >=1)
            {
                if (brek == 9)
                    break;
                Console.WriteLine(brek);
                brek--;
            }
        }
    }
}
