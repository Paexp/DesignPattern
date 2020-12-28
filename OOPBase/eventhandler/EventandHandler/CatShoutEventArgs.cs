using System;

namespace EventandHandler
{
    class CatShoutEventArgs : EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
