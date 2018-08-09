using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    public sealed class Singleton1
    {
        private Singleton1() { }

        private static Singleton1 instance = null;

        public static Singleton1 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton1();
                }

                return instance;
            }
        }
    }
}
