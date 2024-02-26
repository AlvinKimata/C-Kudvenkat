using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            //Display double quotes.
            string Name = "\"Pragim\"";
            Console.WriteLine(Name);

            //Display new line character in C#
            Name = "One\nTwo\nThree\n";
            Console.WriteLine(Name);

            //Display new line character.
            Name = "C:\\Pragim\\Dotnet\\Training";
            Console.WriteLine(Name);

            //C# verbal literal.
            Name = @"C:\Pragim\\Dotnet\Training";
            Console.WriteLine(Name);

        }
    }
}