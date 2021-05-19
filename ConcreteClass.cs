using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public class ConcreteClass : Template
    {
        public double tm5;
        public override void Proceed(double avg)
        {
            if (avg < 50 && avg >= 45)
            {
                //Supp Test
                //get marks
                SupTest();
            }
            else if (avg >= 50)
            {
                //pass
                //display pass
            }
            else
            {
                //fail
            }
        }
        public override void SupTest()
        {
            //get supp test
        }
    }
}
