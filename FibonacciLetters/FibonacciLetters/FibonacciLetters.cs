using System;
using System.Collections.Generic;

namespace FibonacciLetters
{
    class FibonacciLetters
    {
        static void FibonacciLetter(char A,char B,int length) 
        {
            A = Char.ToUpper(A);
            B = Char.ToUpper(B);
            int newLetter;
            List<int> Letters = new List<int>() { }; 
            int indexA = ((int)A );
            int indexB = ((int)B );
            Letters.Add(indexA);
            Letters.Add(indexB);

            for (int i = 2; i < length+2; i++)
            {
                indexA = Letters[i - 2];
                indexB = Letters[i - 1];
                newLetter = (indexA - 64) + (indexB - 64);
                if (newLetter > 26)
                {
                    newLetter -= 26;
                }
                newLetter += 64;
                Letters.Add((char)newLetter);
            }
            Console.WriteLine();
            for (int i = 0; i < Letters.Count; i++)
            {
                Console.WriteLine((char)Letters[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("First letter : ");
            char A = Convert.ToChar(Console.ReadLine());
            Console.Write("Second letter : ");
            char B = Convert.ToChar(Console.ReadLine());
            Console.Write("Length : ");
            int Length = Convert.ToInt32(Console.ReadLine());
            FibonacciLetter(A, B, Length);
        }
    }
}
