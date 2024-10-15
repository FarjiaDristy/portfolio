using System;
namespace LogicalOperatorsWithIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //and operator = && (both conditions to be true) or operator = || (any conditions to be true)
            //and operator
            bool HasLicense = false;
            bool CanDrive = true;
            if (HasLicense == true && CanDrive == true) 
            {
                Console.WriteLine("You are eligible to be driver.");
            }
            else if (CanDrive == true && HasLicense == false)
            {
                Console.WriteLine("Sorry, we don't do illegal activity here.");
            }    
            else if (CanDrive == false && HasLicense == true)
            {
                Console.WriteLine("Are you a cheater?");
            }
            else
            {
                Console.WriteLine("You are not eligible to be a driver.");
            }
            bool TookShower = false;
            bool WentForSwim = false;
            if (TookShower || WentForSwim)
            {
                Console.WriteLine("He is wet.");
            }            
            else if (!TookShower || !WentForSwim)
            {
                Console.WriteLine("He is dry.");
            }
        }
    }
}
