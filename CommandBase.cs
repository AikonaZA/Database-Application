using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public interface CommandBase
    {
        void Execute(List<TestMarks> testMarks, TestMarks newTest);
    }
}
