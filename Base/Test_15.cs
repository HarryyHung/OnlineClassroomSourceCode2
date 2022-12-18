using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClassroomSourceCode2.Base
{
    public class Test_15 : ITest
    {
        private int numberQues { get; set; }
        private string write;
        private string choiceQuiz;

        public void createQuestion() 
        {
            System.Console.Write("Number of question you want: ");
            int numberQues = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberQues; i++)
            {
                
            }
            
        }
    }
}