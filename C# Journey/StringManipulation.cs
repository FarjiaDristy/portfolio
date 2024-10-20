using System;
namespace StringManipulation
{
    class program
    {
        static void Main(string[] args)
        {
            //manipulate the strings to find indexer, trim the strings , make the string lowercase, uppercase, find string length, replace string

            //Indexes
            string movieName = "Happy Hunger Games";
            Console.WriteLine("5th letter of the string is: " + movieName[5]); // shows the char in index 5 position

            //Trim = removes leading and trailing white spaces
            string seriesName = "     Game of Thrones . . "; 
            Console.WriteLine(seriesName.Trim());

            //Upper Case
            string myName = "The Greatest OF all tiME.";
            Console.WriteLine(seriesName.Trim().ToUpper());

            //Lower Case
            Console.WriteLine(seriesName.ToLower().Trim());

            //Length
            Console.WriteLine("length of my name is: {0}, movie name is: {2}, and series name is: {3} ", myName.Length, seriesName.Length, movieName.Length);
            Console.WriteLine("length of series name is after trimming: {0} and length my name is after trimming: {1}", seriesName.Trim().Length,  myName.Trim().Length); 
            Console.WriteLine(" Total length is " + seriesName.Trim().Length + myName.Trim().Length);

            //Replace
            Console.WriteLine(myName.Replace('a', 'A'));

            //Index of
            string tvShow = "why will women kill";
            Console.WriteLine(tvShow.IndexOf("Cool")); // index of c 0.
            Console.WriteLine(tvShow.IndexOfAny(new char[] { 'w' }));

            //Last index of
            Console.WriteLine(tvShow.LastIndexOf('w'));    
            Console.WriteLine(tvShow.LastIndexOfAny(new char[] { 'i' }));
            
            //Substring to substituting from the start to the index number given
            string boyName = "Alex Thomas Hardy";
            Console.WriteLine(boyName.Substring(8));
            Console.WriteLine(boyName.Substring(3, 8));

            //Remove.... opposite of substring
            Console.WriteLine(boyName.Remove(6));
            Console.WriteLine(boyName.Remove(6, 4));

            //Insert
            Console.WriteLine(boyName.Insert(0 ,"Robert "));
            Console.WriteLine(boyName.Insert(5, "Jr. "));
        }
    }
}
