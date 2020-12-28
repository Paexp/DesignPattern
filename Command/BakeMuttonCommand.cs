namespace Command
{
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer barbecuer) : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
