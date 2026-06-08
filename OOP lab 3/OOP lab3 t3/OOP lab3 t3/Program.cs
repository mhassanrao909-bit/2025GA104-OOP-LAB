using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab3_t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine(" enter a number");
            num=int.Parse(Console.ReadLine());
            while(num!=-1)
            {
                sum = sum + num;
                Console.WriteLine(" enter again number");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the total sum is " + sum);
        }
    }
}
