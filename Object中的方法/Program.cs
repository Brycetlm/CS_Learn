using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object中的方法
{

    class People
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Object中的static方法
            //1.Equals，判断两个对象是否相等
            //object不加也可用Equals函数，因为object是万物父类
            //
            string str1 = "1";
            string str2 = "1";
            People p1 = new People();
            People p2 = new People();
            Console.WriteLine(object.Equals(1, 1));   //T
            Console.WriteLine(object.Equals(str1, str2));  //T
            Console.WriteLine(object.Equals(p1, p2));  //F
            //静态方法ReferenceEquals
            //比较两个对象是否是相同的引用。主要是用来比较引用类型的对象。
            //值类型对象返回值始终为False
            Console.WriteLine(object.ReferenceEquals(1, 1));  //F


            //2.GetType
            //获得对象运行时的类型Type
            Type ty = p1.GetType();
            Console.WriteLine(ty);

            //3.MemberwiseClone
            //该方法用于获取对象的浅拷贝对象。
            //深浅拷贝：对于值类型，深浅拷贝都一样，但是对于引用类型，浅拷贝只拷贝引用，不新开辟空间，也就是引用值变化后相应的拷贝对象
            //也会变化，深拷贝则会新开辟空间，原对象变化后，拷贝对象不变。


            //4.虚方法Equals
            //每一个类都可以重写这个方法来定义自己的比较规则

            //5.虚方法GetHashCode
            //算出对象的唯一编码

            //6.虚方法ToString
            //返回当前对象代表的字符串，可以重定义自己的对象转字符串的规则
            //这个方法很常用
            Console.ReadLine();
        }
    }
}
