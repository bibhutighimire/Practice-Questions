using System;

namespace c_sharp_intro
{
    class Problem3
    {
        static void Main(string[] args)
        {
           
            //welcome message asking user to enter number of fence post
            Console.WriteLine("Enter number of fence post and i will give you the number of paint bucket you need to paint those fence posts");

            //Reads the user input and stores it in enteredWord variable.
           int numberOfFencePosts=Convert.ToInt32(Console.ReadLine());

           //4 fence post can be painted using 1 bucket of paint
           int numberOfPaintBucket=numberOfFencePosts/4;
            
            Console.WriteLine("You need {0} Buckets of Paint buckets to paint {1} fence posts",numberOfPaintBucket,numberOfFencePosts);
            
        }
            
            
    }
}

