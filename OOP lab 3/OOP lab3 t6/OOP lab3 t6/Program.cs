using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab3_t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCount = 0;
            double moneySaved = 0;
            double evenMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)  
                {
                    toysCount++;
                }
                else   
                {
                    evenMoney += 10;
                    moneySaved += evenMoney - 1; 
                }
            }

            moneySaved += toysCount * toyPrice;

            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine("Yes! " + (moneySaved - washingMachinePrice).ToString("F2"));
            }
            else
            {
                Console.WriteLine("No! " + (washingMachinePrice - moneySaved).ToString("F2"));
            }
        }
    }
}
