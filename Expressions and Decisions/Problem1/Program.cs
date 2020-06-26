using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rNum=new Random();
            int selectedRandomNumber=rNum.Next(1,11);

            //Asks User 1 to enter random number
            Console.WriteLine("Hey User 1 Please enter any ramdom number between 1 to 10");
            //Reads number from User 1
            int numberUser1= int.Parse(Console.ReadLine()); 
            //Asks User 2 to enter random number
            Console.WriteLine("Hey User 2 Please enter any ramdom number between 1 to 10");
            //Reads number from User 2
            int numberUser2= int.Parse(Console.ReadLine()); 

            //Taking the difference between random number and user entry number
            
            int userOneDifference1=selectedRandomNumber-numberUser1;
            int userOneDifference2=selectedRandomNumber-numberUser2;
           
           //making all the differences positive by using math.abs built in method
           //@Link https://stackoverflow.com/questions/46930513/how-to-convert-negative-number-to-positive-in-c
            var userOneDifference1Positive = userOneDifference1 - (Math.Abs(-userOneDifference1));
            var userOneDifference2Positive = userOneDifference2 - (Math.Abs(-userOneDifference2));

            //Showing the random number
            Console.WriteLine("The random number is : {0}",selectedRandomNumber);

            //checking the winner using if else statement as the lower number will close to random number
            if(userOneDifference1Positive < userOneDifference2Positive)
            {
            Console.WriteLine("User 1 is Winner ");
            }
            
            else if(userOneDifference1Positive > userOneDifference2Positive)
            {
            Console.WriteLine("User 2 is Winner "); 
            }
            else
            {
            Console.WriteLine("It's a TIE ");   
            }


        }
    }
}
