using System;
namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop syntax: for(i = 1; i>=10; i++)
          
            // 1, 2 ... 10
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i); 
                Console.WriteLine(" is the value.");
            }

            //10, 9 ...1
            for (int j = 10; j >=1; j--) 
            {
                Console.WriteLine(j + " is the value.");
            }
                      
          //even numbers
          for (int k = 0; k <= 40; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write($"{k}, ");
                }
            }
        }
    }
}
