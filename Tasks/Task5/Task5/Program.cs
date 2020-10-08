using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            do
            {
                Console.Write("Введите:");
                 k = int.Parse(Console.ReadLine());
            } while (k > 99||k<10);


            
            Console.WriteLine($"a. {k / 10}"); 
            Console.WriteLine($"b. {k % 10}");
            Console.WriteLine($"c. {(k / 10)+(k%10)}");
            Console.WriteLine($"d. {(k / 10) * (k % 10)}");
        }
    }
}
