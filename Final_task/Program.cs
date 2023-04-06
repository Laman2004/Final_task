using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                FullName = "Laman Mikayilova",
                AvgPoint = 90
            };
            Console.WriteLine("Enter Group's number:");
            string no = Console.ReadLine();
            Console.WriteLine("Enter teacher's name:");
            string teacherName = Console.ReadLine();
            Group group = new Group
            {
                No = no,
                TeacherName = teacherName
            };
            group.AddStudent(student1);
            bool value = true;
            do
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.About info Group");
                Console.WriteLine("2.About info students of group");
                Console.WriteLine("3.Search student");
                Console.WriteLine("4.Add a new student to group");
                Console.WriteLine("5.Remove a student from group");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter number,please:");
                int count;
                string counter = Console.ReadLine();
                while (!int.TryParse(counter, out count))
                {
                    Console.WriteLine("Value is false,enter again))");
                    counter = Console.ReadLine();
                }
                switch (count)
                {
                    case 1:
                        Console.WriteLine(group.GetInfo());
                        break;
                    case 2:
                        foreach (var item in group.GetAllStudent())
                        {
                            Console.WriteLine(item.GetInfo());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter student's name:");
                        string name = Console.ReadLine();
                        Console.WriteLine( group.SearchStudent(name)); 
                        break;
                    case 4:
                        Console.WriteLine("Enter fullname of new student:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Enter average point of new student:");
                        int avgPoint;
                        string avg = Console.ReadLine();
                        while (!int.TryParse(avg, out avgPoint))
                        {
                            Console.WriteLine("Value is false,enter again))");
                            avg = Console.ReadLine();
                        }
                        Student student = new Student
                        {
                            FullName = fullName,
                            AvgPoint = avgPoint
                        };
                        group.AddStudent(student);
                        break;
                    case 5:
                        Console.WriteLine("Enter student's name:");
                        string ad = Console.ReadLine();
                        
                        break;
                    case 6:
                        value = false;
                        break;
                    default:
                        break;
                }
            }
            while (value);

        }
      
       
    }
}
