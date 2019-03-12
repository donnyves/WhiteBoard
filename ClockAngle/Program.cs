using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        // find the angle between the two hands on a clock at any time
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
            Console.WriteLine(AngleDiff (12,45));
            Console.ReadLine();
        }
    }
}
