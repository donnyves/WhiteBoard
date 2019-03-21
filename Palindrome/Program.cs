using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{

    class Program
    {
        public static bool Palindrome(string name)
        {
            name = name.ToLower();
            string result = "";
            for (int i = name.Length -1; i >= 0 ; i--)
            {
                result += name[i];
            }
            if (name == result) 
            {
                return true;
            }
            return false;
        }
        public static bool FirstMethod(string input)
        {
            input = input.ToLower();
            int i = 0;//beginning of the string
            int j = input.Length - 1;//the end of the string

            while (i < j)
            {
                if (input[i] != input[j])//For the word dead, [0]=d , [3]=d return true. 
                    return false;

                i++; //increment [i], [i]=[0]+[1]=e
                j--; //decrement [i], [i]=[3]-[1]=a
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FirstMethod("Anna"));//true
            Console.WriteLine(Palindrome ("Donnyves"));
            Console.WriteLine(Palindrome("tacocat"));



            Console.ReadLine();
        }
    }
}
