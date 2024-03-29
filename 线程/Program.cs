﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程
{
    class Program
    {

        static bool IsRunning = true;
        static object lo=new object();
        static void Main(string[] args)
        {
            //线程作用
            //当有复杂运算时，或者其他需要新线程时，可以新开线程去运算

            //新开线程
            Thread AnotherThread = new Thread(NewThread);

            //开启线程
            AnotherThread.Start();

            //设置为后台线程
            //当前台线程结束后，就算后台线程没有结束，整个程序也会结束
            //后台程序不会防止应用程序的进程被终止
            //如果不设置为后台线程，可能会导致进程无法正常关闭
            AnotherThread.IsBackground=true;  //这里打开之后还是不停的打印是因为后面有ReadLine，所以主线程其实一直没有结束


            //释放一个线程
            //1.用一个标志来开关线程
            //Console.ReadKey();
            //IsRunning = false;
            //2.通过线程提供的方法（在 .net core中不支持）
            //AnotherThread.Abort(); AnotherThread=null;


            //线程休眠
            //!@@!在哪个线程里执行就在哪里休眠!!!!!!!
            //Thread.Sleep(1000);

            //共享内存
            //保证原子操作：锁 lock()
            //lock()要求参数为引用类型

            while(true)
            {
                lock (lo)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚪");
                }

            }


            Console.ReadLine();

        }

        public static void NewThread()
        {
            //while (IsRunning)
            //{
            //    //Thread.Sleep(1000);
            //    Console.WriteLine("新增线程");
            //}

            while (true)
            {
                lock (lo)
                {
                    Console.SetCursorPosition(5, 5);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("√");
                }
            }



        }
    }
}
