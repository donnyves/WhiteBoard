using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            double sum = 0.0;
            int count = 0;

            while (!done)
            {
                bool validNumber;
                double score;

                Console.Write("next score > ");
                validNumber = double.TryParse(Console.ReadLine(), out score);

                // TODO: check if score is in valid range.
                if (validNumber)
                {
                    sum += score;
                    count++;
                }
                else
                {
                    done = true;
                }
                // TODO: add switch case to assign letter grade.
                Console.WriteLine("average: " + sum);
            }
        }
    }
}
