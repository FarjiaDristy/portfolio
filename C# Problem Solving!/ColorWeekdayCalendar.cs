using System;
using System.Diagnostics.CodeAnalysis;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom weekday calendar to choose specific colors each day
            var dayOfWeek = DateTime.Now.DayOfWeek.ToString();

            switch (dayOfWeek)
            {
                case "Saturday": Console.WriteLine("Green"); break;
                case "Sunday": Console.WriteLine("Purple"); break;
                case "Monday": Console.WriteLine("Blue"); break;
                case "Tuesday": Console.WriteLine("Pink"); break;
                case "Wednesday": Console.WriteLine("Yellow"); break;
                case "Thursday": Console.WriteLine("Red"); break;
                case "Friday": Console.WriteLine("Purple"); break;
            }
            Console.WriteLine(dayOfWeek);
        }
    }
}
