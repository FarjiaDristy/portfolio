using System;

class StringInterpolation
{
    public static void Run()
    {
        int a = 100;
        float b = 250.50f;
        string c = "CSharp";

        Console.WriteLine("From StringInterpolationExample class:");

        Console.WriteLine($"The value of a={a}, the value of b={b} and the value of c={c}");
        Console.WriteLine($"Uppercase: {c.ToUpper()}");
    }
}
