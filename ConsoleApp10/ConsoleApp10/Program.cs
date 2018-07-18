using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Using 2");
        DisplaySize(4, 6);

        WriteLine("Using 3");
        DisplaySize(4, 6, 8);
        Read();
    }

    static void DisplaySize(int length, int width, int height = 1)
    {
        int area = width * height * length;
        WriteLine(area);
    }
}

