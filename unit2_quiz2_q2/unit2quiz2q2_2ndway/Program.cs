using System;

namespace unit2quiz2q2_2ndway
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Your code goes here
           
            Console.WriteLine("Enter the string");
            var userInput = Console.ReadLine();
            var statement = userInput;
            var result = NoVowels(statement);
           Console.WriteLine("Your statement without vowels is :" + result);
           
        }
        static string NoVowels(string statement)
        {
         var res = "";
            for (int i = 0; i < statement.Length; i ++)
            {
           
                if (statement[i] == 'a' || statement[i] == 'e' || statement[i] == 'i' || statement[i] == 'o' || statement[i] == 'u')
                {
                continue;
                }
                if (statement[i] == 'A' || statement[i] == 'E' || statement[i] == 'I' || statement[i] == 'O' || statement[i] == 'U') {
                continue;
                }
                else {
                res += statement[i];
                }
            }
            return res;
        }
    }
}
    