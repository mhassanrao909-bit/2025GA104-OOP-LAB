using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4_t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "data.txt";

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}
