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

class Solution {
    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> names = new List<string>();

        for (int i = 0; i < N; i++) {
            string[] inputs = Console.ReadLine().Split(' ');
            string firstName = inputs[0];
            string emailID = inputs[1];

            if (emailID.EndsWith("@gmail.com")) {
                names.Add(firstName);
            }
        }

        names.Sort();
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }
}
