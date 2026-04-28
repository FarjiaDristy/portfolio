using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int superDigit(string n, int k)
    {
        long initialSum = 0;

        foreach (char c in n)
        {
            initialSum += (c - '0');
        }

        long total = initialSum * k;

        return GetSuperDigit(total);
    }

    static int GetSuperDigit(long n)
    {
        if (n < 10) return (int)n;

        long sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return GetSuperDigit(sum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
