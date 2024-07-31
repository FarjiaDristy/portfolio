using System;
namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //take userinput using readline
            Console.WriteLine("What's your name?");
            //can only read string type, for other datatype you gotta  use parse, intparse, or tryparse
            string name = Console.ReadLine();
            Console.WriteLine("write your name: {0}", name); //including placeholder
            //using concatanation
            Console.WriteLine("Hi " + name + ", Welcome!");
        }
    }
}
