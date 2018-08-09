using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    public sealed class Singleton5
    {
        private Singleton5() { }

        public static Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        // 使用内部类+静态构造函数实现延迟初始化
        class Nested
        {
            static Nested() { }

            internal static readonly Singleton5 instance = new Singleton5();
        }

        public string SayHello(string name)
        {
            return string.Format("Hello {0}", name);
        }
    }
}
