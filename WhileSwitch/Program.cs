using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool powerOn = true;

            while (powerOn)
            {
                Console.Write("Channel? > ");

                string selection = Console.ReadLine();
                int channel = int.Parse(selection);

                switch (channel)
                {
                    case 2:
                        Console.WriteLine("now watching: cartoons");
                        break;
                    case 3:
                        Console.WriteLine("now watching: local news");
                        break;
                    case 4:
                        Console.WriteLine("now watching: sports");
                        break;
                    case 5:
                        Console.WriteLine("now watching: contact your cable provider.");
                        break;
                    default:
                        powerOn = false;
                        break;
                }
            }
        }
    }
}
