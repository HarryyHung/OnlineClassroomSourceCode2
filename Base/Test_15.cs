using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClassroomSourceCode2.Base
{
    public class Test_15 : ITest
    {
        private int numType { get; set; }
        private int choiceTest_15 { get; set; }
        // Pass a parameter when entering test time
        public string timeTest(int timeTest)
        {
            return "Create a successful 15 minute lesson. Please enter the number of test types you want: ";
        }

        // Pass a parameter when you enter the number of test types
        public int numTypes(int _numType)
        {
            this.numType = _numType;
            return this.numType;
        }

        // Pass
        public string types()
        {
            for (int i = 0; i < numType; i++)
            {
                System.Console.WriteLine("1. Assignment");
                System.Console.WriteLine("2. Quiz");
                System.Console.WriteLine("3. Presentation");
                choiceTest_15 = int.Parse(Console.ReadLine());

                if (choiceTest_15 == 1)
                {
                    return "Question " + (numType + 1);
                }
                // else if()
                else
                {
                    return null;
                }
            }
        }

    }
}