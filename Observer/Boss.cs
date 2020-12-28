using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Boss : Subject
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
