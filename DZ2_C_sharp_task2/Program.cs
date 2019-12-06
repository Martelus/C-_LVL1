using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharop_lvl1_dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Написать метод подсчета количества цифр числа.
            Console.WriteLine("Enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            double ostatok = 10;
            int i = -1;
            while ((ostatok > 1) || ((ostatok <= 1) && (number > 0)))
            {
                number = Math.Round(number / 10, 1);
                ostatok = number % 10;
                
                i = i + 1;
            }
            Console.WriteLine($"Count of numbers is {i}");
            Console.ReadLine();
        }
        
        
    }
}
