using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton4.Instance.SayHello("Edison Chou");
            Singleton5.Instance.SayHello("Edison Chou");

            Console.ReadKey();
        }
    }
}
