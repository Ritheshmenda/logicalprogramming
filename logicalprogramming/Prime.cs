using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Prime
    {
        public void Primenum()
        {
            int number;
            int i;
            Console.WriteLine("enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            if(number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
            }
            else
            {
                for (i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
            }
        }
    }
}
