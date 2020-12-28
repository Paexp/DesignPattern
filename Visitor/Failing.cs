using System;

namespace Visitor
{
    class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，闷头喝酒，谁也不用劝。",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，遇事懂也要装作不懂。",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
