using System;

namespace ConsoleApp15
{
    class Program
    {
        static double a(int n)
        {
            if (n == 1) return 1;

            else return (a(n / 2) + 1);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                { Console.Write("a = " + a(n)); }
                else Console.Write("Число должно быть больше 0!");
            }
            catch { Console.Write("Некорректный ввод!"); }

        }
    }
}
