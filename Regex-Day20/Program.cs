using System;

namespace Regex_Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validateFirstName("Prajwal"));
        }
    }
}
