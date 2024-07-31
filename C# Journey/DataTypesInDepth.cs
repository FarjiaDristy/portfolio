using System;
namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte, byte, short, ushort, int, uint, long, ulong these datatypes are used to store integer values, their ranges are bigger than the previous one (in sequence).

            //u= unassigned (only positive numbers' range)

            int x = 0;
            x = int.MinValue;
            x = int.MaxValue;

            byte b = 0;
            b = byte.MaxValue;

            sbyte c = 0;
            c = sbyte.MaxValue;

            short d = 0;
            d = short.MaxValue;

            ushort e = 0;
            e = ushort.MaxValue;

            long f = 0;
            f = long.MaxValue;

            ulong g = 0;
            g = ulong.MaxValue;

            Console.WriteLine("int max {0}, min {1}, byte max {2}, sbyte max {3}, short max {4}, ushort max {5}, long max {6},and ulong max limit {6}", x, x, b, c, d, e, f, g);


            int y = 2147483647; //i can print this cause it is within the int32 datatype range but if i exceed it, it will show error.
          //int z = 2147483648; //exceeds the int32 range so it's an error, so we need to convert it to uint32 (unsigned/positive) datatype which is higher range.
            Console.WriteLine(y);

            uint a = 2147483649;
                a = uint.MaxValue;
            Console.WriteLine(a);

            //to find whether the datatype is primitive (basic values like 0123...) or not
            Console.WriteLine(typeof(int).IsPrimitive);
            Console.WriteLine(typeof(string).IsPrimitive);
            Console.WriteLine(typeof(char).IsPrimitive);
            Console.WriteLine(typeof(decimal).IsPrimitive);
            Console.WriteLine(typeof(double).IsPrimitive);
            Console.WriteLine(typeof(bool).IsPrimitive);
            Console.WriteLine(typeof(float).IsPrimitive);
        }
    }
}
