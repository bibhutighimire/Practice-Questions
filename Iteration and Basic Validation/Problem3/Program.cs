using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will count from 1 to 100, replacing every number divisible by 3 with “Fizz”, every number divisible by 5 with “Buzz”, 
            //and every number divisible by both 3 and 5 with “FizzBuzz”. Try to make it as maintainable as possible, allowing more words and numbers to be easily added.

            int[] number=new int[100];
                for(int i=1;i<=100;i++)
                {
                     if(i%3 == 0 && i%5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        
                    }
                    else if(i%3 == 0 ) 
                    {
                        Console.WriteLine("Fizz");
                    }
                   
                    else if(i%5 == 0 )
                    {
                        Console.WriteLine("Buzz");
                    }
                    
                    else{
                        Console.WriteLine(i);
                    }

                }
           
                    
                
            
            
        }
    }
}
