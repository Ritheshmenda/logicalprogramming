using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Decimaltobinary
    {
        public void Dtb()
        {
            int i;
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] binarynumber = new int[100];
            for (i = 0; number > 0; i++)
            {
                binarynumber[i] = number % 2;
                number /= 2;
            }
            Console.Write("Binary representation ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binarynumber[i]);
            }
        }
    }
}
