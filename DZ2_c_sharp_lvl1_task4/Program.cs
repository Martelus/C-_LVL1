using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_c_sharp_lvl1_task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //4.Реализовать метод проверки логина и пароля.На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            //программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            int count = 1;
            bool auth = true;
            
            do
            {
                Console.WriteLine("Enter login:");
                string log = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string pass = Console.ReadLine();
                if ((log == "root") && (pass == "GeekBrains"))
                {
                    Console.WriteLine("Succsess");
                    auth = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                    auth = false;
                }
                if (auth == false)
                {
                    count = count + 1;
                }
            }
            while (count <= 3);
            Console.ReadLine();
        }
    }
}
