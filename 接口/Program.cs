using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    //接口是行为的抽象规范，关键字interface
    //接口是某一行为的基类，类是具体事物对象的抽象，而接口则是行为抽象，把某一行为抽象出来可以给多个类去动态的实现
    //是一种自定义类型

    //接口声明规范
    //不包含成员变量
    //只包含方法 属性 索引器 事件
    //成员不能被实现
    //成员可以不写访问修饰符，但不能是private的
    //接口不能继承类，但是能继承接口


    //使用规范
    //类可以继承多个接口，一个类
    //类继承接口后必须实现接口中所有成员，且必须是public
    //接口继承接口后不用实现，等类继承了接口才实现


    //特点
    //他和类的声明类似
    //接口是用来继承的
    //接口不能实例化，但是可以作为容器来存储对象

    
    


    //声明一个接口
    interface IFly
    {
        void Fly();    //方法

        string name    //属性
        {
            get;
            set;
        }

        int this[int index]   //索引器
        {
            get;
            set;
        }

        //event Action something;  //事件
    }


    interface ISlowFly
    {
        void Fly();
    }

    class Animals
    {

    }

    class People : Animals, IFly
    {
        public void Fly()       //实现这些接口时需要声明为public，还可以加上virtual让继承People的子类继续重写
        {

        }

        public string name
        {
            get;
            set;
        }

        public int this[int index]
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
    }


    //显示接口
    //当一个类继承了多个接口，但是接口中存在同名方法时，可以显示实现接口
    class Bird : IFly, ISlowFly
    {
        //public void Fly()  //这样写也是可以的，但是IFly和ISlowFly里的Fly可能是不一样的，这样写就丧失了两种行为的特点
        //{

        //}


        //可以用.来显式的表明是重写的哪个接口的方法
        //显示的重写了两个同名函数之后，在调用的时候要注意（见主函数eg）
        void IFly.Fly()
        {
            Console.WriteLine("我要飞");
        }

        void ISlowFly.Fly()
        {
            Console.WriteLine("我要慢慢飞");

        }

        public void Fly()     //同时类也可以写一个和继承的接口里面同名的函数，这时候可以通过类对象直接.访问
        {
            Console.WriteLine("我要自己飞");
        }



        public string name
        {
            get;
            set;
        }

        public int this[int index]
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

    }

    class Program
    {

        //调用显示重写的重名接口函数
        static void Main(string[] args)
        {
            Bird bi = new Bird();
            //Bird.Fly();   //这样调用会出错，因为并不知道调用是哪一个Fly

            //但因为接口继承也遵循里氏替换，即可以用继承的父接口来装载子类对象
            (bi as IFly).Fly();  //用继承的接口IFly转载子类对象bi
            (bi as ISlowFly).Fly();

            Console.ReadLine();

        }
    }
}
