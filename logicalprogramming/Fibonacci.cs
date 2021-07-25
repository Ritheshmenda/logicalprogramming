using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Fibonacci
    {
        public void Fibonaucci()
        {
            int number1 = 0, number2 = 1, number3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(number1 + " " + number2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;
            }

        }
    }
}
