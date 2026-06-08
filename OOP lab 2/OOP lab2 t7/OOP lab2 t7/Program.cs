using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2_t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lenght;
            float area;
            string str;
            Console.WriteLine(" enter the lenght ");
            str =Console.ReadLine();
            lenght = float.Parse(str);
            area = lenght * lenght;
            Console.WriteLine(" the area is ");
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
