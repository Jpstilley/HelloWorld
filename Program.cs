using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Joey, can you do this?");

            var response = Console.ReadLine();

            Console.WriteLine(response);
        }
    }
}
