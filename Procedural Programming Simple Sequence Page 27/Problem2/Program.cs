using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will take in a total dollar value (as a double) and a number of diners (as an int) and calculate the amount of the bill that each diner should pay (equal split).
            Console.WriteLine("Enter the number of total dollar value");
            //reads the total dollar value and converts it to double
            double totalBill = Convert.ToDouble(Console.ReadLine());

            //asking the number of diners now
            Console.WriteLine("Enter the number of diners");
            //ReadOnlySpan the total number of diners
            int totalDiners = Convert.ToInt32(Console.ReadLine());

            //using divide formula to get equal split
            double equalSplit=(double)totalBill/totalDiners;

            Console.WriteLine("Each diner should pay ${0}",equalSplit);


        }
    }
}
