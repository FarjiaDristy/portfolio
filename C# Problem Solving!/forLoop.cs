using System;
namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop syntax: for(i = 1; i>=10; i++)
          
            // 1 ... 10
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i); 
                Console.WriteLine(" is the value.");
            }

            //10 ...1
            for (int j = 10; j >=1; j--) 
            {
                Console.WriteLine(j + " is the value.");
            }
        }
    }
}
