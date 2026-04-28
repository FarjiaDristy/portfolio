using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] actual = Console.ReadLine().Split(' ');
        int d1 = int.Parse(actual[0]);
        int m1 = int.Parse(actual[1]);
        int y1 = int.Parse(actual[2]);

        string[] expected = Console.ReadLine().Split(' ');
        int d2 = int.Parse(expected[0]);
        int m2 = int.Parse(expected[1]);
        int y2 = int.Parse(expected[2]);

        int fine = 0;

        if (y1 > y2) {
            fine = 10000;
        } else if (y1 == y2) {
            if (m1 > m2) {
                fine = 500 * (m1 - m2);
            } else if (m1 == m2 && d1 > d2) {
                fine = 15 * (d1 - d2);
            }
        }

        Console.WriteLine(fine);
    }
}
