﻿namespace Mediator
{
    class UnitedNationsSecurityCouncil : UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        public USA Colleague1
        {
            get { return colleague1; }
            set { colleague1 = value; }
        }

        public Iraq Colleague2
        {
            get { return colleague2; }
            set { colleague2 = value; }
        }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
