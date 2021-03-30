using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    //C#中的继承是单根的，也就是不能多继承
    //具有传递性，可以继承多代
    //可以在子类中声明和父类相同的成员，但是不建议使用

    //protected对继承这个方法很有用，因为private是只能自己访问的，public是谁都可以访问，protected则继承类中能用但外部不能访问

    //基类的protected的成员方法只能在子类中被访问，在Main函数中无法通过子类对象或者基类对象访问
    public class Teacher
    {
        
        protected string name; //默认为private
        protected int age;
        protected void SelfIntroduce()
        {
            //name = "TTLL";
            Console.WriteLine("我是" + name);
        }

    }

    class TeachingTeacher : Teacher
    {
        protected string subject;
        protected void NameSubject()
        {
            Console.WriteLine("我教的是" + subject);
        }

    }

    class MathTeacher : TeachingTeacher
    {

        public MathTeacher(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.subject = "math";
        }
        public void TeachingMath()
        {
            Console.WriteLine("我在教数学");
        }
    }


    class Program
    {


        static void Main(string[] args)
        {
            MathTeacher t1 = new MathTeacher("小谭", 22);
            //t1.NameSubject();
            //t1.SelfIntroduce();
            
        }
    }
}
