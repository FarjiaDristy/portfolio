using System;
using System.Diagnostics.CodeAnalysis;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //take user input name and age using datetime function?
            string Name;
            Console.WriteLine("What is your Name?");
            Name = Console.ReadLine();


            Console.WriteLine("Nice to Meet You {0} My name is C#. How old are you?", Name);
            int.TryParse(Console.ReadLine(), out int age);

            if (age == 0)
            {
                Console.WriteLine("incorrect input");
            }
            else
            {
                Console.WriteLine("{0} is good, As for me I was born on 2002. Which makes me {1} years old.\n", age, DateTime.Now.Year - 2002);
            }
        }
    }
}
