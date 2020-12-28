using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();
            
            student.Wash();
            student.BuyRice();
            student.Sweep();

            Console.Read();
        }
    }
}
