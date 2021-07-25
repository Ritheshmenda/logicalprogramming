using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Perfect
    {
        public void Perfectnum()
        {
            int number, i, sum;
            Console.Write("Input the  number : ");
            number = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}   ", +sum);
            Console.WriteLine("");
            if (sum == number)
            {
                Console.WriteLine("So, the number is perfect.");
            }
            else
            {
                Console.Write("So, the number is not perfect");
               
            }

        }
    }
}
