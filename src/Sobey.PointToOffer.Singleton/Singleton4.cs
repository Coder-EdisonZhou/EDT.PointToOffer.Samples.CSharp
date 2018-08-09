using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    public sealed class Singleton4
    {
        private Singleton4() { }
        // 在大多数情况下，静态初始化是在.NET中实现Singleton的首选方法。
        static Singleton4() { }

        private static readonly Singleton4 instance = new Singleton4();

        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }

        public string SayHello(string name)
        {
            return string.Format("Hello {0}", name);
        }
    }
}
