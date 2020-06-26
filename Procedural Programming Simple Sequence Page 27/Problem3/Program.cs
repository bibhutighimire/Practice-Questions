using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            //Write a program that will take in a user’s age and calculate their birth year (assuming this year’s birthday has passed).

            Console.WriteLine("How old are you?");
            //reads the user's age
            int userAge = Convert.ToInt32(Console.ReadLine());

            //asking the number of diners now
            Console.WriteLine("Enter the current Year");
            //reads the current year
            int currentYear = Convert.ToInt32(Console.ReadLine());
           
            int yearOfBirth=currentYear-userAge;
            

            Console.WriteLine("Your year of birth is {0}",yearOfBirth);


        }
        }
    }
}
