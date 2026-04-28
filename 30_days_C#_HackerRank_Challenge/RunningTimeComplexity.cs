using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0) {
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n)) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }

    static bool IsPrime(int n) {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        
        for (int i = 3; i * i <= n; i += 2) {
            if (n % i == 0) return false;
        }
        return true;
    }
}
