using System;
using System.Text.RegularExpressions;

namespace Deliverable8
{
    class Program
    {
        public static string validateName(string name)
        {
            if (Regex.Match(name, "^[A-Z][a-z]{0,29}$").Success)
            {
                return "Name is valid!";
            }
            else
            {
                return "Sorry name is not valid!";
            }
        }

        public static string validateEmail (string email)
        {
            if (Regex.Match(email, "^[a-zA-Z0-9]{5,30}[@][a-zA-Z0-9]{5,10}[.][a-zA-Z0-9]{2,3}$").Success)
            {
                return "Email is valid!";
            }
            else
            {
                return "Sorry, email is not valid!";
            }
        }

        public static string validatePhone(string phone)
        {
            if (Regex.Match(phone, "^\\d\\d\\d[-]\\d\\d\\d[-]\\d\\d\\d\\d$").Success)
            {
                return "Phone is valid!";
            }
            else
            {
                return "Sorry, phone is not valid!";
            }
        }
        public static string validateDate (string date)
        {
            if (Regex.Match(date, "^\\d\\d[/]\\d\\d[/]\\d\\d\\d\\d$").Success)
            {
                return "Date is valid!";
            }
            else
            {
                return "Sorry, date is not valid!";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(validateName(name));

            Console.Write("Please enter a valid email: ");
            string email = Console.ReadLine();
            Console.WriteLine(validateEmail(email));

            Console.Write("Please enter a valid phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine(validatePhone(phone));

            Console.Write("Please enter a valid date: ");
            string date = Console.ReadLine();
            Console.WriteLine(validateDate(date));
        }
    }
}
