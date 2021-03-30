using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类和抽象方法
{
    //抽象类abstract不可以被实例化
    //抽象类可以包含抽象方法
    //继承抽象类之后必须重写其抽象方法（因为抽象方法里是没有具体操作的，只是一个方法）
    //抽象类也遵守里氏替换原则


    //抽象方法和虚方法的区别
    //1.抽象方法只能声明在抽象类里（虚方法也可以声明在抽象类里）
    //2.虚方法可以在声明的时候有函数主体，抽象方法不能有
    //3.虚方法可以在继承后不重写，抽象方法继承后必须重写
    //
    public abstract class People   
    {
        public abstract void speak();  //抽象函数无法声明主体，也就是函数里是不能有操作的，只是占一个位置
                                       //抽象函数又叫纯虚函数

    }

    public class Father:People
    {
        public override void speak()  //必须用override重写speak
        {
            Console.WriteLine("I am Father");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
