using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        
        public static void FibonacciSeries(int input)
        {
//          F(n) is the term number.
//          F(n - 1) is the previous term(n - 1).
//          F(n - 2) is the term before that(n - 2). 

            int i, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the length of the Fibonacci Sequence: ");
            input = int.Parse(Console.ReadLine());
            Console.Write(f1 + ", ");
            Console.Write(f2 + ", ");
            for (i = 0; i <= input; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + ", ");
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
       
        static void Main(string[] args)
        {
            FibonacciSeries(10);
            Console.ReadLine();        
        }
    }
}
