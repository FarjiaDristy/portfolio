using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            string s = Console.ReadLine();
            string even = "", odd = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    even += s[i];
                else
                    odd += s[i];
            }

            Console.WriteLine(even + " " + odd);
        }
    }
}
