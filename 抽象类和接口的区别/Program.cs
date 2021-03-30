using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类和接口的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //相同点
            //1.都可以被继承
            //2.都不能直接实例化
            //3.子类必须实现未实现的方法
            //4.都遵循里氏替换原则


            //不同点
            //1.抽象类中可以用构造函数，接口中没有
            //2.c#抽象类只能单根继承，接口则可以继承多个
            //3.抽象类中可以有成员变量，接口不行
            //4.抽象类中可以声明成员方法，虚方法，抽象方法；接口中只能申明没有实现的抽象方法
            //5.抽象类可以用访问修饰符；接口中建议不写，默认public


            //表示对象的用抽象类，表示行为规范的用接口

        }
    }
}
