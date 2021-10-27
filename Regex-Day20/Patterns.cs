using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Day20
{
    class Patterns
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool validateFirstName(string fisrtName)
        {
            Console.WriteLine("FirstName Validation is :");

            return Regex.IsMatch(fisrtName, REGEX_FIRST_NAME);
            
        }

        public static string REGEX_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool validateLastName(string lastName)
        {
            Console.WriteLine("LastName Validation is :");
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }

        public static string EMAIL_REGEX = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

        public bool validateEmail(string email)
        {
            Console.WriteLine("Email Validation is :");
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}
