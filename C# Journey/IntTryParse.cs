using System;
namespace TryParseParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //intparse converts string into int, try parse converts string into any specified variable
            //int.parse = it'll only print integer inputs or else show error 
            //tryparse = it'll take all inputs but other datatypes (string) except int will return 0 (zero) to show invalid
            
            int x = 0;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number x: " + x); 

            int y;
            int.TryParse(Console.ReadLine(), out y); 
            int.TryParse(Console.ReadLine(), out int z);
            Console.WriteLine("Enter number y: " + y);

            if (y == 0)
            {
                Console.WriteLine("Input is invalid");
            }
            else
            {
                Console.WriteLine("The number entered is {0}", y);
            }
        }
    }
}
