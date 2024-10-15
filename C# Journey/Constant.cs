using System;
namespace Constants
{
class Program
    {
        static void Main(string[] args)
        {
            //use const keyword to declare var with fixed values
            const double gravityForce = 9.8;
            const double PI = 3.14159265359;
            // gravityForce = 1; //it's wrong so to avoid it use const datatype to fix its value and cannot assign any new value
            Console.WriteLine("Gravity Force is: {0} and PI value is: {1}.", gravityForce , PI);
            Console.WriteLine("Gravity Forse is: " + gravityForce + " and PI value is: " + PI + "." );
            
            const double speedOfLight = 2.9 * 1000000000;
            Console.WriteLine(speedOfLight + " m/s is the speed of light");
        }
    }
} 
    
