using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase9Section1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            PopulateData(students, teachers, subjects);

            DisplayStudentsInClass(students, "Class A");

            DisplaySubjectsByTeacher(subjects, teachers[0]);

            Console.ReadLine();
        }

        static void PopulateData(List<Student> students, List<Teacher> teachers, List<Subject> subjects)
        {

            students.Add(new Student("Alex", "Class A"));
            students.Add(new Student("Balbir", "Class B"));
            students.Add(new Student("Christopher", "Class A"));


            teachers.Add(new Teacher("Mr. Antony", "Class A"));
            teachers.Add(new Teacher("Mrs. Tina", "Class B"));


            subjects.Add(new Subject("Maths", "MATH101", teachers[0]));
            subjects.Add(new Subject("Science", "SCI101", teachers[1]));
        }

        static void DisplayStudentsInClass(List<Student> students, string className)
        {
            Console.WriteLine($"Students in {className}:");
            foreach (var student in students)
            {
                if (student.Class.Equals(className, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
            Console.WriteLine();
        }

        static void DisplaySubjectsByTeacher(List<Subject> subjects, Teacher teacher)
        {
            Console.WriteLine($"Subjects taught by {teacher.Name}:");
            foreach (var subject in subjects)
            {
                if (subject.Teacher.Equals(teacher))
                {
                    Console.WriteLine($"- {subject.Name} ({subject.SubjectCode})");
                }
            }
            Console.WriteLine();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public Student(string name, string studentClass)
        {
            Name = name;
            Class = studentClass;
        }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public Teacher(string name, string teacherClass)
        {
            Name = name;
            Class = teacherClass;
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }

        public Subject(string name, string code, Teacher teacher)
        {
            Name = name;
            SubjectCode = code;
            Teacher = teacher;
        }
    }
}




