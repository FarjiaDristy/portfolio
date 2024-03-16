using System;
namespace Practice3tWeekDayWithColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year it is?");
            int year = int.Parse(Console.ReadLine()); 
            Console.WriteLine("What month it is?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What day it is?");
            int day = int.Parse(Console.ReadLine());

            DateTime weekDay = new DateTime(year, month, day); 
            Console.WriteLine("Today is : " + weekDay.DayOfWeek);

            string weekDate = weekDay.DayOfWeek.ToString(); 
            switch (weekDate)
            {
                case "Saturday": Console.WriteLine("\n" + "Color of the day is Red."); break;
                case "Sunday": Console.WriteLine("\n" + "Color of the day is Yellow."); break;
                case "Monday": Console.WriteLine("\n" + "Color of the day is Pink."); break;
                case "Tuesday": Console.WriteLine("\n" + "Color of the day is Orange."); break;
                case "Wednesday": Console.WriteLine("\n" + "Color of the day is Purple."); break;
                case "Thursday": Console.WriteLine("\n" + "Color of the day is Blue."); break;
                case "Friday": Console.WriteLine("\n" + "Color of the day is Green."); break;
            }
        }
    }
}
