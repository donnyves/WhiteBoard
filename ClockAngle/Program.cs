using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        // Find the angle between the two hands on a clock at any time.
        public static double AngleDiff(int hour, int minute)
        {
            double minuteAngle = (double)minute / 60.0 * 360.0;
            double hourAngle = (double)hour / 12.0 * 360.0;

            double diff = Math.Abs(minuteAngle - hourAngle);
            if (diff > 180) return 360 - diff;
            return diff;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to figure out clockhand angles for a clock.");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Write an integer (1-12) for the hour hand on a clock: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Write an integer (1-59) for the minute hand on a clock: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(AngleDiff (hour,minute));
            Console.ReadLine();
        }
    }
}
