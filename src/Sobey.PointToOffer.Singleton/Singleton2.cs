using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    public sealed class Singleton2
    {
        private Singleton2() { }

        private static readonly object syncObject = new object();

        private static Singleton2 instance = null;

        public static Singleton2 Instance
        {
            get
            {
                // 每个线程来之前先等待锁
                lock(syncObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                }

                return instance;
            }
        }
    }
}
