using System;

namespace Decorator
{
    class Person
    {
        private string name;

        public Person()
        {}

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
}
