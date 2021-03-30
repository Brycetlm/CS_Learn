using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{

    //多态可以体现在函数重载（编译时的多态）、继承
    //virtual修饰的函数写在父类中，可以在子类中用override进行重写

    //由一个问题引入：
    class Father
    {
        public void speak()
        {
            Console.WriteLine("Father");
        }

        public virtual void eat()
        {
            Console.WriteLine("Father is eating");
        }

        public void walk()
        {
            Console.WriteLine("Father is walking");
        }
    }

    class Son : Father
    {
        public new void speak()
        {
            Console.WriteLine("Son");
        }

        public override void eat() ////这里重写，如果想访问父类的某个函数，可以用base方法
        {
            base.walk();
            Console.WriteLine("Son is eating");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //这里采用了里氏替换，用父类装载子类对象，但是这样调用speak时是父类的
            Father a = new Son();
            a.speak();

            //如果想要调用子类son的speak
            (a as Son).speak();

            //那么子类想要用自己的函数时可以将父类中的成员函数声明为virtual，然后在子类中重写，这样也可以实现多态
            Father b = new Son();
            b.eat();                //这里就直接调用的是Son的eat，因为在Son中被重写了

            
            


            //
            Console.ReadLine();

        }
    }
}
