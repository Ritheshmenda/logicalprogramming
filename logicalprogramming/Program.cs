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
                case "prime":
                    Prime pri = new Prime();
                    pri.Primenum();
                    break;
                case "reverse":
                    Reverse rev = new Reverse();
                    rev.Reversenum();
                    break;
                case "weekday":
                    Weekday week = new Weekday();
                    week.Weekdays();
                    break;
                case "temperature":
                    Temperature temp = new Temperature();
                    temp.Farcel();
                    break;
                case "monthlypayment":
                    Monthlypay pay = new Monthlypay();
                    pay.Monthlypayments();
                    break;
                case "decimaltobinary":
                    Decimaltobinary dec = new Decimaltobinary();
                    dec.Dtb();
                    break;
                case "moneyvending":
                    Moneyvending mon = new Moneyvending();
                    mon.Mvm();
                    break;
            }

        }
    }
}

