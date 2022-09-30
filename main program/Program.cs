using System.ComponentModel.Design;

namespace main_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу, которую хотите запустить:\r\n" + "1.Угадай число\r\n" + "2.Вывод делителей числа\r\n" + "3.Выход");
            int oper = Convert.ToInt32(Console.ReadLine());
            if (oper==1)
            {
                Random(args);
            }
            else if (oper==2)
            {
                Deliteli(args);
            }
            else if (oper == 3)
            {
                Exit(args);
            }
        }



        static void Random(string[] args)
        {
            int a = new Random().Next(100);
            Console.WriteLine("Эй, Попробуй угадать число от 1 до 100!");
            bool log = true;
            do
            {
                Console.Write("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b==a)
                {
                    Console.WriteLine("Молодец, ты угадал!");
                    log = false;
                }
                else if (b>a)
                {
                    Console.WriteLine("Нужно число меньше");
                }
                else if (b<a)
                {
                    Console.WriteLine("Нужно число побольше");
                }
            } while (log==true);
            Main(args);
        }

        static void Deliteli(string[] args)
        {
            Console.WriteLine("Введи число");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {

                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            Main(args);
        }

        static void Exit(string[] args)
        {
            Console.WriteLine("Выход из программы выполнен");
        }

    }
}