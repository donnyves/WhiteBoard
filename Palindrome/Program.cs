using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{

    class Program
    {
        public static bool FirstMethod(string input)
        {
            input = input.ToLower();
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                if (input[i] != input[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FirstMethod("Anna"));//true
        

            Console.ReadLine();
        }
    }
}
