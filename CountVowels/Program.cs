using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        public static int Count(string input)
        {
            input = input.ToLower();

            int countVowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    countVowels++;
                }
            }
            return countVowels;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Count("When are we going to Disney World Uncle Drew?"));//Should return 13 vowels.
            Console.ReadLine();
        }
    }
}
