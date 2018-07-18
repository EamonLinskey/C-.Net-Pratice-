using System;
using static System.Console;
namespace ConsoleApp5
{
    class Program
    {
        static int a;
        static void Main(string[] args)
        {
            int a = 12;
            WriteLine("In Main() a is {0}", a);
            otherA();

            WriteLine("In Main() a is {0}", a);

            Read();
        }

        private static void otherA()
        {
            a = 354;
            WriteLine("In Main() a is {0}", a);
        }
    }
}
