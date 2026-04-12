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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int maxCount = 0, current = 0;

        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                current++;
                if (current > maxCount)
                    maxCount = current;
            }
            else
            {
                current = 0;
            }

            n >>= 1;
        }

        Console.WriteLine(maxCount);
    }
}
