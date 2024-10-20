//take two user inputs, remove unnecessary white spaces, and print using string manipulation.
using System;
namespace StringManipulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = Console.ReadLine().Trim();
            string movieSeason = Console.ReadLine().Trim();
            string newMovie = "";
            newMovie = movieTitle.Insert(movieTitle.Trim().Length, " - " + movieSeason.Trim());
            Console.WriteLine(newMovie);
        }
    }
}
