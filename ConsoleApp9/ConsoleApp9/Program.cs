using System;
using static System.Console;


class Program
{
    /*
    static void Main(string[] args)
    {
        int x = 4;
        WriteLine("In Main x = {0}", x);

        DisplayRefParamater(ref x);
        WriteLine("In Main x = {0}", x);
        Read();
    }

    static void DisplayRefParamater(ref int number)
    {
        number = 888;
        WriteLine("In DisplayRefParamater x = {0}", number);
    }
    */

    static void Main(string[] args)
    {
        /*
        int first, second;
        InputMethod(out first, out second);
        WriteLine("After InputMethod first is {0}", first);
        WriteLine("And Second is: {0}", second);
        Read();
        string entryString;
        int score;
        Write("Enter your Test Score >>");
        entryString = ReadLine();
        int.TryParse(entryString, out score);
        WriteLine("You entered {0}", score);
        Read();

        string[] names = { "Ma", "Pa", "Ca", "ja" };
        DisplayStrings("GI");
        DisplayStrings("Ge", "Ma", "Th");
        DisplayStrings(names);
        */

        DisplayWithBorder();


    }
    static void DisplayStrings(params string[] people)
    {
        foreach(string person in people)
        {
            Write("{0} ", person);
        }
        WriteLine("\n-------------------------------")
    }

    /*
      static void InputMethod(out int one, out int two)
      {
          string s1, s2;
          Write("Enter first integer: ");
          s1 = ReadLine();
          Write("Enter next integer: ");
          s2 = ReadLine();
          one = Convert.ToInt32(s1);
          two = Convert.ToInt32(s2);
      }
      */
}
