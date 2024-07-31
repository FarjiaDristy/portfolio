using System;
using System.Diagnostics.CodeAnalysis;

namespace ErrorTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax Errors - error in code like: missing :, "", etc.
            //Runtime Errors - an exceptional error when the code is right but it still crashes
            //Logical Errors - logically wrong statements in the code = like attempting to divide by zero
            int a, b, c;
            a = 1; b = 4; c = 6;
            var sum = a + b - c;
            var divide = a / b;
            Console.WriteLine(divide + " LOL" + sum);
        }
    }
}
