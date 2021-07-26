using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Monthlypay
    {
        public void Monthlypayments()
        {
            double P, R, Y, n, r, payment;
            Console.WriteLine("enter Principal Loan Amount :");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Interest : ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number of Years to pay");
            Y = Convert.ToDouble(Console.ReadLine());
            n = 12 * Y;
            r = R / (12 * 100);
            payment = P * r / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Monthly Payment is " + payment);
        }
    }
}
