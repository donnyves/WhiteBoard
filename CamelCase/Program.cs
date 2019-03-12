using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    //Turn "Mary had a...",  into camelCase ==> "maryHadA"
    //Try to thing sequentially


    class Program
    {
        public static class CamelCase
        {
            public static string toCamelCase(string sentence)
            {
                bool isNewWord = false;
                string returnString = " ";

                sentence = sentence.ToLower();

                for (int i = 0; i < sentence.Length; i++)
                {
                    while (sentence[i] == ' ')
                    {
                        i++;
                        isNewWord = (returnString.Length > 0) ? true : false;
                    }
                    returnString += isNewWord ? char.ToUpper(sentence[i]) : sentence[i];
                    isNewWord = false;
                }
                return returnString;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CamelCase.Main()");
            //Make sure that the (CamelCase class) is public and static.  
            Console.WriteLine(CamelCase.toCamelCase("mary had a little"));//Output maryHadALittle.

            Console.ReadKey();
        }
    }
}
