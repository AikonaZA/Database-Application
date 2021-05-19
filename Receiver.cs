using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Application
{
    public class Receiver
    {
        public double average;

        // command pattern
        public List<TestMarks> currentMarks { get; set; }
        public Receiver()
        {
            currentMarks = new List<TestMarks>();
        }

        public void ExecuteCommand(CommandBase command, TestMarks mark)
        {
            command.Execute(this.currentMarks, mark);
        }

        public void ShowCurrentOrderItems()
        {
            foreach (var mark in currentMarks)
            {
                this.average = average + mark.test1;
                this.average = average + mark.test2;
                this.average = average + mark.test3;
                this.average = average + mark.test4;
            }
            //code to show marks
            // template pattern
            ConcreteClass concrete = new ConcreteClass();
            concrete.Proceed(average);
            average = average + (concrete.tm5 * 0.10);
            //ADD CODE TO WINDOWS FORM
            // template pattern end

            // facade pattern
            Facade facade = new Facade();
            facade.DisplayMarkResult(average);
            Pass pass = new Pass();
            PassWithDistinction passWithDistinction = new PassWithDistinction();
            Fail fail = new Fail();
            // facade pattern end
        }
    }
}
