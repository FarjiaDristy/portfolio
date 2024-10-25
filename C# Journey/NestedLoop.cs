
using System;
namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //nested loop: loop inside a loop
            Console.WriteLine("Square using Nested Loop. \n");
             for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
          

            Console.WriteLine("\ntriangle using nested loop\n");
            for(int x = 1; x <= 5; x++)
            {
                for(int y = 1; y <= x; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();    
            }

        }
    }
}
