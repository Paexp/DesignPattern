using System;

namespace Visitor
{
    class Marriage : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，感慨道：恋爱游戏终结时，‘有妻徒刑’遥无期。",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，欣慰曰：爱情长跑路漫漫，婚姻保险保平安。",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
