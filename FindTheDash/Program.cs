using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDash
{
    class Dash
    {
        public static int TheDashIs(string textMessage)
        {
            int location = 0;
            while (location < textMessage.Length)
            {
                if (textMessage[location] == '-')//use [] when your trying to find the index.
                {
                    return location;
                }
                location++;
            }
            return location;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dash.Main()");

            string test = "simula-tion";
            

            Console.WriteLine($"the dash is at {TheDashIs(test)}");
            Console.ReadLine();
        }
    }
}
