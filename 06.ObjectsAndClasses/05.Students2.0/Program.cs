using System;
using System.Collections.Generic;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] studentProperties = command.Split();

                if (IsStudentExisting(studentProperties[0], studentProperties[1], students))
                {
                    Student student = students.Find(student => student.FirstName == studentProperties[0] && student.LastName == studentProperties[1]);
                    student.Age = int.Parse(studentProperties[2]);
                    student.HomeTown = studentProperties[3];
                }
                else
                {
                    Student student = new Student(studentProperties[0], studentProperties[1], int.Parse(studentProperties[2]), studentProperties[3]);
                    students.Add(student);
                }
            }

            string filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
