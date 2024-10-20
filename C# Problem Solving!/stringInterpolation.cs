using System;
using System.Security.Cryptography.X509Certificates;
namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName = "";
            Console.WriteLine("what's your name?");
            yourName = Console.ReadLine();
            Console.WriteLine($"nice to meet you {yourName.ToUpper()}.);
        }
    }
}
