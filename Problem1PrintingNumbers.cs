using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problem1PrintingNumbers
    {
    static void PrintEvenNumbers(int minRange, int maxRange)
    {
        for (int i = minRange; i <= maxRange; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main()
    {
        int minRange = int.Parse(Console.ReadLine());
        int maxRange = int.Parse(Console.ReadLine());
        PrintEvenNumbers(minRange, maxRange);
    }
}

