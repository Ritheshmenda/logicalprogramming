using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Reverse
    {
        public void Reversenum()
        {
            int num, reminder, sum = 0, t;
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                reminder = t % 10;
                sum = sum * 10 + reminder;
            }
            Console.WriteLine("The number in reverse order is : {0}", sum);
        }
    }
}
