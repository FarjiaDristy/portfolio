using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //+, -, *, /, % (addition, subtraction, multiplication, division, remainder) 
            int a, b, c;
            a = 5; b = 10; c = 12;
            int addition = a + b;
            int subtraction = b - c;
            int multiplication = a * b;
            int division = b / a;
            int remainder = c%a;
            int result = addition + subtraction;

            Console.WriteLine("addition: " + addition + "\nsubtraction: "+substraction+ "\nmultiplication: " +multiplication+ "\ndivision: " +division+ "\nremainder: " +remainder + "\nresult=" + result);

            //practice noob style
            int d, e;
            d = 5; e = 2;
            int sum = 0;
            int addd = d + e;
            int subb = d - e;
            int multt = d * d;
            float divv = (float)d / (float)e;
            int remain = d % e;
            Console.WriteLine("\n" + "5 + 2 = " + addd + "\n5 - 2 = " + subb + "\n5 * 2 = " + multt + "\n5 / 2 = " + divv + "\n5 % 2 = " + remain + sum);

            //precedence of operators (), *, /, +, -, =
            int z;
            z = (2 + 3) * 2 - 4 + 2;
            Console.WriteLine("\n" +z);

        }
    }
}
