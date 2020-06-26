using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to enter a number
            Console.WriteLine("Enter a number and i will give u cube of it");

            //Reads number entered by user
            int userNumber = int.Parse(Console.ReadLine());

            //Putting the formula
            int cubeOfNumber=userNumber*userNumber*userNumber;

            //Displaying the result
            Console.WriteLine("The cube of the number is : {0}",cubeOfNumber);
        }
    }
}
