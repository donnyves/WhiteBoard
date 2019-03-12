using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Student : int
        {
            Garrett, Cody, Dennis, Rochelle, Donnyves, Josh, Job
        }

        static void Main(string[] args)
        {
            for (int i = (int)Student.Garrett; i <= (int)Student.Job; i++)
            {
                switch (i)
                {
                    case (int)Student.Garrett:
                        Console.WriteLine(Student.Garrett + ":" + (int)Student.Garrett);
                        break;
                    case (int)Student.Cody:
                        Console.WriteLine(Student.Cody + ":" + (int)Student.Cody);
                        break;
                    case (int)Student.Dennis:
                        Console.WriteLine(Student.Dennis + ":" + (int)Student.Dennis);
                        break;
                    case (int)Student.Rochelle:
                        Console.WriteLine(Student.Rochelle + ":" + (int)Student.Rochelle);
                        break;
                    case (int)Student.Donnyves:
                        Console.WriteLine(Student.Donnyves + ":" + (int)Student.Donnyves);
                        break;
                    case (int)Student.Josh:
                        Console.WriteLine(Student.Josh + ":" + (int)Student.Josh);
                        break;
                    case (int)Student.Job:
                        Console.WriteLine(Student.Job + ":" + (int)Student.Job);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
