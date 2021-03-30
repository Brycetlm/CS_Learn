using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        //泛型类和接口
        class TestClass<T>     //这里的T就是一个泛型，表示不知道类型的一个参数，并不是构造函数中的参数，而是这个类中的所有T都表示传进来的这种参数类型
        {
            public T a;  //这里就表示声明了一个T类型的变量a，T可能是传进来的任何类型，比如int
        }

        class MulitiClass<T,K,L>
        {
            public T a;
            public K b;
            public L c;
        }

        //接口在被继承的时候也需要填写类型
        interface TestInterface<T>
        {
            T Value
            {
                get;
                set;
            }
        }

        class Animals:TestInterface<int>
        {
            public int Value
            {
                get;
                set;
            }
        }

        //泛型方法
        //1.普通类中的泛型方法
        //当成参数来传递类型
        //default(T) 获得T的默认值类型！！！！
        class Test2
        {
            public void Fun<T>(T value)
            {
                
                Console.WriteLine(value);
            }
        }


        static void Main(string[] args)
        {
            //泛型实现了类型参数化，达到代码重用
            //通过类型参数化来实现同一份代码上操作多中类型

            //泛型相当于占位符
            //定义类或者方法时使用替代符代替变量类型
            //使用方法时再指定类型
            //类似类模板和函数模板


            //泛型分类
            //泛型类和泛型接口

            TestClass<int> t = new TestClass<int>();
            t.a=10;

            MulitiClass<int,string, bool> mt= new MulitiClass<int, string, bool>();
            mt.a = 10;
            mt.b = "55";
            mt.c = true;
    
        }
    }
}
