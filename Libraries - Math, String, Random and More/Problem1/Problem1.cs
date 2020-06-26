using System;

namespace c_sharp_intro
{
    class Problem1
    {
        static void Main(string[] args)
        {
            //welcome message asking user to enter word
            Console.WriteLine("Enter a word and i will convert it to uppercase");

            //Reads the user input and stores it in enteredWord variable.
            string enteredWord=Console.ReadLine();

            //Below will convert the entered word to uppercase
            Console.WriteLine("Your word in Uppercase is:"+enteredWord.ToUpper());
         }
        
            
    }
            
            
}

