using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab3_t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            do
            {
                Console.Write("Enter number (-1 to stop): ");
                num = int.Parse(Console.ReadLine());

                if (num != -1)
                {
                    sum += num;
                }

            } while (num != -1);

            Console.WriteLine("Total Sum = " + sum);
        }
    }
}
