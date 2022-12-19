using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClassroomSourceCode2.Base
{
    public abstract class TestDecorator : ITest
    {
        ITest test;

        protected int numType = 0;
        protected string createQuestion = "No question";

        public TestDecorator(ITest test)
        {
            this.test = test;
        }

        public int numTypes()
        {
            return 
        }
    }
}