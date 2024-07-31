using System;
namespace DatatypeVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //#Practice 1
            int x = 1;
            Console.WriteLine("The integer x is a number " +x);  // here plus is concatenation

            x = 5;
            Console.WriteLine("The x is a number " +x);

            double double_x = 0.06d; //can also name it double_num
            float float_x = 0.02f;
            decimal decimal_x = 101.9m;
            Console.WriteLine("double is " +double_x+ " float is " +float_x+ " decimal is " +decimal_x);

            double_x = .125d; //when you write same variable with new value it overwrites the old one
            Console.WriteLine(decimal_x);
            Console.WriteLine(double_x);
            Console.WriteLine(float_x);

            //#Practice 2
            char letter_a = 'A'; //single quote
            string firstName = "Farjia"; //double quote
            string midName = "Ahamed";
            string lastName = "Dristy";
            Console.WriteLine("Hello, my name is " +firstName+ " " +midName+ " " +lastName);

            string FirstName, MidName, LastName; //C# is case sensitive
            FirstName = "Farjana";
            MidName = "Ahamed";
            LastName = "Duha";
            Console.WriteLine("Hi, it's me " +letter_a+   FirstName+ " " +MidName+ " " +LastName+ ".");
            Console.WriteLine("Hi, it's me " + letter_a + " " +FirstName + MidName + LastName);

            //#Practice 3
            bool isWorking, isNotWorking;
            isWorking = true;
            isNotWorking = false;
            Console.WriteLine("Not " + isNotWorking+ ", it's " + isWorking + ", Jews people are cheap and evil.");

            //#Practice 3.1
            int sum;
            sum = 0;
            int num1 = 5;
            int num2 = 3;
            Console.WriteLine(sum); //it will attach to the next statement
            Console.Write(sum); 
            sum = num1 + num2;
            Console.WriteLine(sum);

            //#Practice 4
            string X = "Dristy";
            int Y = 23; // here = is not math's equal but assig or set value
            Console.WriteLine("The number Y is " + Y ); // here + is concatanation
            Console.WriteLine(" Assalam Alaikum, I'm " + X + " and I'm " + Y); 
        }
    }
}
