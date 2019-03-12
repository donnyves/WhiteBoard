using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        public enum grade { F, D, C, B, A };

        public static string[] names =
            { "Frank", "Emily", "James", "Tom" };
        public static string[] subjects = {
            "French",
            "English",
            "Calculus",
            "History",
            "Geography" };

        public static grade[,] StudentGrades =
        {
            { grade.A, grade.A, grade.B, grade.A, grade.A },
            { grade.B, grade.B, grade.B, grade.A, grade.A },
            { grade.A, grade.B, grade.C, grade.A, grade.B },
            { grade.A, grade.B, grade.A, grade.C, grade.C }
        };

        public static float GetGPA(int Student)
        {
            int sum = 0;
            for (int course = 0; course < subjects.Length; course++)
            {
                sum += (int)StudentGrades[Student, course];
            }
            return (float)sum / subjects.Length;
        }

        public static void DisplayGPAs()
        {
            float sum = 0;
            for (int student = 0; student < names.Length; student++)
            {
                float GPA = GetGPA(student);
                Console.WriteLine($"{names[student]}:{GPA}");
                sum += GPA;
            }
            Console.WriteLine($"Class Average: {sum / names.Length}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("GradePointAverage.Main()");
            DisplayGPAs();
            Console.ReadLine();
        }
    }
}
