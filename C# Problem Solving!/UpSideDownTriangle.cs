using System;
namespace NestedTriangleParctice
{
    class Program
    {
        static void Main(string[] args)
        {
            //upsidedown triangle
            int high = 6;
            for (int i =0; i<= high -1;i++)
            {
                for (int j =0; j<= high -i -1; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
