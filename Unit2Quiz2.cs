using System;

namespace practicequiz_unit2_quiz2
{
    class Unit2Quiz2
    {
        static void Main(string[] args)
        {
            
            /*Write a function that takes in two numbers, and returns the sum of all of the numbers 
            between and including those two numbers. Example: I enter 7 and 12 - the result should 
            be 57 (7+8+9+10+11+12 = 57) */

            Console.WriteLine("Enter two numbers to get the sum of all of the numbers between and including those two numbers");
            Console.WriteLine("Enter the first number :");
            var userInput1 = Console.ReadLine();
            int x = Convert.ToInt32(userInput1);
            Console.WriteLine("Enter the second number :");
            var userInput2 = Console.ReadLine();
            int y = Convert.ToInt32(userInput2);

            int answer = SumOfAllNumbersinRange(x,y);
            Console.WriteLine("The sum of all the numbers between and including the two numbers that you enetered is :" + answer);
        }
           
        static int SumOfAllNumbersinRange(int x, int y)
       {
           int result = 0;
           int lowestNumber = 0;
           int highestNumber = 0;
           
           if (x == y)
           {
           return x;
           }
           else if (x > y)
           {
           lowestNumber = y;
           highestNumber = x;
           }
           else if (x < y)
           {
           lowestNumber = x;
           highestNumber = y;
           }
           for (int i = lowestNumber; i <= highestNumber; i++)
           {
           result += i;
           }
           return result;
        }
    }
}
