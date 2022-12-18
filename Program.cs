﻿using System;
using OnlineClassroomSourceCode2.Base;

namespace OnlineClassroomSourceCode2
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                System.Console.WriteLine("Danh sach thao tac: ");
                System.Console.WriteLine("1. Tao bai: ");
                System.Console.WriteLine("2. Xem bai: ");
                System.Console.WriteLine("3. Xem thong tin thanh vien: ");
                Console.Write("Nhap lua chon cua ban duoi day: ");
                int choiceMenu = int.Parse(Console.ReadLine());

                switch (choiceMenu)
                {
                    case 1:
                        System.Console.Write("Chon thoi gian bai test: ");
                        int timeTest = int.Parse(Console.ReadLine());
                        if (timeTest == 15)
                        {
                            ITest test1;
                            test1 = new Test_15();
                            if (timeTest == 15) test1.createQuestion();
                        }

                        break;
                    case 2:
                        System.Console.WriteLine("Menu 2");
                        break;
                    default:
                        System.Console.WriteLine("Menu 3");
                        break;
                }
            } while (true);

        }
    }
}
