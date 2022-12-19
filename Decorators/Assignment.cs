using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineClassroomSourceCode2.Base;

namespace OnlineClassroomSourceCode2.Decorators
{
    public class Assignment : TestDecorator
    {
        // khoi tao ham tao de dua gia tri vao interface ITest
        public Assignment(ITest inner) : base(inner)
        {
        }

        public override string createQuestion()
        {
            System.Console.WriteLine("1. What's your name?");
            string answer1 = Console.ReadLine();
            return (answer1 + base.createQuestion());
        }
    }
}