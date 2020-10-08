using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            do
            {
                Console.Write("Введите четырехзначное число:");
                 a = int.Parse(Console.ReadLine());
            } while (a<1000||a>9999);

            Console.WriteLine($"Сумму его цифр:{(a%10)+(a/10%10)+(a/100%10)+(a/1000)}");
            Console.WriteLine($"Произведение его цифр:{(a % 10) * (a / 10 % 10) * (a / 100 % 10) * (a / 1000)}");
        }
    }
}
