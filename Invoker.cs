using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public class Invoker
    {
        private CommandBase commandBase;
        private TestMarks testMark;
        private Receiver receiver;

        public Invoker()
        {
            receiver = new Receiver();
        }

        public void SetCommand(int commandOption)
        {
            commandBase = new CommandFactory().GetCommand(commandOption);
        }

        public void SetTestmark(TestMarks mark)
        {
            testMark = mark;
        }

        public void ExecuteCommand()
        {
            receiver.ExecuteCommand(commandBase, testMark);
        }

        public void ShowCurretOrder()
        {
            receiver.ShowCurrentOrderItems();
        }
    }
}
