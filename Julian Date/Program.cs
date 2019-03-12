using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julian_Date
{
    
    class Program

    {
        public static int JulianDate(int mon, int day)
        {

            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int julian = day;

            for (int i = 1; i < mon; i++)
            {
                julian += months[i];
            }
            return julian;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(JulianDate(12,30));
            Console.ReadKey();
        }
    }
}
