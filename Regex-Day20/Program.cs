using System;

namespace Regex_Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

            Patterns patterns = new Patterns();

            Console.WriteLine(patterns.validateFirstName("Prajwal")); // FirstName
            Console.WriteLine(patterns.validateLastName("Zurunge"));  // Lastname
            Console.WriteLine(patterns.validateEmail("prajwal.zurunge12@gmail.com")); //Email
            Console.WriteLine(patterns.validateMobileNo("918446255759")); // MobileNo
            Console.WriteLine(patterns.validatePassword1("prajwalpass")); // Password Rule 1
            Console.WriteLine(patterns.vaildatePassword2("Prajwalpass")); // Password Rule 2
            Console.WriteLine(patterns.vaildatePassword3("Prajwalpass2")); // Password Rule 3
        }
    }
}
