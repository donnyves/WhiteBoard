using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        public static void RotateArr(string direction, int[] array, int spaces)
        {
            if (direction == "left")
            {
             
                for (int i = 0; i < spaces; i++)//iterations < (number of spaces)
                {
                    int temp = array[0];//
                    for (int j = 0; j < array.Length -1; j++)//-1 prevent an out of bounds exception
                    {
                        array[j] = array[j + 1];//This shifts the array to the left.
                    }
                    array[array.Length - 1] = temp;//This swaps the first index with the last index.

                }

            }
          else if (direction == "right")
            {
                for (int i = 0; i < spaces; i++)//spaces is the amount of the array will be rotated to the right. First interation is at index 0, second is at index 1.
                {
                    int temp = array[array.Length - 1];//This will make the temp value equal to the end of the array.

                    for (int j = array.Length-1; j >= 1; j--)//start at the end of the array,
                    {
                        array[j] = array[j - 1];//This bring the number to the right.
                    }
                    array[0] = temp; //This places the last value to the best value.                  
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
        }
        static void Main(string[] args)
        {
            int[] C = { 7, 3, 5, 9, 6 };
            int[] D = { 7, 3, 5, 9, 6 };


            RotateArr("left", C, 2);
            Console.WriteLine();
            RotateArr("right", D, 2);

            Console.ReadLine();
        }
    }
}
