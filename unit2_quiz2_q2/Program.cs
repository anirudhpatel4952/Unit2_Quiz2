using System;
using System.Collections.Generic;

namespace unit2_quiz2_q2
{
    class quiz2q2
    {
        static void Main(string[] args)
        {
        //     /*Write a function that takes in a string as input, removes the vowels from the string (aeiou), 
        //     and then returns that new string as the output. Example: I input "Hello World" - the result 
        //     should be "Hll wrld".*/
        
        
        Console.WriteLine("Enter the string");
            var statement = Console.ReadLine();
            var newStatement = NoVowel(statement);
            Console.WriteLine(newStatement);
        }


        static string NoVowel(string str)
        {
            var sentSplit = str.ToCharArray();
            var vowelString = new List<char>()
                { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string newStatement = "";
            for (int i = 0; i < sentSplit.Length; i++)
            {
                char v = sentSplit[i];
                if (vowelString.Contains(v))
                {
                    continue;
                }
                else
                {
                    newStatement += v;
                }
            }
            return newStatement;
        }
        
        
        
        



    }
}
