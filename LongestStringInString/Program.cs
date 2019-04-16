using System;

namespace LongestStringInString
{
    //I'm still trying to work this problem out.  I want print out the word that has the most characters.
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Donnyves", "Ted", "Shirley", "Betty" };
            LongestStringArray(array);
            Console.ReadLine();
        }
        public static void LongestStringArray(string[] inputArray)
        {
            int counter = 0;
            int max = 0;
            int i = 0;
            for (i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    counter = 0;
                    max = inputArray[i].Length;
                    counter++;
                    continue;
                }
                if (inputArray[i].Length == max)
                {
                    counter++;
                }
            }

            foreach (string VARIABLE in inputArray)
            {
                Console.Write(VARIABLE);
            }

            string[] longest = new string[counter];
            counter = 0;
            for (i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == max)
                {
                    longest[counter] = inputArray[i];
                    counter++;
                }
            }

        }
    }
}
