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
            //3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                Console.WriteLine("Enter the number to sum, enter 0 to break");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine($"Sum of numbers is {sum}");
            Console.ReadLine();
        }
    }
}

