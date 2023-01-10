using System;

namespace lab4ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            WritePyramid(n);
        }

        static void WritePyramid(int n, int i = 1)
        {

            if (n == 0)
            {
                return;
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            WritePyramid(n-1, i+1);

        }
    }
}
