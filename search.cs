using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class search : Adduser
    {
        bool flag=false;
        public override void Students(List<Student> students)
        {
            Console.WriteLine($"====================== SEARCH ABOUT  STUDENT =======================");
            Console.Write("Enter Student Id you want to search: ");
            string ID = Console.ReadLine();
            Student Foundedstudent = students.FirstOrDefault(x=> x.Id == ID);
            var name = Foundedstudent.Name;
            var mail = Foundedstudent.Email;
            var level = Foundedstudent.Level;
            var id = Foundedstudent.Id;
            var gpa = Foundedstudent.Gpa;
            bool flag = false;
            if (Foundedstudent != null)
            {
                Console.WriteLine($"Name: {name} \nEmail: {mail} \nLevel: {level} \nId: {id} \nGPA: {gpa}");
            }
            else
            {
                Console.WriteLine("No student Like this");
                flag = true;
            }
        }
    }
}
