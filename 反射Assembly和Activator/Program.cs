using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射Assembly和Activator
{
    //!!!!!!!!!!可以用@去校\的转义，在取路径时很好用
    //Assembly.LoadFrom(@"C\xx\xxx\");
    class Program
    {
        class Test
        {
            private int i = 1;
            public int j = 0;
            public string str = "123";
            public Test()
            {

            }
            public Test(int i)
            {
                this.i = i;
                this.j = i;
            }

            public Test(int i, string str) : this(i)
            {
                this.str = str;
            }

            public void fun1(int a)
            {

            }
            public void fun2(int a, string b)
            {

            }

        }

        static void Main(string[] args)
        {
            //Assembly  程序集类
            //主要用加载其他程序集，记载后才能用Type来使用其他程序集中的信息
            //如果不是用自己程序集中的东西，那么要先佳在程序集

            //三种加载程序集的函数
            //1.加载同一文件下的其他程序集
            //Assembly as1 = Assembly.Load("程序集名称");


            //2.加载不同文件下的其他程序集
            //Assembly as2 = Assembly.LoadFrom("包含程序集清单的文件的名称或者路径");
            //Assembly as3 = Assembly.LoadFile("要加载的文件完全限定路线");


            //使用
            //1.先加载一个程序集
            Assembly as2 = Assembly.LoadFrom(@"C:\Users\57212\source\repos\CS_Learn\逆变和谐变\bin\Debug\逆变和谐变.exe");
            Type[] type2 = as2.GetTypes();
            foreach (var item in type2)
            {
                Console.WriteLine(item);
            }
            //2.调用别的程序集的代码
            //2.1 如果调用非静态函数，《就要先实例化一个对象》
            Type classget = as2.GetType("逆变和协变.Father");//获取as2程序集中名为Father的类 //!!!!!！！！！!!!注意，要带命名空间！！！

            //MethodInfo me= classget.GetMethod("Walking");
            //me.Invoke(me, new object[0]);     //这里不能直接调用，因为Walking函数不是静态的，必须依托对象才能存在


            ////2.2换一个静态的函数试试
            MethodInfo stame= classget.GetMethod("Run");
            stame.Invoke(stame, new object[] { 772});   //静态的话这里可以不写stame，因为他没有引用对象
            stame.Invoke(null, new object[] { 32});     //注意这里的第二个参数，是一个object数组，里面放的值就是传进方法的参数


            //Activator
            //用于快速实例化对象的类
            //用于将Type对象快捷实例化为对象
            //先得到Type，然后快速实例化一个对象
            //Console.WriteLine(type2.Assembly);  //打印出这个类所在的程序集

            ////1.无参构造
            //Type t = typeof(Test);
            //Test test=Activator.CreateInstance(t) as Test; //默认使用无参构造
            //Console.WriteLine(test.j);

            ////2.无参构造
            //test = Activator.CreateInstance(t,83) as Test;
            //Console.WriteLine(test.j);

            Console.ReadLine();
        }
    }
}
