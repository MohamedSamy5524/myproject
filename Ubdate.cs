using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Ubdate : Adduser
    {
        public override void Students(List<Student>students)
        {
            Console.WriteLine($"======================= UPDATE DATE OF STUDENT ===========================");
            Console.Write("Enter student Id you want to Edit: ");
            string ID = Console.ReadLine();
            Student Foundedstudent = students.FirstOrDefault(x => x.Id == ID);
            bool flag = false;
            if (Foundedstudent != null)
            {
                Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit Level: \n4-Edit Id: \n5-Edit GPA: \n");
                int choseToEdit = int.Parse(Console.ReadLine());
                if (choseToEdit == 1)
                {
                    Console.Write("Enter Edited Name: ");
                    string newName = Console.ReadLine();
                    Foundedstudent.Name = newName;
                    flag = true;
                }
                else if (choseToEdit == 2)
                {
                    Console.Write("Enter Edited Email: ");
                    string newEmail = Console.ReadLine();
                    Foundedstudent.Email = newEmail;
                    flag = true;
                }
                else if (choseToEdit == 3)
                {
                    Console.Write("Enter Edited level: ");
                    string newLevel = Console.ReadLine();
                    Foundedstudent.Level = newLevel;
                    flag = true;
                }
                else if (choseToEdit == 4)                
                {
                    Console.Write("Enter Edited Id: ");
                    string newId = Console.ReadLine();
                    Foundedstudent.Id = newId;
                    flag = true;
                }
                else if (choseToEdit == 5)
                {
                    Console.Write("Enter Edited GPA: ");
                    string newGpa = Console.ReadLine();
                    Foundedstudent.Gpa = newGpa;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Wrong ID Try Again From First"); ;
                }
                if (flag == true)
                {
                    Console.WriteLine($"============ NEW STUDENT  INFORMATION YOU EDITED ================");
                    Console.WriteLine($"Name: {Foundedstudent.Name}");
                    Console.WriteLine($"Email: {Foundedstudent.Email}");
                    Console.WriteLine($"Level: {Foundedstudent.Level}");
                    Console.WriteLine($"Id: {Foundedstudent.Id}");
                    Console.WriteLine($"GPA: {Foundedstudent.Gpa}");
                }
            }
            else
            {
                Console.WriteLine("No Student Like this");
            }
        }
    }
}
