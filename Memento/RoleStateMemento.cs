namespace Memento
{
    class RoleStateMemento
    {
        private int vit;
        private int atk;
        private int def;

        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }

        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }

        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }

        public int Defence
        {
            get { return def; }
            set { def = value; }
        }
    }
}
