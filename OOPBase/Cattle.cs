using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Cattle : Animal
    {
        public Cattle() : base()
        {}
 
        public Cattle(string name) : base(name)
        {}

        protected override string getShoutSound()
        {
            return "哞";
        }
    }
}
