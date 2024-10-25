using System;
namespace NestedTriangleParctice
{
    class Program
    {
        static void Main(string[] args)
        {
            //center triangle and christmas tree
            for (int i =0; i <= high -1; i++)
            {
                for (int j =0; j<= high - i -1; j++)
                {
                    Console.Write(" ");
                }
                for (int k =0; k< i*2 +1; k++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int m =0; m<= 3; m++)
            {
                for (int n =0; n<=high-1; n++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
