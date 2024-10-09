using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

        public Student()
        {
            FirstName = "Unknown";
            LastName = "Student";
            Age = 18;
            University = "Unknown University";
        }
    }

    internal class Task3
    {
        public static void PrintAllStudents(Student[] students)
        {
            Console.WriteLine("Всі студенти:");
            var allStudents = from student in students
                              select student;
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age}, {student.University}");
            }
            Console.WriteLine();
        }

        public static void PrintStudentsWithBro(Student[] students)
        {
            Console.WriteLine("Студенти з прізвищем, яке починається з Bro:");
            var studentsWithBro = from student in students
                                  where student.LastName.StartsWith("Bro")
                                  select student;
            foreach (var student in studentsWithBro)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine();
        }

        public static void PrintStudents19(Student[] students)
        {
            Console.WriteLine("Студенти старші 19 років:");
            var studentsOlderThan19 = from student in students
                                      where student.Age > 19
                                      select student;
            foreach (var student in studentsOlderThan19)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age}");
            }
            Console.WriteLine();
        }

        public static void PrintStudentsBetween20And23(Student[] students)
        {
            Console.WriteLine("Студенти старші 20 і молодші 23 років:");
            var studentsBetween20And23 = from student in students
                                         where student.Age > 20 && student.Age < 23
                                         select student;
            foreach (var student in studentsBetween20And23)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age}");
            }
            Console.WriteLine();
        }

        public static void PrintOxfordStudents18(Student[] students)
        {
            Console.WriteLine("Студенти з Oxford старші 18 років:");
            var oxfordStudentsOlderThan18 = from student in students
                                            where student.University == "Oxford" && student.Age > 18
                                            orderby student.Age descending
                                            select student;
            foreach (var student in oxfordStudentsOlderThan18)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age}, {student.University}");
            }
            Console.WriteLine();
        }
    }
}
