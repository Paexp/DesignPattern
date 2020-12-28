using System;

namespace Decorator
{
    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }
}
