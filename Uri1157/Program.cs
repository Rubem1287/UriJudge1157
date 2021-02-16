using System;

namespace Uri1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= n; c++)
            {
              
                if (n % c == 0)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
