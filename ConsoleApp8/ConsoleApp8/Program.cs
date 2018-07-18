using System;
using static System.Console;

namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] someNums = { 10, 12, 22, 35 };
            int x;

            Write("\nAt beginning of Main() method...");

            for (x = 0; x < someNums.Length; ++x)
            {
                Write("{0,6}", someNums[x]);
            }

            WriteLine();

            MethodGetsArray(someNums);

            Write("At end of Main() method........");

            for (x = 0; x < someNums.Length; ++x)
            {
                Write("{0,6}", someNums[x]);
            }

            Read();
        }

        private static void MethodGetsArray(int[] vals)
        {
            int x;
            WriteLine("In MethodsGetArray() ");

            for (x = 0; x < vals.Length; x++)
            {
                WriteLine(" {0}", vals[x]);
            }

            WriteLine();

            for (x = 0; x < vals.Length; x++)
            {
                vals[x] = 888;
            }

            WriteLine("After Change");

            for (x = 0; x < vals.Length; x++)
            {
                WriteLine(" {0}", vals[x]);
            }
        }



    }
}

