using System;

class StringFormatting
{
    public static void Run()
    {
        float f1 = 123.45f;
        int i1 = 20000;

        // Spacing and alignment: indexes
        Console.WriteLine("{0,15} {1,10}", "Float Val", "Int Val");
        Console.WriteLine("{0,15} {1,10}", f1, i1);

        // Spacing and alignment: interpolation
        Console.WriteLine($"{ "Float Val",15} { "Int Val",10}");
        // formattting
        Console.WriteLine($"{f1,15} {i1,10}");

        double price = 45.6789;
        DateTime today = DateTime.Now;
        int number = 1234;

        Console.WriteLine();
        Console.WriteLine("String Formatting Examples:");

        Console.WriteLine("Number format: {0}", number);
        Console.WriteLine("Currency format: {0:C}", price);
        Console.WriteLine("Fixed decimal format: {0:F2}", price);
        Console.WriteLine("Date format: {0:dd-MM-yyyy}", today);
    }
}
