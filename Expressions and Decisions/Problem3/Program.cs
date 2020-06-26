using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and i will tell you if it is a perfect square root or not");
            double numberToCheck=Convert.ToDouble(Console.ReadLine());

            //@Link https://stackoverflow.com/questions/4885925/shortest-way-to-check-perfect-square
            
            double result = Math.Sqrt(numberToCheck);
            if( result%1 == 0)
            {
            Console.WriteLine("Entered number  is a perfect square root");
            }
            else
            {
            Console.WriteLine("Entered number  is not a perfect square root");
            }
        }
    }
}
