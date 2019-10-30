using System;
using System.Text.RegularExpressions;


namespace LabSeven
{
    class Program
    {
       
        static public bool validName(string name)
        {
           return Regex.IsMatch(name, "^[A-Z][a-z]{1,30}");
        }

        static public bool validEmail(string email)
        {
            return Regex.IsMatch(email, @"^[0-9a-zA-Z]{5,30}@{1}[A-Za-z]{5,10}\.{1}[A-Za-z]{2,3}");
        }

        static public bool validNumber(string number)
        {
            return Regex.IsMatch(number, "^[0-9]{3}-[0-9]{3}-[0-9]{4}");
        }

        static public bool validDate(string date)
        {
            return Regex.IsMatch(date, @"^[0-9]{1,2}\/[0-9]{1,2}\/[0-9]{4}");
        }
       
        static public bool validHtml (string html)
        {
            return Regex.IsMatch(html, @"\<[a-zA-Z]\> {0,}\<\/[a-zA-Z]\>");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid Name");
            string name = Console.ReadLine();
            bool nameValid = validName(name);
            if (nameValid == true)
            {
                Console.WriteLine("Name is Valid!");
            }
            else if (nameValid == false)
            {
                Console.WriteLine("Sorry, name is not valid");
            }

            Console.WriteLine();

            Console.WriteLine("Please enter a valid email");
            string email = Console.ReadLine();
            bool emailValid = validEmail(email);
            if (emailValid == true)
            {
                Console.WriteLine("Email is Valid!");
            }
            else if (emailValid == false)
            {
                Console.WriteLine("Sorry, email is not valid");
            }

            Console.WriteLine();

            Console.WriteLine("Please enter a valid Phone Number");
            string number = Console.ReadLine();
            bool numberValid = validNumber(number);
            if (numberValid == true)
            {
                Console.WriteLine("Phone Number is Valid!");
            }
            else if (numberValid == false)
            {
                Console.WriteLine("Sorry, Phone Number is not valid");
            }

            Console.WriteLine();

            Console.WriteLine("Please enter a valid date");
            string date = Console.ReadLine();
            bool dateValid = validDate(date);
            if (dateValid == true)
            {
                Console.WriteLine("Date is Valid!");
            }
            else if (dateValid == false)
            {
                Console.WriteLine("Sorry, Date is not valid");
            }

            Console.WriteLine();

            Console.WriteLine("Please enter a valid HTML element");
            string html = Console.ReadLine();
            bool htmlValid = validHtml(html);
            if (htmlValid == true)
            {
                Console.WriteLine("HTML element is Valid!");
            }
            else if (htmlValid == false)
            {
                Console.WriteLine("Sorry, HTML element is not valid");
            }

        }
    }
}
