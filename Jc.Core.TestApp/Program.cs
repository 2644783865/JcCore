﻿using Jc.Core.Helper;
using Jc.Core.TestApp.Test;
using System;

namespace Jc.Core.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试即将开始,请按任意键继续.");
            Console.ReadKey();
            ListAddTest test = new ListAddTest();
            test.Test();
            SubTableListAddTest test1 = new SubTableListAddTest();
            test1.Test();

            Console.WriteLine("测试完成,请按任意键继续.");
            Console.ReadKey();
        }
    }
}
