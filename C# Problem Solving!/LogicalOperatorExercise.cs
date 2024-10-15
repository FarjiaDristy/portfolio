using System;
namespace LogicalOperatorsWithIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool username = true;
            bool email = true;
            bool password = false;
            if ((username || email) && password) 
            {
                Console.WriteLine("User info is valid.");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

            bool isStudent = true;
            bool studyComplete = true;
            bool isDropOut = false;

            Console.WriteLine("are you a student? answer in true and false");
            isStudent = bool.Parse(Console.ReadLine());
            Console.WriteLine("are you a dropout? answer in true and false");
            isDropOut = bool.Parse(Console.ReadLine());
            Console.WriteLine("is your study complete? answer in true and false");
            studyComplete = bool.Parse(Console.ReadLine());

            if (isStudent && studyComplete)
            {
                Console.WriteLine("You are eligible for the job interview.");
            }
            else if (isStudent == true || isDropOut == true)
            {
                Console.WriteLine("Do you have any strong skill? to replace the others with complete education background");
            }
            else if (!isStudent || isDropOut || !studyComplete)
            {
                Console.WriteLine("We're sorry but you don't meet the minimum threshold of the education requirement.");
            }
            else if ((isStudent == true && studyComplete == true) || isDropOut == false)
            {
                Console.WriteLine("show your skill sets then we will proceed.");
            }
            else
                Console.WriteLine("we are sorry but you can leave now. ");
              }
       }
}
