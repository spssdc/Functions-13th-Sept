using System;

namespace Functions_Example
{
    class Program
    {
        static int square (int n)
        {
            return n*n;
        }

        static void message(string e)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(e);
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Square 2 " + square(2));
            message("Extra stuff");
        }
    }
}
