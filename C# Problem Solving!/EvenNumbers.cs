using System;
namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //print even numbers using for loop
            for (int f = 0; f <= 10; f += 2)
            {
                Console.WriteLine(f);
            }

            //print even number using while loop
            int g = 0;
            while (g <= 10)
            {
                Console.WriteLine(g);
                g += 2;
            }
          
            //another style
            int h = 0;
            while (h % 2 == 0 && h <= 10)
            {
                Console.WriteLine(h); ;
                h += 2;
            }
          
            //another method for even num using for loop
            for (int r = 0; r <=100; r++)
            {
                if (r % 2 == 0)
                    Console.Write(r + ", ");
            } 
 
        }
    }
}
