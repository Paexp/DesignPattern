namespace ChainofResponsibility
{
    abstract class Manager
    {
        protected string name;
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        abstract public void RequestApplications(Request request);

    }
}
