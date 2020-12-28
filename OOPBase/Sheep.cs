using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Sheep : Animal
    {
        public Sheep() : base()
        {}
 
        public Sheep(string name) : base(name)
        {}

        protected override string getShoutSound()
        {
            return "咩";
        }
    }
}
