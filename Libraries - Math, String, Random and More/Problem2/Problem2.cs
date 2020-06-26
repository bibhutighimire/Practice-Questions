using System;

namespace c_sharp_intro
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[100];
            //welcome message asking user to enter three integer
            Console.WriteLine("Enter 3 integers and i will give you highest and lowest number among them");

            //Reads the user input and stores it in enteredWord variable.
            for(int i=0;i<=2;i++)
            {
                numbers[i]=Convert.ToInt32(Console.ReadLine());
                for(int j=i;j<=i;j++)
                    {
                        Console.WriteLine("the entered numbers are",numbers[i]);
                    }
            }    
                // int temp=enteredNumber;
                // if(enteredNumber>temp){
                //     int low=temp;
                //     int high=enteredNumber;
                //         //Below will show highest and lowest number
                //             Console.WriteLine("Your highest number is:{0}",high);
                //             Console.WriteLine("Your highest number is:{0}",low);
                //}
            
            
        }
            
            
    }
}

