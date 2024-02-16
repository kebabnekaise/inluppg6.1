using System;

namespace inluppg6_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 1;
            int tal2 = 2;
            int tal3 = 3;
            int summa = Addera(tal1, tal2, tal3);
            Console.WriteLine(summa);
        }

        static int Addera(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}