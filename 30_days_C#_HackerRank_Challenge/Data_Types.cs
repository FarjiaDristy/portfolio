
class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        int UserInto; double UserDoubleo; string UserStringo; 

        UserInto = Convert.ToInt32(Console.ReadLine());
        UserDoubleo = Convert.ToDouble(Console.ReadLine());
        UserStringo = Console.ReadLine();
        
        Console.WriteLine(i + UserInto);
        Console.WriteLine((d + UserDoubleo).ToString("F1"));
        Console.WriteLine(s + UserStringo);
    
    }
}
