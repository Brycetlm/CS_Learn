using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型约束
{
    class Program
    {
        //泛型约束定义
        //让泛型类型有一定约束
        //关键字where
        //泛型约束一共有6种，要求T为：
        //1.值类型                 where 泛型字母:struct
        //2.引用类型                where 泛型字母:class
        //3.存在无参公共构造函数                where 泛型字母:new()
        //4.某个类本身或者其派生类                where 泛型字母:类名
        //5.某个接口的派生类型                where 泛型字母:接口名
        //6.另一个泛型本身或者派生类型                where 泛型字母:另一个泛型字母

        //1.值类型
        class Test1<T>where T:struct
        {

        }

        //2.引用类型和值类型要求相似

        //3.存在无参公共构造函数
        //泛型类必须有《公共的》（也就是public）无参构造函数（class中申明有参构造后会把默认无参覆盖）
        class Test3<T>where T:new()
        {

        }

        class T3
        {

        }

        class T3_1
        {
            public T3_1(int a)   //这里有一个有参构造
            {

            }
        }
        class T3_2
        {
            public T3_2(int a)   //这里有一个有参构造
            {

            }

            public T3_2()
            {

            }
        }

        struct Student
        {

        }



        //约束结合使用
        class Test4<T> where T: class,new()   //这里就有两个约束条件
        {

        }

        //多个泛型约束
        class Test5<T,K> where T : class, new() where K:class  //这里就有两个约束条件
        {

        }

        static void Main(string[] args)
        {
            //1.值类型
            Test1<int> t1 = new Test1<int>();     //给的约束条件为struct，也就是值类型，这里的int也是值类型所以可以
            //Test1<string> t1 = new Test1<string>();  //给string类型就会报错


            //3.存在无参公共构造函数
            Test3<T3> t3 = new Test3<T3>();   //因为用where T:new();约束泛型，所以T必须是带无参构造的类，也就是T3
            //Test3<T3_1> t31 = new Test3<T3_1>();  //换成类T3_1就不行，因为T3_1的无参构造被覆盖
            Test3<T3_2> t32 = new Test3<T3_2>();  //类T3_2中显式的重写了public的无参构造，所以也可以
            Test3<int> t33 = new Test3<int>();   //值类型也可以传
            //Test3<string> t34 = new Test3<string>();  //引用类型不可以
            Test3<Student> t35 = new Test3<Student>(); //结构体可以传，因为结构体默认是有无参构造的

            //4.某个类本身或者其派生类 


            ////6.另一个泛型本身或者派生类型  
            //要求泛型T是另一个泛型例如U的同类型泛型，或者是泛型U派生的类型。where T:U
            //例如U是一个接口，T也是一个接口，那么可以。或者T是继承了接口U的一个类，那么也满足约束


        }


    }
}
