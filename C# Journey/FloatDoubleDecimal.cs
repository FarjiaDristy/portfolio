using System;
namespace FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float f_no = 2.0555f;
            double d_no = 2.90d;
            decimal m_no = 34.0m;

            //Formatted string is clearer than adding strings.
            Console.WriteLine("The float number is {0}" , f_no);
            Console.WriteLine("The double number is {0}", d_no);
            Console.WriteLine("The decimal number is {0}", m_no);

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;
            // will show the outputs in the accurate sizes of float double and decimal types. which is a precision
            Console.WriteLine("The float number is {0}", f_no); //7 digits
            Console.WriteLine("The double number is {0}", d_no); //16 digits
            Console.WriteLine("The decimal number is {0}", m_no); //29 digits
        }
    }
}
