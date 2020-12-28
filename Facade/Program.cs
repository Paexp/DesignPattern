using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund jijin = new Fund();

            jijin.BuyFund();
            jijin.SellFund();

            Console.Read();
        }
    }
}
