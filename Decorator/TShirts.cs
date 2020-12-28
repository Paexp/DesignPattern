using System;

namespace Decorator
{
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }
}
