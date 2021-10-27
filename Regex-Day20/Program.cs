﻿using System;

namespace Regex_Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

            Patterns patterns = new Patterns();

            Console.WriteLine(patterns.validateFirstName("Prajwal"));
            Console.WriteLine(patterns.validateLastName("Zurunge"));
            Console.WriteLine(patterns.validateEmail("prajwal.zurunge12@gmail.com"));
            Console.WriteLine(patterns.validateMobileNo("918446255759"));
            Console.WriteLine(patterns.validatePassword1("prajwalpass"));
            Console.WriteLine(patterns.vaildatePassword2("Prajwalpass"));

        }
    }
}
