using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名函数
{
    #region 什么是匿名函数
    //就是没有名字的函数
    //主要是配合委托和事件使用
    //脱离委托和事件基本不会使用匿名函数
    #endregion

    #region 基本语法
    //delegate (参数列表)
    //{
    //}
    //何时使用？
    //1.委托中传递委托参数时
    //2.委托或者事件赋值时
    #endregion

    #region 使用
    //匿名函数不能单独存在，只能存在事件或者委托中
    // delegate ()      //报错
    //{

    // }

    //无参匿名
    //用Action存起来
    //Action ac = delegate ()
    //  {
    //      Console.WriteLine("匿名函数逻辑");
    //  };

    //有参匿名
    //Action<int> intac = delegate (int a)
    //  {
    //      Console.WriteLine("匿名函数逻辑");
    //  };

    //有返回值的匿名函数不需要写返回值类型，和有参匿名写法一样，但是<>代表的是返回值
    //Action<int> intacre = delegate ()
    //  {
    //      Console.WriteLine("匿名函数逻辑");
    //  };

        //《匿名函数可以直接在传递函数参数时候声明，传递进去》
        //《t.test()()这种两个括号的，说明返回的是一个函数，然后直接又调用这个函数》
    #endregion

    #region 缺点
        //添加到委托或者事件中后  不记录  无法单独移除
        //实验见Main
    #endregion

    class Test
    {
        public Action a;
        public void TestFun(int a,Action b)
        {

            Console.WriteLine(a);
            b();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //《匿名函数可以直接在传递函数参数时候声明，传递进去》
            Test t = new Test();
            t.TestFun(100, delegate () {
                Console.WriteLine("直接声明在参数中的匿名函数");
            });


            //添加到委托或者事件中后  不记录  无法单独移除
            Action a1 = delegate ()
              {
                  Console.WriteLine("匿名函数1");
              };

            a1 += delegate ()
              {
                  Console.WriteLine("匿名函数2");
              };

            a1();
            //如果这个时候我想移除匿名函数1是没办法的，因为没有名字，无法指定
            //直接移除一模一样的函数也是不行的，没作用
            a1-= delegate ()
            {
                Console.WriteLine("匿名函数2");
            };

            //输出还是两次
            a1();

            Console.ReadLine();
        }
    }
}
