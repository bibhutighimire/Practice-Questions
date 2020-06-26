using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to enter first 3 character of month
            Console.WriteLine("Hi There! Enter first 3 character of any month and i will give you full name of that month and total number of days in that month");

            //reading the entered 3 character of month
            string userMonth = Console.ReadLine();

            //since it is case insentitive so we need to convert all character in lower case so that it is same in all so we used tolower() method
            string userMonthToLowerCase = userMonth.ToLower();

            //using switch case as asked by question

            switch(userMonthToLowerCase)
            {
                case "jan":
                Console.WriteLine("The fullname of entered month is January and total number of days in this month are 31");
                break;

                case "feb":
                Console.WriteLine("The fullname of entered month is February and total number of days in this month are 28");
                break;

                case "mar":
                Console.WriteLine("The fullname of entered month is March and total number of days in this month are 31");
                break;

                case "apr":
                Console.WriteLine("The fullname of entered month is April and total number of days in this month are 30");
                break;

                case "may":
                Console.WriteLine("The fullname of entered month is May and total number of days in this month are 31");
                break;

                case "jun":
                Console.WriteLine("The fullname of entered month is June and total number of days in this month are 30");
                break;

                case "jul":
                Console.WriteLine("The fullname of entered month is July and total number of days in this month are 31");
                break;

                case "aug":
                Console.WriteLine("The fullname of entered month is August and total number of days in this month are 31");
                break;

                case "sep":
                Console.WriteLine("The fullname of entered month is September and total number of days in this month are 30");
                break;

                case "oct":
                Console.WriteLine("The fullname of entered month is October and total number of days in this month are 31");
                break;

                case "nov":
                Console.WriteLine("The fullname of entered month is November and total number of days in this month are 30");
                break;

                case "dec":
                Console.WriteLine("The fullname of entered month is December and total number of days in this month are 31");
                break;

                //If user enters wong character then default case will deal with it    
                default:
                Console.WriteLine("Invalid month. GRRRRRR!");
                break;
            }
        }
    }
}
