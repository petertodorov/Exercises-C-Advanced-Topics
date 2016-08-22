using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem4TextModification
{
    static void Main()
    {
        string sentence = "you though this deer was real…nope, just chuck testa.";
        Console.WriteLine(sentence);
        int[] number = new int[sentence.Length];
        for (int i = 0; i < sentence.Length; i++)
        {
            number[i] = Convert.ToInt32(sentence[i]);
            if (number[i] % 3 == 0)
            {
                int newNumber = number[i] - 32;
                number[i] = newNumber;
            }
            Console.Write((char)(number[i]));
        }
    }
}

