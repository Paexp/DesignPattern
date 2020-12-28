using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "A";
            a[1] = "B";
            a[2] = "C";
            a[3] = "D";
            a[4] = "E";
            Iterator i = new ConcreteIteratorDesc(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票！",i.CurrentItem());
                i.Next();
            }

            Console.Read();
        }
    }
}
