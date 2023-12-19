using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Adduser : Student
    {
        public virtual void Students(List<Student>students) 
        {
            Console.WriteLine($"============================ ADD STUDENT ================================");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter level: ");
            string level = Console.ReadLine();

            Console.Write("Enter id: ");
            string id = Console.ReadLine();

            Console.Write("Enter GPA: ");
            string gpa = Console.ReadLine();

            Student newstudent = new Student { Name=name,Email=email,Level=level,Id=id,Gpa=gpa};
             students.Add(newstudent);

            Console.WriteLine($"=================== STUDENT INFORMATION YOU ENTERD ======================");
            Console.WriteLine($"Name: {newstudent.Name}");
            Console.WriteLine($"Email: {newstudent.Email}");
            Console.WriteLine($"Level: {newstudent.Level}");
            Console.WriteLine($"Id: {newstudent.Id}");
            Console.WriteLine($"GPA: {newstudent.Gpa}");
        }
    }
}