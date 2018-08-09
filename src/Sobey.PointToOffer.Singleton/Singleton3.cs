using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    public sealed class Singleton3
    {
        private Singleton3() { }

        private static readonly object syncObject = new object();

        private static Singleton3 instance = null;

        public static Singleton3 Instance
        {
            get
            {
                // Double-Check 双重判断避免不必要的加锁
                if (instance == null)
                {
                    // 确定实例为空时再等待加锁
                    lock (syncObject)
                    {
                        // 确定加锁后实例仍然未创建
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
