using System;
namespace DateTimeExTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Format: 19-02-2024 01:15:55
            DateTime date = DateTime.Now;
            string firstFormat = string.Format("First Format: {0:dd-MM-yyyy HH:mm:ss tt}", date); //small mm also works wow
            Console.WriteLine(firstFormat);

            //Second Format: Monday Of Month Frebruary 2024
            string secondFormat = string.Format("Second Format: {0:dddd 'of Month' MMMM 'year' yyyy}" , date); // to show anything inside {0:yyyy MM dd} expression '' use single quotes to write it
            Console.WriteLine(secondFormat);

            //Third Format: Day Monday
            string thirdFormat = string.Format("Third Format:{0:'Day' dddd}", date);
            Console.WriteLine(thirdFormat);

            //Fourth Format: Year 2024
            string fourthFormat = string.Format("Fourth Format: \n{0:'Year' yyyy}", date); // {} expression e 0: shobar agee na thakle error ashee
            Console.WriteLine(fourthFormat);

            //new third format Day Saturday new line month feb next line year 2024
            fourthFormat = string.Format("Fourth Format: \n{0:'Day' dddd} \n{0:'month' MMM} \n{0:'Year' yyyy}", date); // \n new line excape sequence
            Console.WriteLine(fourthFormat);
        }
    }
}
