using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封方法
{
    //用sealed修饰的方法不可以再被继承重写
    //一般和override一起出现
    class Father
    {
       public virtual void Walk()
        {

        }
        
    }

    class Son:Father
    {
        public override sealed void Walk()
        {
            base.Walk();
        }
    }

    class GrandSon : Son
    {
        //这里就无法再对继承的walk方法重写
        //public override void Walk()
        //{
        //    base.Walk();
        //}
    }

    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
