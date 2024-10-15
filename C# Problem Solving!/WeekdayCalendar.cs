using System;
using System.Diagnostics.CodeAnalysis;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //make a weekday calendar by taking user input
            Console.WriteLine("Enter the day = ");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month = ");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year");
            var year = Console.ReadLine();

            DateTime Date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(month));
            Console.WriteLine("\n" + Date.DayOfWeek);

            //OR
            DateTime todate = new DateTime(2050, 12, 1);
            Console.WriteLine(todate.DayOfWeek);
        }
    }
}
