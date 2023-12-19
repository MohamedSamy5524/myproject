using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Delete : Adduser
    {
        public override void Students(List<Student>students)
        {
            Console.WriteLine($"=========================== DELETE STUDENT ==============================");
            Console.Write("Enter Student Id you want to Delete: ");
            string ID = Console.ReadLine();
            Student Foundedstudent = students.FirstOrDefault(x => x.Id ==ID);
            var name = Foundedstudent.Name;

            if (Foundedstudent != null)
            {
                students.Remove(Foundedstudent);
                Console.WriteLine($"=> YOU DELETE STUDENT : {name}.");
            }
            else
            {
                Console.WriteLine("No student Like this");
            }
        }
    }
}