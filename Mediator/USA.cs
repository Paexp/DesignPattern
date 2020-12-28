﻿using System;

namespace Mediator
{
    class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(String message)
        {
            Console.WriteLine("美国获得对方信息：" + message);
        }
    }
}
