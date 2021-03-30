using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万物之父object和拆箱装箱
{

    //里氏替换原则提到可以用父类装载子类对象，然后可以用is as进行判断和转换
    //有一个类Object可以装载所有对象，即它是所有类的基类
    //所以可以用Object装载这些对象，再进行判断和转换
    //Object既可以装载引用类型的对象，也可以装载值类型的对象，需要时就按照类型转换规则进行转换


    //《值类型》之间用object进行转换被称为装箱拆箱，用Object装值类型就是装箱
    //装箱就是把值类型用引用类型来存储，栈内存迁移到堆内存中

    //这样做的好处就是当类型不确定是方便参数的存储和传递，例如我写一个函数，目前不知道参数是什么类型，可以用object转换
    //坏处就是增加了内存迁移，性能有所消耗

    class Program
    {
        class Father
        {

        }

        class Son : Father
        {
            public string str;
            public Son(string str)
            {
                this.str = str;
            }
        }


        static void Main(string[] args)
        {

            
            Object IntValue=1;
            Object str = "123";


            //Object son = new Son(str); //这里的构造函数要求string类型，没转换之前str是Object类，所以报错
            string str1 = str.ToString();//这里也可以as，str1=str as string;
            Object son = new Son(str1);  //转换之后使用，且不可以重名

            Object arr = new int[10];
            //int[] ar = arr as int[];
            int[] ar = (int[])arr;


            void speak(Object a)
            {
                Console.WriteLine(a.ToString());
            }

            speak("123");
            speak(111);     
            speak(45.63);//这里的speak函数既可以用string类也可以用int类，也可以用float类

            Console.ReadLine();
        }
    }
}
