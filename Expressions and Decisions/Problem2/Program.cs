using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //@lINK https://www.dotnetperls.com/odd

            //Asking user to enter an integer

            Console.WriteLine("ENTER AN INTEGER AND I WILL TELL YOU IF IT IS EVEN OR ODD NUMBER");

            //Reading the input
            int userNumber= int.Parse(Console.ReadLine());

            //Using the logic that if remainder is 0 then it's even number 
            //@lINK https://www.dotnetperls.com/odd
            if(userNumber%2==0)
            {
             Console.WriteLine("You entered even number");
            }

            //Using the logic that if remainder is not 0 then it's odd number  
            // userNumber%2=!=0
            else
            {
             Console.WriteLine("You entered odd number");
            }
        }
    }
}
