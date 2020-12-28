using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Subject
    {
        void Notify();

        string SubjectState
        {
            get;
            set;
        }
    }
}
