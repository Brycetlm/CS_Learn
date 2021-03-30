using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//使用TestSpace空间的声明
using TestSpace;
using Game;

namespace TestSpace
{
    //基本概念
    //用来组织和重用代码的
    //命名空间就像是一个工具包，各个类就是工具

    //命名空间可以分开写，分开写的时候可以用其他相同空间内的类
    //不同namespace可以用相同名的类

    //回顾：class 前面可以加的关键字
    //public——namespace中默认为public
    //internal——只能在该程序集中使用
    //abstract ——抽象类
    //sealed——密封类
    //partial——分部类


    class People
    {

    }

    class Program
    {
        
        static void Main(string[] args)
        {
        }
    }

    
}

namespace TestSpace
{

    class WhitePeople : People       //这的namespace分开写，但是可以引用其他地方的People类
    {

    }

}

//在命名空间中引用其他命名空间的内容，要在文件开头用using声明

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WhitePeople p = new WhitePeople();   //引用了TestSpace里的WhitePeople
            //或者使用.
            TestSpace.WhitePeople pp = new TestSpace.WhitePeople();

            //使用包裹的namespace里的class
            //如下namespace Game，里面有namespace Npc，要直接使用Npc时必须要using Game.Npc，只Using Game不行，就要用.表明引用路径
            //Boss bb = new Boss();  //不能用
            Game.Npc.Boss b = new Game.Npc.Boss();

        }
    }
}


//命名空间里可以包裹命名空间
namespace Game
{
    namespace Npc
    {
        class Boss
        {

        }
    }
}
