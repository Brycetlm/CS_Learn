using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逆变和协变
{
    //协变：
    //和谐自然的变化
    //因为 里氏替换 父类可以装子类
    //所以子类变夫类
    //比如string变为object
    //感觉是和谐的

    //逆变：
    //逆常规的变化，是不和谐的
    //因为 里氏替换原则 父类可以转子类但是子类不能装父类
    //所以父类变子类
    //例如object变string是不和谐的


    //协变和逆变用来修饰泛型
    //协变out
    //逆变in
    //用于在泛型中修饰泛型字母
    //只有《泛型接口》和《泛型委托》能用
    //例如在class中使用就会报错


    //《作用》
    //1.返回值和参数
    //用out修饰的泛型，只能作为返回值
    //delegate T TestOut<out T>(T a);  //这里因为用out修饰了T，所以T只能作为返回值类型，不能作为参数类型
    //用in修饰的泛型，只能作为参数
    //delegate T TestOut<in T>(T a);   //这样就不行

     //2.结合里氏替换原则理解
     //用父类泛型容器装载子类泛型委托，协变
     //用子类泛型容器装载父类泛型委托，逆变
     class Father
    {
        public int a = 10;
        public int b = 20;
        public Father()
        {

        }
        public Father(int i)
        {
            this.a = i;
            this.b = i;
        }

        public void Walking()
        {
            Console.WriteLine("I'm walking");
        }

        public void Steps(int steps)
        {
            Console.WriteLine("我走了"+steps+"步");
        }

        public static void Run(int speed)
        {
            Console.WriteLine("我跑的速度是："+speed);
        }
    }

    class Son : Father
    {

    }

    delegate void TestIn<in T>(T t);
    delegate T TestOut<out T>();


    class Program
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            Console.WriteLine(f.a);
           //协变

            //逆变
            
        }
    }
}
