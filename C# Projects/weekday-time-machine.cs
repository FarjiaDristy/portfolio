using System;
namespace TimeMachineWhatWeekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year it is?");
            int year = int.Parse(Console.ReadLine()); // or var year = Console.ReadLine();

            Console.WriteLine("What month it is?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What day it is?");
            int day = int.Parse(Console.ReadLine());

            DateTime weekDay = new DateTime(year, month, day); // 
            Console.WriteLine("Today is : " + weekDay.DayOfWeek); // {0} na dile , kaaj kore nai. or {0}ar , na use korle need to use + concatanation
        }
    }
}
