using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Weekday
    {
        const int sunday = 0, monday = 1, tuesday = 2, wednesday = 3, thursday = 4, friday = 5, saturday = 6;
        public void Weekdays()
        {
           
            Console.WriteLine("enter Month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter day ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m / 12)) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine(d0);
            switch (d0)
            {
                case sunday:
                    Console.WriteLine("sunday");
                    break;
                case monday:
                    Console.WriteLine("monday");
                    break;
                case tuesday:
                    Console.WriteLine("tuesday");
                    break;
                case wednesday:
                    Console.WriteLine("wednesday");
                    break;
                case thursday:
                    Console.WriteLine("thursday");
                    break;
                case friday:
                    Console.WriteLine("friday");
                    break;
                case saturday:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}
