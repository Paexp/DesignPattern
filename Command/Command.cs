namespace Command
{
    abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer barbecuer)
        {
            this.receiver = barbecuer;
        }

        abstract public void ExcuteCommand();
    }
}
