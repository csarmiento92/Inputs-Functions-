using System;

namespace inputs_and_functions
{
    class Program
    {

        public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

        static void Main(string[] args)
        {
            // Create an application that asks the user for two different numbers
            // then writes the sum of the numbers to the console as the answer.
            // Create variables to hold the values of the first and second numbers

            // Have the console prompt for each input
            // Store the console response in each of the variables

            // Use a separate function to calculate the sum.

            // Write the result of the function call to the console
           
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            Console.Write("Enter another number: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(num1,num2) );

        }

    }
}
