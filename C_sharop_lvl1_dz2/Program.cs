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
            //1.Написать метод, возвращающий минимальное из трех чисел.
            Console.WriteLine("Enter first number");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int snum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter therd number");
            int tnum = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if ((fnum > snum) && (fnum > tnum))
            {
                max = fnum;
            }
            if ((fnum > snum) && (fnum < tnum))
            {
                max = tnum;
            }
            if ((fnum < snum) && (fnum > tnum))
            {
                max = snum;
            }
            if ((fnum < snum) && (fnum < tnum))
            {
                max = tnum;
            }
            if ((fnum == snum) && (fnum == tnum))
            {
                Console.WriteLine("Numbers are equial");
                max = fnum;
            }
            if ((fnum == snum) && (fnum < tnum))
            {
                max = tnum;
            }
            if ((fnum == snum) && (fnum > tnum))
            {
                max = fnum;
            }
            if ((fnum == tnum) && (fnum < snum))
            {
                max = snum;
            }
            if ((fnum == tnum) && (fnum > snum))
            {
                max = fnum;
            }
            Console.WriteLine($"Maximum number is {max}");
            Console.ReadLine();
            
        }
    }
}
