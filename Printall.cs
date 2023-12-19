using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Printall : Adduser
    {
        public override void Students(List<Student> students)
        {
            int count = 1;
            if (students.Count == 0)
            {
                Console.WriteLine($"====================================================================");

                Console.WriteLine("No student to print");
            }
            else
            {
                Console.WriteLine($"===================== PRINT ALL STUDENTS ===========================");
            }

            foreach (var student in students)
            {
                Console.WriteLine($"student {count}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Email: {student.Email}");
                Console.WriteLine($"Level: {student.Level}");
                Console.WriteLine($"Id: {student.Id}");
                Console.WriteLine($"GPA: {student.Gpa}");

                count++;
                if (count <= students.Count)
                {
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}
