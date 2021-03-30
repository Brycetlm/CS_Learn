using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    #region 什么是程序集
    //经由编译器翻译的，供进一步编译执行的中间产物
    //例如win中的dll和exe文件
    #endregion

    #region 元数据
    //元数据就是用来描述数据的数据
    //程序中的类，类中的函数，变量等信息就是程序的元数据
    //有关程序以及类型的数据被称为元数据，被保存在程序集中
    #endregion

    #region 反射的概念
    //程序正在运行时，可以产看其他程序集或者自身的元数据
    //一个运行的程序查看本身或者其他程序的元数据的行为叫做反射

    //程序运行时，通过反射可以得到其他程序集或者自身程序集代码的各种信息
    //类，函数，变量，对象等，实例化它们，执行他们
    #endregion

    #region 反射的作用
    //因为反射可以在程序编译后获得信息，所以它提高了程序的扩展性和灵活性
    //1.程序运行时得到所有元数据和其特性
    //2.程序运行时，实例化对象，操作对象
    //3.程序运行时创建对象，用这些对象执行任务

    //例如，这个控制台程序没有写任何代码，但是可以利用反射来访问其他程序里的元数据

    #endregion

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
        }

        public Test(int i, string str) : this(i)
        {
            this.str = str;
        }

        public void fun1(int a)
        {

        }
        public void fun2(int a,string b)
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            #region 语法
            //Type
            //类的信息类，是反射的基础，是访问元数据的主要方式
            //使用Type的成员获取有关类型声明的信息


            //1.获取Type //GetType获取
            int a = 42;
            Type t = a.GetType();
            Console.WriteLine(t);
            //1.1 typeof获取
            Type type2 = typeof(int);
            Console.WriteLine(type2);
            //1.2 通过类名获取（类名或者结构体名必须包含命名空间）
            Type type3 = Type.GetType("System.Int32");
            Console.WriteLine(type3);
            //虽然type123可能在栈里有三个不同地址，但都存在同一个堆地址里


            //2.获取类中的所有公共成员
            Type type4 = typeof(Test);
            MemberInfo[] info = type4.GetMembers();          //一个类，用于存储信息
            Console.WriteLine("程序集信息：");
            for (int i=0;i<info.Length;i++)
            {
                Console.WriteLine(info[i]);
            }


            //3.获取类的公共构造函数并调用
            Console.WriteLine("构造函数：");
            ConstructorInfo[] ctors = type4.GetConstructors();
            foreach (var item in ctors)
            {
                Console.WriteLine(item);
            }
            //3.1获取其中一个构造函数并执行

            ConstructorInfo cinfo = type4.GetConstructor(new Type[0]);
            //执行无参构造,无参构造，没有参数，传null即可
            Test obj=cinfo.Invoke(null) as Test;
            Console.WriteLine(obj.j);
            //得到有参构造
            //GetConstructor这个方法需要传入一个Type数组，里面存放的就是构造函数需要的按顺序的参数类型
            //例如被我得到的类型Test，它的构造函数包括Test(string,string,int){};那么这里就需要
            //传入一个Type数组。顺序包含三种类型，类型本身可以用typeof(string)得到
            ConstructorInfo cinfo2 = type4.GetConstructor(new Type[] { typeof(int) });
            obj = cinfo2.Invoke(new object[] { 2 } )as Test;


            //4.获取类的公共成员变量
            Console.WriteLine("公共成员变量：");
            FieldInfo[] finfo = type4.GetFields();
            foreach (var item in finfo)
            {
                Console.WriteLine(item);
            }
            //4.2得到指定名称的公共成员变量
            FieldInfo infoj = type4.GetField("j");
            //4.2.1通过反射获取和设置对象的值
            Test t1 = new Test();   //先实例化一个值，后面用反射的方法获得它的成员变量值
            t1.j = 99;
            t1.str = "fghjk";

            Console.WriteLine(infoj.GetValue(t1)); //这里就用FieldInfo类里面的方法《获得》了对象t1的成员变量"j"的值
            infoj.SetValue(t1,100);       //设置t1里面j变量的值



            //5.获取类的公共成员方法
            Console.WriteLine("获取类的公共成员方法");
            Test t2 = new Test();
            Type t2Ty = t2.GetType();
            MethodInfo[] meinfo = t2Ty.GetMethods();
            foreach (var item in meinfo)
            {
                Console.WriteLine(item);
            }


            //6.其他
            //还可以得到事件，枚举等等

            //Assembly  程序集类
            //Console.WriteLine(type2.Assembly);  //打印出这个类所在的程序集

            //Activator
            #endregion

            Console.ReadLine();
        }

        //!!!!!!!总结
        //想要获取其他程序集中的东西，得分三步走
        //第一步，获取类型Type，比如我想用另一个程序集中的class Poeple，那么首先
        //Type t=typeof(People)         //获得Type方法很多，详情看前面
        //第二步，拿到Type之后，就可以使用里面的很多类型和方法了
        //获得构造函数： 
        //装载类为ConstructorInfo，方法为GetConstructors();（得到全部）,或者不加s，得到一个GetConstructor(Type[] types)
        //获得公共成员： 
        //装载类型为FieldInfo，方法为GetFields，或者指定变量名称GetField("j");
        //获得公共函数：装载类为MethodInfo，方法为GetMethods();方法为GetMethod("fun1");
        //第三步，获得的成员可以赋值GetValue和SetValue，获得的方法可以调用 Invoke();  //注意，如果是静态方法，invoke第一个参数传null
    }
}
