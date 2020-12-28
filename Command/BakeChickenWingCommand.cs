namespace Command
{
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
