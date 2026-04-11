using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            phonebook[parts[0]] = parts[1];
        }

        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (phonebook.ContainsKey(query))
                Console.WriteLine(query + "=" + phonebook[query]);
            else
                Console.WriteLine("Not found");
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    }
  }
}
