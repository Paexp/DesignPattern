namespace State
{
    class Work
    {
        private State current;

        public Work()
        {
            current = new ForenoonState();
        }
        private double hour = 0;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;

        public bool TashFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
