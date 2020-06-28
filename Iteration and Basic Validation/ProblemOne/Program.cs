using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // @Question: Write a program that will prompt the user for an integer, and continue prompting until an integer between 1 and 10 (inclusive) is entered. Use a while loop.
            int userInput=2;
            while(userInput>1 && userInput<10)
            {
                Console.WriteLine("Please enter any integer. I will exit your program if you enter anything which is not in between 1 and 10");
             userInput=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered {0} which is not in between 1 and 10 so i am breaking your while loop",userInput);

        }
    }
}
