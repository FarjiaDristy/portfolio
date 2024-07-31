using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //+, -, *, /, % (addition, substraction, multiplication, division, remainder)
            int a, b, c;
            a = 5; b = 10; c = 12;
            int addition = a + b;
            int substraction = b - c;
            int multiplication = a * b;
            int division = b / a;
            int remainder = c%a;
            int result = addition + substraction;

            Console.WriteLine("addition: " + addition + "\nsubstraction: "+substraction+ "\nmultiplication: " +multiplication+ "\ndivision: " +division+ "\nremainder: " +remainder + "\nresult=" + result);

            //exercise noob style
            int d, e;
            d = 5; e = 2;
            int sum = 0;
            int addd = d + e;
            int subb = d - e;
            int multt = d * d;
            float divv = (float)d / (float)e;
            int remain = d % e;
            Console.WriteLine("\n" + "5 + 2 = " + addd + "\n5 - 2 = " + subb + "\n5 * 2 = " + multt + "\n5 / 2 = " + divv + "\n5 % 2 = " + remain + sum);

            //exercise using user input
            int x, y;
            int add, sub, mult, rem;
            float div;
            Console.WriteLine("\n" + "Enter No 1: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no 2: ");
            y = int.Parse(Console.ReadLine());

            add = x + y;
            Console.WriteLine(x + " + " + y + " = " + add);

            sub = x - y;
            Console.WriteLine(x + " - " + y + " = " + sub);

            mult = x * y;
            Console.WriteLine(x + " * " + y + " = " + mult);

            div = (float)x / (float)y;
            Console.WriteLine(x + " / " + y + " = " + div);

            rem = x % y;
            Console.WriteLine(x + " % " + y + " = " + rem);

            //precedence of operators (), *, /, +, -, =
            int z;
            z = (2 + 3) * 2 - 4 + 2;
            Console.WriteLine("\n" +z);

            //again practice
            float j, k;
            float additional, substractional, multiplicational, divisional, remaining;

            Console.WriteLine("enter the value of j:");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value of k:");
            k = int.Parse(Console.ReadLine());

            additional = j + k;
            substractional = j - k;
            divisional = j / k;
            multiplicational = j * k;
            remaining = j % k;

            Console.WriteLine(j+"+"+k +"="+ additional);
            Console.WriteLine(j + "-" + k + "=" + substractional);
            Console.WriteLine(j + "*" + k + "=" + multiplicational);
            Console.WriteLine(j + "/" + k + "=" + divisional);
            Console.WriteLine(j + "%" + k + "=" + remaining);
        }
    }
}
