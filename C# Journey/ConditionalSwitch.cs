using System;
using System.Runtime.InteropServices;
namespace ConditionalSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you enjoying C#? (Write Yes or No)");
            string input = Console.ReadLine();

            //switch case break
            switch (input) 
            {
                case "yes": Console.WriteLine("This is great."); break;
                case "No": Console.WriteLine("No, it is not that great."); break;
                //default works like else, if none of the conditions aren't met, it'll choose default
                default: Console.WriteLine("This not a correct answer."); break;
            }

            Console.WriteLine("Choose from the numbers: (10,20,40, 0, or anything you prefer)");
            var enter = Console.ReadLine(); //better to use int.parse/try.parse just in case
            switch (enter)
            {
                case "40": Console.WriteLine("ok it's $40 for you."); break;
                case "20": Console.WriteLine("ok you get 20 gold coins."); break;
                case "10": Console.WriteLine("10 nuggets for you.");break;
                case "0": Console.WriteLine("you get nothing");break;
                default:Console.WriteLine("you get a surprise box");break;
            }
        }
    }
}
