using System;
using System.Collections.Generic;

namespace Observer
{
    class Secretary : Subject
    {
        public delegate void EventHandler();
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
