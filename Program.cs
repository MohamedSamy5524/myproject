using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static bool Loop = false;
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int chose;
            while (true)
            {
                Console.WriteLine($"1-Add Student \n2-Update Data of Student \n3-Search about student \n4-Delete Student \n5-Print All Students \n");
                Console.Write("Chose a number => ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out chose))
                {
                    if (chose == 1)
                    {
                        Adduser adduser = new Adduser();
                        adduser.Students(students);
                    }
                    else if (chose == 2)
                    {
                        Adduser update = new Ubdate();
                        update.Students(students);
                    }
                    else if (chose == 3)
                    {
                        Adduser search = new search();
                        search.Students(students);
                    }
                    else if (chose == 4)
                    {
                        Adduser delete = new Delete();
                        delete.Students(students);
                    }
                    else if (chose == 5)
                    {
                        Adduser print = new Printall();
                        print.Students(students);
                    }
                    else
                    {
                        Console.WriteLine("You Enter Wrong Number!!");

                    }

                    TryAgain();
                    if (Loop)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("=========================================================================");
                }
            }
        }
        static void TryAgain()
        {
                    Console.WriteLine("=========================================================================");

            Console.WriteLine("Do you want to try anything else ? \n Y for yes || N for no");
            char tryAgain = char.Parse(Console.ReadLine());
            if (tryAgain == 'Y' || tryAgain == 'y')
            {
                    Console.WriteLine("=========================================================================");
            }
            else if (tryAgain == 'N' || tryAgain == 'n')
            {
                Loop = true;
            }
        }
    }
}