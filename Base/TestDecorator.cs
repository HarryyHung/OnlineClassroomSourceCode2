using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClassroomSourceCode2.Base
{
    public abstract class TestDecorator : ITest
    {
        private ITest test;

        protected TestDecorator(ITest inner)
        {
            test = inner;
        }
        public virtual void createQuestion()
        {
            test.createQuestion();
        }
    }
}