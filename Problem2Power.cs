using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem2Power
{
    static double Power (double number, double power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
    static double Power(double number, double power, bool roundDown)

    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        if (roundDown)
        {
            result = Math.Floor(result);
        }
        return result;
    }


    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        bool roundDown = bool.Parse(Console.ReadLine());
        double toPrint = Power(number, power);
        toPrint = Power(number, power,roundDown);
        Console.WriteLine(toPrint);
    }
}

