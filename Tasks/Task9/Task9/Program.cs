using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите напряжение 1:");
            double U1 = double.Parse(Console.ReadLine());
            Console.Write("Введите напряжение 2:");
            double U2 = double.Parse(Console.ReadLine());

            Console.Write("Введите сопротивление 1:");
            double R1 = double.Parse(Console.ReadLine());
            Console.Write("Введите сопротивление 2:");
            double R2 = double.Parse(Console.ReadLine());

            double I1 = U1 / R1;
            double I2 = U2 / R2;

            if (I1 > I2)
                Console.WriteLine("Сила тока меньше в правой цепи");
            else if (I1 < I2)
                Console.WriteLine("Сила тока меньше в левой цепи");
            else
                Console.WriteLine("Они равны");

        }
    }
}
