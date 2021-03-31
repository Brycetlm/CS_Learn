using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特殊语法
{

    class Program
    {
        static void Main(string[] args)
        {
            #region var隐式类型
            //可以用来表示任何类型变量
            //但是不能作为类成员
            //一般写在函数语句块中
            //var必须初始化，初始化之后，失去可变的属性

            #endregion

            #region 设置对象初始值
            //申明对象时。可以通过大括号直接来初始化公共成员变量和属性
            //People p=new People(){sex="nan",age=1,name="ddd"};

            #endregion

            #region 设置集合初始值
            //声明集合时，也可以通过大括号初始化
            //例如数组，字典，之类的
            List<int> l = new List<int>() { 1, 2, 4, 8 };

            #endregion

            #region 匿名类型
            //var变量可以声明为自定义的匿名类型
            var v = new { age = 10, money = 11 };
            Console.WriteLine(v.age);

            #endregion

            #region 可空类型
            //值类型不能赋值为null
            int a = null; //报错
            //但是声明是在值类型后面加？可以赋值为空,其他值类型也可以
            int? b= null;
            //使用时判断是否为null
            b.HasValue;
            //安全获取可空类型值
            Console.WriteLine(b.GetValueOrDefault());

            //！！！！对于引用类型也能用，可以拿来进行安全访问
            object ob = null;
            ob.ToString();//ob是空，不能调用ToString方法，所以一般先判断是不是null
                          //但也可以这么写
            ob?.ToString();  //相当于语法糖，自动判断null

            #endregion

            #region 空合并操作符
            //两个？？
            //左边值??右边值
            //如果左边为null，就返回右边，否则返回左边，意思就是优先返回左边
            //只要是可以为null的类型都可以用
            string str = null;
            string s = str ?? "fghj";
            #endregion

            #region 内插字符串
            //用$来构造字符串，让字符串可以拼接变量
            string name = "dddd";
            Console.WriteLine($"Hass,{ name}");

            #endregion

            #region 单句逻辑简略写法
            //如果if语句后面只有一句代码，可以不带花括号
            if (true) Console.WriteLine();
            //get set里面也可
            //get=>"hhhh";
            //set=>name="sss";

            //或者其他一句代码的函数也可
            class hh
        {
            public int sum(int a, int b) => a + b;
        }

            #endregion

            
        }
    }
}
