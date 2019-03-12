using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalOrder
{
    class Program
    {    
        public static string OrderStringAplha(string input)
        {
            input = input.ToLower();                          //This affects the ASCII order of the alphabet.
            char[] orderArray = input.ToCharArray();          //Change to a string to a character array
            for (int i = 0; i < input.Length; i++)            //Allow sort as many time as the length of the array.(8 times for Donnyves)
            {
                for (int j = 0; j < input.Length-1 ; j++)     //This is the sorting loop. Length -1 gauarantees that there is no
                {                                             //OutOfRange exception.
                    if (orderArray [j] > orderArray [j +  1]) //If the previous index value is greater then swap characters.
                    {
                        char tempVal = orderArray[j + 1];     //First value to second value to second value to first value.
                        orderArray[j + 1] = orderArray[j];
                        orderArray[j] = tempVal;
                    }
                }
            }
            string orderName = " ";
            for (int i = 0; i < input.Length; i++)            //put each value of array back into a string.  
            {
                orderName += orderArray[i];                   //The console cannot read the array.
            }
            return orderName;
        }
        static void Main(string[] args)
        {
            string name = "Donnyves";
            Console.WriteLine(OrderStringAplha (name));
            Console.ReadLine();
        }
        
    }
}
