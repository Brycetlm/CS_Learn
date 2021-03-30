using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏替换原则
{
    //用父类容器装子类对象
    //方便对象管理
    //例如所有的npc都可以是一个object，然后在使用的时候才转换为相应的npc

    //使用is和as进行判断和转换,as可以转换对象成为其该有的类型

    class NpcObject
    {

    }

    class Monster : NpcObject
    {

    }

    class Boss : NpcObject
    {

    }

  
    class Program
    {


        static void Main(string[] args)
        {

            NpcObject boss1 = new Boss();
            NpcObject monster1 = new Monster();
            NpcObject boos2 = new NpcObject();

            Console.WriteLine(boss1 is Boss); //T
            Console.WriteLine(monster1 is Boss);  //F
            Console.WriteLine(boss1 is NpcObject); //T

            boos2 = boos2 as Boss; //将一个大类NpcObject转变为Boss类
            monster1 = boos2 as Boss;  //也可以将原来的monster类转变为同样是NpcObject基类的Boss类



            Console.ReadLine();


        }
    }
}
