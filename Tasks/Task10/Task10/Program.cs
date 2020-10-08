using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            taskA();
            Console.WriteLine();
            taskB();
            Console.WriteLine();
            taskC();
            Console.WriteLine();
            taskD();
        }

        private static void taskA()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);

            }
        }

        private static void taskB()
        {
            int b = 0;
            while (b < 11)
            {
                Console.Write("Введите b=");
                b = int.Parse(Console.ReadLine());
            }
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(Math.Pow(i,2));
            }
        }

        private static void taskC()
        {
            int a;
            do
            {
                Console.Write("Введите a=");
                a = int.Parse(Console.ReadLine());
            } while (a > 49);
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }

        }

        private static void taskD()
        {
            int b;
            int a;
            do
            {
                Console.Write("Введите a=");
                a = int.Parse(Console.ReadLine());
                Console.Write("Введите b=");
                b = int.Parse(Console.ReadLine());
            } while (a>b);
            
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

        }



    }
}
