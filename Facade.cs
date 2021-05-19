using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public class Facade
    {
        private Pass pass;
        private PassWithDistinction passWithDistinction;
        private Fail fail;
        private int avarage;

        public Facade()
        {
            pass = new Pass();
            passWithDistinction = new PassWithDistinction();
            fail = new Fail();
        }

        public void DisplayMarkResult(double average)
        {
            Student student = Student.GetStudent();
            //output stuff

            if (avarage >= 75)
            {
                passWithDistinction.PassWithDistinctionMethod();
            }
            else if (avarage >= 50 && avarage < 75)
            {
                pass.PassMethod();
            }
            else if (avarage < 50)
            {
                fail.FailMethod();
            }
        }
    }
}
