using System;
class Program
{
    static void Main(string[] args)
    {
        StringInterpolation.Run();
        StringFormatting.Run();

        Console.WriteLine("Hello, World!");

        int a = 100;
        float b = 250.50f;
        string c = "CSharp";

        // default
        Console.WriteLine("The value of a={0}, the value of b={1} and the value of c={2}", a, b, c);

        // string interpolation
        Console.WriteLine($"The value of a={a}, the value of b={b} and the value of c={c}");

        // interpolated string
        Console.WriteLine($"The value of (a + b)/b={(a + b) / b}");
        Console.WriteLine($"The value of {c} in upper-case={c.ToUpper()}");

        // objects embedded in string interpolation
        DateTime now = DateTime.Now;
        Console.WriteLine($"The current date and time is {now}");
    }
}   
