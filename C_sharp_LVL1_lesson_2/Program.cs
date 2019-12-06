using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_LVL1_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task2

            Random r = new Random();
            int weather = r.Next(-30, 30);
            Console.WriteLine($"Weather = {weather}");


            #endregion


            #region task1

            //Random r = new Random();
            //int weather = r.Next(-30, 30);
            //Console.WriteLine($"Weather = {weather}");

            //if (weather <= -5)
            //{
            //    Console.WriteLine("Нужна шапка");
            //    Console.WriteLine("ООООчень холодно");
            //}
            //if ((weather > -5) && (weather < 10)) Console.WriteLine("Решайте сами, надувать ли шапку");
            //if (weather >= 10) Console.WriteLine("шапка не нужна");

            //Console.ReadLine();

            #endregion
        }
    }
}
