using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool X = true;
            bool Y = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                {
                    X = false;
                    Y = true;
                }else if (i==2)
                {
                    X = true;
                    Y = false;

                }else if (i == 3)
                {
                    X = false;
                    Y = false;
                }
                Console.WriteLine(!X && !Y);
                Console.WriteLine(X || (!X && Y));
                Console.WriteLine(((!X && Y) || Y)+"\n");
            }
        }
    }
}
