using System;
namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Insert number = ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 ==0)
            {
                Console.WriteLine(x + " number is even.");
            }
            else
            {
                Console.WriteLine(x + " number is odd.");
            }
        }
    }
}
