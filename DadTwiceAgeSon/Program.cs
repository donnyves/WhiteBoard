using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadTwiceAgeSon
{
    class Program
    {
        //This problem solves how old the son will be, when his dad is twice his age.
        public static int DoubleSonAge(int dad, int son)
        {
            int sonAge = 0;
            int dadAge = dad - son;
            while (dadAge != sonAge * 2)
            {
                dadAge++;
                sonAge++;
            }
            return sonAge;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleSonAge (40,5));
            Console.ReadLine();
        }
    }
}
