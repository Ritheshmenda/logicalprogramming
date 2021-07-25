using System;

namespace logicalprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            Console.WriteLine("Enter an operation");
            operation = Convert.ToString(Console.ReadLine());
            switch (operation)
            {
                case "fibonacci":
                    Fibonacci pow = new Fibonacci();
                    pow.Fibonaucci();
                    break;
                case "perfectnum":
                    Perfect per = new Perfect();
                    per.Perfectnum();
                    break;
            }

        }
    }
}

