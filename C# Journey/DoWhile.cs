using System;
namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO WHILE LOOP syntax: initialize; do{statement; increment;} while(condition);
            //even numbers
            Console.WriteLine("THIS IS DO WHILE LOOP \n");
            int x = 0;
            do
            {
                Console.WriteLine($"{x} is the even number.");
                    x += 2;
            } while (x <= 10);
          
            //odd number
            int a = 1;
            do
            {
              Console.WriteLine($"{a} is an odd number.");
              a += 2;
            } while (a <= 10);

            //0,1 ... 10
            Console.WriteLine("This is increment");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
          
            //10, 9 ... 1
            Console.WriteLine("This is decrement");
            int j = 10;
            do
            {
                Console.WriteLine(j);
                j--;
            } while (j >= 1);

        }
    }
}
