using System;

namespace Decorator
{
    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西装 ");
            base.Show();
        }
    }
}
