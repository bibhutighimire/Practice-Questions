using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will prompt for up to 20 marks, until the user enters all 20 or enters -1. 
            //Ensure that the user enters at least 1 mark. When done, output the average, highest and lowest marks from the “class”. 
            //Once finished, ask if they would like to start again. 
            //If they enter any integer that is not between -1 and 100 inclusive, prompt again and disregard the last input.
            //int[] userMarks;

            //@Link }
            //https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-18.php

            Console.WriteLine("Hi User! Please enter upto 5 marks here and i will give you average, highest and lowest marks");

            int[] number = new int[5];
            int maxValue=number[0];
            int minValue=number[1];
            //double averageValue=0;
            for(int i=0;i<5;i++)
            {
                while(number[i] != -1)
                {
                  Console.WriteLine("Enter again");
                  number[i]= Convert.ToInt32(Console.ReadLine());   
                  if(number[i]>maxValue) 
                  {
                      maxValue=number[i];
                  }  

                  else if(number[i]<minValue) 
                  {
                      minValue=number[i];
                  } 
                  else
                  {

                  }               
                  
                }
                Console.WriteLine("The maximun value you entered is {0} and minimun value you entered is {1}",maxValue,minValue);
            }
             
        }
    }
}
