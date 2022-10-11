using System;

namespace cykly
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = int.Parse(Console.ReadLine());
            int min = Int32.MaxValue;
            int max = -1;
            int soucet = 0;
            for (int i = 0; i < pocet; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                if (tmp<min)
                {
                    min = tmp;
                }
                if (tmp>max)
                {
                    max = tmp;
                }
                soucet = soucet + tmp;
            }
            int prumer = soucet / pocet;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(prumer);
        }
    }
}
