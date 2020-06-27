using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will say “Hello”, and wait for input from the user. It will continue saying “Hello” until the user enters “stop” (case insensitive). Use a do-while loop.

            Console.WriteLine("Hey User! Type Anything");
            string userInput;

            do
            {   
                userInput=Console.ReadLine();
                
                //Console.WriteLine("Hey User! Type Anything");
            }
            while (userInput!="stop");
            
                Console.WriteLine("Dear User, you entered stop so your while loop will terminate");
            
            
        }
    }
}
