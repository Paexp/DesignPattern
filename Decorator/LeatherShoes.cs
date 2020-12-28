using System;

namespace Decorator
{
    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }
}
