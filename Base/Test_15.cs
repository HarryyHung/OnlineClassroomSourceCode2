using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClassroomSourceCode2.Base
{
    public class Test_15 : ITest
    {
        // khoi tao choiceType de dua ra lua chon
        private int choiceType { get; set; }
        public void createQuestion()
        {
            System.Console.WriteLine("Ban muon chon loai bai tap nao?");
            System.Console.WriteLine("1. Assignment");
            System.Console.WriteLine("2. Quiz");
            int choiceType = int.Parse(Console.ReadLine());

            if (choiceType == 1)
            {
                
            }
            else if (choiceType == 2)
            {

            }
            else if (choiceType == 1 && choiceType == 2)
            {

            }
            else
            {
                System.Console.WriteLine("Lua chon khong hop le!");
            }
        }
    }
}