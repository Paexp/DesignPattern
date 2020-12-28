using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Monkey : Animal
    {
        public Monkey() : base()
        {}
 
        public Monkey(string name) : base(name)
        {}

        protected override string getShoutSound()
        {
            return "吱";
        }
    }
}
