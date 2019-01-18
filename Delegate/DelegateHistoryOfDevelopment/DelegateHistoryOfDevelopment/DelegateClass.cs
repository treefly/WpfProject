using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHistoryOfDevelopment
{
    public class DelegateClass
    {

        public delegate int AddDelegate(int numA,int numB);
        public DelegateClass()
        {
            //版本1
            AddDelegate addDelegate = new AddDelegate(Add);
            int c = addDelegate(10,20);

            //匿名方法
            AddDelegate addTwo = new AddDelegate(delegate(int a, int b) { return a + b;});

            //不定义委托用Func和Action
            Func<int, int, int> func = new Func<int, int, int>(delegate(int a, int b) { return a + b; });

            //再次省些一下
            Func<int, int, int> func2 = delegate(int a, int b) { return a + b; };

            //匿名方法进化为lambda表达式
            AddDelegate lambda = new AddDelegate((int a, int b) => a + b);
            AddDelegate lambda2 = new AddDelegate((a, b) => a + b);
        }

        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
