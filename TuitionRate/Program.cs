using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionRate
{
    public class Tuition
    {
        static double startingCost = 6000.0;
        static double annualIncreasePercent = 2.0;

        public static double CalcTuition(int schoolYear)
        {
            double tuitionCost = startingCost;
            double increase = 0.0;

            for (int i = 0; i < schoolYear; i++)
            {
                tuitionCost += increase;
                increase = tuitionCost * annualIncreasePercent / 100.0;
            }

            return tuitionCost;
        }

        static void Main(string[] args)
        {
            int yearsToDisplay = 5;
            Console.WriteLine("Tuition.Main()");

            for (int year = 1; year <= yearsToDisplay; year++)
            {
                Console.WriteLine($"For year {year} your tuition will be {CalcTuition(year)}");
            }

            Console.ReadKey();
        }
    }
}
