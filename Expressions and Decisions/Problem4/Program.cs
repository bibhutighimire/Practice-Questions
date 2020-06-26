using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            //Asking user to enter OPERAND 1

            Console.WriteLine("ENTER AN OPERAND 1");

            //Reading the OPERAND 1
            int userOperand1= int.Parse(Console.ReadLine());

            //Asking user to enter OPERAND 2

            Console.WriteLine("ENTER AN OPERAND 2");

            //Reading the OPERAND 2
            int userOperand2= int.Parse(Console.ReadLine());

            //Asking user to enter an OPERATOR

            Console.WriteLine("ENTER AN OPERATOR + OR * OR /");

            //Reading the OPERATOR but before that checking if the entered operator is valid or invalid
            
            string userOperator= Console.ReadLine();

            //Using IF ELSE statement to perform calculation
            
            if(userOperator=="+")
            {
             Console.WriteLine("The sum of the operands is: {0} ",userOperand1+userOperand2);
            }

            if(userOperator=="/")
            {
            //using (double) will help us show decimal answers
            //@Link https://stackoverflow.com/questions/661028/how-can-i-divide-two-integers-to-get-a-double

             double divideAnswer=(double)userOperand1/(double)userOperand2;   
             Console.WriteLine("The division of the operands is: {0} ",divideAnswer);
            }

            else if(userOperator=="*")
            {
             Console.WriteLine("The multiplication of the operands is: {0} ",userOperand1*userOperand2);
            }
            //default output if entry is not + or *
            else 
            {
             Console.WriteLine("Invalid Enrty");
            }
        }
    }
}
