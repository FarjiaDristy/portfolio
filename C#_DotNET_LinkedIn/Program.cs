using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DotNET LinkedIn Program started\n");

        StringInterpolation.Run();

        Console.WriteLine("\n----------------\n");

        StringFormatting.Run();

        Console.WriteLine("\n----------------\n");

        StringManipulation.Run();

        Console.WriteLine("\n----------------\n");

        StringSearching.Run();

        Console.WriteLine("\n----------------\n");

        MathExample.Run();

        Console.WriteLine("\nProgram finished");
    }
}
