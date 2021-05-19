using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public abstract class Template
    {
        public abstract void Proceed(double avg);

        public virtual void SupTest()     //Hook
        {

        }
    }
}
