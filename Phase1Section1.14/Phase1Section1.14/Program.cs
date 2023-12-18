using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Phase1Section1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\mural\\source\\repos\\Phase1Section1.14\\Phase1Section1.14\\students.txt";

            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found or inaccessible.");
            }

            Console.ReadLine();
        }
    }
}
