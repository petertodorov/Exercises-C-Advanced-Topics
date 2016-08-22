using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem3ArrayIntegers
{
    static void Main()
    {
        int[] myArray = new int[10];
       Random number = new Random();
        int sum = 0;
        for (int i = 0; i <myArray.Length; i++)
        {
            myArray[i] = number.Next(0, 100);
            sum += myArray[i];
            Console.WriteLine(sum);
        }
    }
}

