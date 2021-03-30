using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    #region 委托定义
    //委托是函数的容器
    //可以理解为表示函数的变量类型
    //用来存储、传递函数
    //委托的本质是一个类，用来定义函数的类型（返回值和参数的类型）
    //不同的函数必须对应和各自的"格式"一致的委托

    #endregion

    #region 基本语法
    //关键字 delegate
    //访问修饰符 delegate 返回值 委托名（参数列表）

    //可以写在namespace和class语句中
    //更多的写在namespace中
    #endregion

    #region 自定义委托
    //访问修饰符默认不写为public
    //访问修饰符 delegate 返回值 委托名（参数列表）

    delegate void MyFunCollection();  //定义了一个用来存储无参无返回值函数的容器

    delegate int MyIntFun(int a);

    //也可以用泛型来声明委托
    delegate T MyFuns<T>(T a);

    #endregion

    #region 使用已定义的委托
    //通常使用于
    //1.作为类的成员
    //2.作为函数的参数
    class Test
    {
        //委托作为类的成员
        public MyFunCollection myfun;
        public MyIntFun myintfun;

        //委托作为函数参数，可以将函数传入另一个函数
        public void TestFun(MyFunCollection fun1,MyIntFun fun2)  //这个TestFun的参数是两个委托
        {
            //可以在这个函数里处理一些逻辑之后再运行传进来的参数
            //例如有个数据a，在这个函数之前值不确定，但又会被后面的函数调用
            //那么就可以先计算，再传进函数
            int a = 3*1*45214+697;
            fun2.Invoke(a);

        }
    }

    #endregion

    #region 委托变量可以存储多个函数（多播委托）
    //用+=号表示将多个函数纳入委托，那么当这个委托被执行的时候就会执行多个函数
    //-=表示移除一个函数  myfuns-=Fun2;   如果没有这个函数，但是被减掉了也不会报错
    //myfuns=null； 就直接清空
    #endregion

    #region 使用系统定义的委托
    //using system;
    //1.无参无返回的委托Action
    //Action ac = new Action(Fun1);
    //1.1Action也可以传多参数

    //2.泛型委托Func
    //Func<int> func = Fun2; 可以存储返回值为int的函数，这里可以用泛型存储各种类型的函数

    #endregion
    class Program
    {
        static void Fun()
        {
            Console.WriteLine("654555");
        }

        static int Fun2(int a)
        {
            Console.WriteLine("65ddd4555");
            return 0;
        }

        static int Fun3(int a)
        {
            Console.WriteLine("啊啊啊啊啊啊4555");
            return 0;
        }

        static void Main(string[] args)
        {
            MyFunCollection f = new MyFunCollection(Fun);   //这里就用委托容器f装载了函数Fun，这个Fun必须符合MuFunCollection的定义要求
            f.Invoke();   //调用MyFunCollection存储的函数

            //也可以这样用 = 将函数装载进委托
            MyFunCollection f2 = Fun;   //注意没打()，不然就是调用了
            f2();            //另一种调用方式

            MyIntFun f3 = Fun2;

            //将委托作为参数传入类中的函数
            Test t = new Test();
            t.TestFun(f, f3);

            Console.WriteLine("多播委托******************************");
            //多播委托
            MyIntFun intfun = new MyIntFun(Fun2);
            intfun += Fun3;      //用+= 表示新加一个函数
            intfun(3);   //两种调用方法
            //intfun.Invoke(3);
            

            Console.ReadLine();
        }

        
    }
}
