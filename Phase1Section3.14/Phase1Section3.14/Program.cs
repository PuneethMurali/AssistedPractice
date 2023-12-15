using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Phase1Section3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\Users\mural\source\repos\Phase1Section3.14\students.txt";
                string[] lines = File.ReadAllLines(filePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}




