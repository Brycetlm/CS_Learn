using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda表达式
{
    class Program
    {
        //什么是Lamda表达式
        //可以理解为匿名函数的简写
        //除了写法不一样之外，使用和匿名函数一摸一样，都是配合事件委托使用,无法单独使用

        //语法
        //匿名函数语法：
        //delegate ()
        //{

        //}
        //Lamda表达式语法
        //（参数列表）=>
        //    {
        //    函数体
        //    };


        //使用
        static void Main(string[] args)
        {
            //1.无参无返回值
            Action a = () =>
             {
                 Console.WriteLine("无参无返回值");
             };
            a();

            //2.有参
            Action<int> a2 = (int value) =>
              {
                  Console.WriteLine("有参数"+value);
              };
            a2(448650);
            //3.函数类型都可以省略，参数类型和委托或事件容器一致
            Action<int> a3 = ( value) =>
            {
                Console.WriteLine("直接省略参数类型，因为泛型事件里面有类型。参数：" + value);
            };
            a3(580);


            //4.有返回值
            //Func泛型的《最后一个参数》就是返回值，Action是没有返回值的
            Func<int, int, string> f1 = (value, value2) =>
                {

                    Console.WriteLine("有返回值的");
                    return (value+value2).ToString();

                };
            Console.WriteLine(f1(25553, 360));

            //闭包
            //内层的函数可以引用包含在它外层的函数的变量
            //即使外层函数已经终止
            //注意：
            //该变量提供的值并不是创建时的值，而是在父函数范围内的最终值

            Test t = new Test();
            t.export();

            Console.ReadLine();
        }

        class Test
        {
            public Action ac;
            public Test()
            {
                //闭包
                //内层的函数可以引用包含在它外层的函数的变量，即使外层函数的执行已经终止
                //内层的函数，就是那个Lamda函数，其被ac包裹，但是它可以使用外层的value值
                int value = 10;
                ac = () =>
                  {
                      Console.WriteLine(value);
                  };

                //该变量提供的值并不是创建时的值，而是在父函数范围内的最终值
                for (int i = 0; i < 10; i++)
                {
                    ac += () =>
                      {
                          Console.WriteLine(i);     //这里全部输出10,因为当外部调用这个函数的时候，for循环早就跑完了
                                                    //但是并没有调用这个匿名函数，只是把i值寄存在里面，i的父函数最终值就是10
                                                    //如果就要输出1-10，那么可以int index=i; Console.WriteLine(index);这样每次
                                                    //都会新声明一个index
                      };
                }
            }

            public void export()
            {
                ac();
            }
        }
    }
}
