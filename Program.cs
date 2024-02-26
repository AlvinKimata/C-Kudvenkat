using System;

class Program
{
    static void Main()
    {
        //Prompt user for name.
        Console.WriteLine("Please enter your name");

        //Read name from console.
        string userName = Console.ReadLine();

        //Concatenate name and write to console.
        Console.WriteLine("Hello {0}", userName);;
    }
}