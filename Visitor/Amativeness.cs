using System;

namespace Visitor
{
    class Amativeness:Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，凡事不懂也要装懂。",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，遇事懂也要装作不懂。",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
