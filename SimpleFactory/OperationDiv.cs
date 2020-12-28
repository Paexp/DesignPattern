﻿using System;

namespace SimpleFactory
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0。");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
