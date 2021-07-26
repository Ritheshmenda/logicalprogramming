using System;
using System.Collections.Generic;
using System.Text;

namespace logicalprogramming
{
    class Temperature
    {
        public void Farcel()
        {
            int celsius, faren;
            string conv;
            Console.WriteLine("enter the conversion");
            conv = Convert.ToString(Console.ReadLine());
            switch (conv)
            {
                case "faren":
                    Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
                    celsius = int.Parse(Console.ReadLine());
                    faren = (celsius * 9) / 5 + 32;
                    Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
                    Console.ReadLine();
                    break;
                case "celcius":
                    Console.WriteLine("Enter the Temperature in farenhiet(°F) : ");
                    faren = int.Parse(Console.ReadLine());
                    celsius = (faren - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Fahrenheit is(°F) : " + celsius);
                    Console.ReadLine();
                    break;


            }
        }
    }
}
