using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section1._32
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            ReadStudentDataFromFile(); 
            SortStudentsByName();     

            DisplayStudents();        

            SearchStudentByName();    
        }

        static void ReadStudentDataFromFile()
        {
            try
            {
                string filePath = "C:\\Users\\mural\\source\\repos\\Phase1Section1.32\\Phase1Section1.32\\students.txt"; // Path to your text file
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 2)
                    {
                        Student student = new Student
                        {
                            Name = data[0].Trim(),
                            Class = data[1].Trim()
                        };
                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        static void SortStudentsByName()
        {
            students = students.OrderBy(s => s.Name).ToList();
        }

        static void DisplayStudents()
        {
            Console.WriteLine("Sorted Student Data:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Class}");
            }
            Console.WriteLine();
        }

        static void SearchStudentByName()
        {
            Console.WriteLine("Enter student name to search:");
            string searchName = Console.ReadLine().Trim();

            var foundStudents = students.Where(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (foundStudents.Any())
            {
                Console.WriteLine("Student(s) Found:");
                foreach (var student in foundStudents)
                {
                    Console.WriteLine($"{student.Name}, {student.Class}");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
                
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }
}

