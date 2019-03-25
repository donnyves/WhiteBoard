using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctCharCount
{
    class Program
    {
        public static void DistinctCount(string input)
        {
            Console.WriteLine(input);
            input = input.ToUpper();

            for (char c = 'A'; c <= 'Z' ; c++)
            {
                int count = 0;
                if (input.Contains(c.ToString()))
                {
                    foreach (char ch in input)
                    {
                        if (ch == c) count++;
                    }                     
                        Console.WriteLine($"{c} - {count}" );                                   
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a string, and the distict characters will be displayed: ");
            string response = Console.ReadLine();
            DistinctCount(response);
           
            Console.ReadKey();
        }
    }
}
