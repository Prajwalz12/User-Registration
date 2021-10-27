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

        public static string MOBILE_NO_REGEX = "^+[1-9]{2}[0-9]{10}$";
        
        public bool validateMobileNo(string mobileno)
        {
            Console.WriteLine("Mobile No validation is :");
            return Regex.IsMatch(mobileno, MOBILE_NO_REGEX);
        }

        public static string PASSWORD1_REGEX = "[A-Za-z]{8,}$";

        public bool validatePassword1(string password)
        {
            Console.WriteLine("Password1 valiadtion is :");
            return Regex.IsMatch(password, PASSWORD1_REGEX);
        }

        public static string PASSWORD2_REGEX = "[A-Z]{1,}[A-Za-z]{7,}$";

        public bool validatePassword2(string password)
        {
            Console.WriteLine("Password2 validation is :");
            return Regex.IsMatch(password, PASSWORD2_REGEX);
        }

        public static string PASSWORD3_REGEX = "([A-Za-z0-9])([a-zA-Z0-9])$";

        public bool validatePassword3(string password)
        {
            Console.WriteLine("Password3 validation is :");
            return Regex.IsMatch(password, PASSWORD3_REGEX);
        }

        public static string PASSWORD4_REGEX = "^([A-Za-z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";

        public bool validatePassword4(string password)
        {
            Console.WriteLine("Password4 validation is :");
            return Regex.IsMatch(password, PASSWORD4_REGEX);
        }
    }
}
