using System;
namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAN FIND ALL THE FUNCTION OF CALCULATORS ALMOST
            Console.WriteLine("Usage of math classes to find different numerical variable\n");

            double x = 4.23321;
            Console.WriteLine(Math.Ceiling(x) + $"ceiling value is {x}."); //ceiling = rounds a number up to the nearest integer while considering the numbers after point
            Console.WriteLine(Math.Floor(x) + $"floor value {x}."); //floor = only considers integer
            Console.WriteLine(Math.Round(x) + $"round value is {x}.");//round = only considers integer if not specified 
            Console.WriteLine(Math.Round(x,2) + $"specified round value of {x}.");//specified to round up both integer and float value
            Console.WriteLine(Math.Truncate(x) + $" is the truncate value of {x}.");//removes the fractional part of a number

            int i = 9;
            int j = 5;
            Console.WriteLine(Math.Max(i, j) + $" is the max value between {i} and {j}.");//max
            Console.WriteLine(Math.Min(i, j) + $" is the min value between {i} and {j}.");//min
            //Console.WriteLine(Math.Min(22, 44));
          
            Console.WriteLine(Math.Sqrt(i) + $" is the square root value of {i}.");//sqrt square root
            //Console.WriteLine(Math.Sqrt(i) + Math.Sqrt(j)); 
          
            Console.WriteLine(Math.Pow(i, j) + $" is the value of {i} to the power of {j} = (9^5).");///or Pow(2, 3) //pow = power
            //Console.WriteLine(Math.Pow(i, Math.PI));
          
            Console.WriteLine(Math.PI + $" is the square value of PI.");//pi
            Console.WriteLine(Math.Log(i, 2) + $" is the log value of {i}.");//log
            //Console.WriteLine(Math.Log(i,j));
        }
    }
}
