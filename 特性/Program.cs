using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace 特性
{

    #region    特性是什么
    //特性是一种允许我们向程序的程序集添加元数据的语言结构
    //用于保存程序结构信息的某种特殊类型的类

    //特性提供强大的方法以将声明信息和C#代码（类型、方法、属性等）相关联
    //特性和程序实体关联后，即可在运行时用发射查询特性信息

    //特性的目的是高度编译器把程序结构的某组元数据嵌入程序集中
    //它可以放置在几乎所有声明中

    //特性的本质是个类
    //利用特性类为元数据添加额外信息
    //比如一个类、成员变量、成员方法等为他们添加更多的额外信息
    //之后可以通过反射来获取这些额外信息

    #endregion

    #region     自定义特性
    //继承Attribute之后就能自定义特性
    class MyTestAttribute : Attribute    //这就声明了一个特性,特性名后面的Attribute会被系统省略
    {
        public string info;
        public MyTestAttribute(string str)
        {
            this.info = str;
        }
    }
    #endregion

    #region     特性的使用
    //语法
    //[特性名（参数列表）]
    //本质上就是在调用特性的构造函数
    //写在哪里？
    //类、函数、变量上一行，表示他们有该特性信息
    [MyTest("这是一个特性")]  //这个特性信息在别人获得反射的时候会留给别人
    class Myclass
    {
        [MyTest("这是一个表示年龄的变量")]
        public int age;
        [MyTest("这是一个没啥用的函数")]
        public void fun1()
        {
            Console.WriteLine("调用方法1");

        }

        public void fun2()
        {
            Console.WriteLine("调用方法2");

        }
    }
    #endregion

    #region     限制自定义特性的使用范围
    //通过为特性类再加一个特性就可以限制其使用范围
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Field,AllowMultiple =true,Inherited =true)]; //系统自带的特性，还可以加其他限制属性，来限制后面的自定义特性
    public class MyTest2Attribute : Attribute
    {

    }
    #endregion


    #region     系统自带特性-过时特性
    //用于体是使用的方法或者成员已经过时了
    [Obsolete("Old function is out of date,please try new one",false)] //false警告，true直接报错
    #endregion

    #region     系统自带特性-调用者信息
    //可以打印调用信息
    [CallerFilePath]
    [CallerLineNumber]
    [CallerMemberName]
    #endregion

    #region     系统自带特性-条件编译特性
    //主要用于调试代码
    //有时想执行，有时不想执行
    [Conditional("Fun")]//条件特性，和#define配合使用，表示必须#define Fun才能使用这个程序中的Fun函数，否则不让用
    #endregion

    #region     系统自带特性-外部dll包函数特性
    //DllImport

        //用来标记非.net得函数，表明该函数在一个外部得DLL中定义
        //一般用来调用c或者cpp得Dll包
        [DllImport]

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //特性实验
            Myclass t = new Myclass();
            Type ty = t.GetType();
            //判断是否使用了特性
            if (ty.IsDefined(typeof(MyTestAttribute), false)) //第二个参数表示要不要搜索继承链（属性和事件忽略此参数）
            {
                Console.WriteLine("该Type应用了MyTestAttribute特性");
            }
            //得到特性
            object[] arr = ty.GetCustomAttributes(true);
            foreach (var item in arr)
            {
                Console.WriteLine((item as MyTestAttribute).info);

            }


            //MethodInfo me = ty.GetMethod("fun1");
            //Console.WriteLine(me);
            Console.ReadLine();
        }
    }
}
