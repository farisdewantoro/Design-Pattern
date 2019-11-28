using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    public sealed class Singleton
    {
        private static  Singleton _Singleton;
        private static int counter = 0;
        private static readonly object obj = new object();
        public static Singleton GetInstance()
        {
            if(_Singleton == null)
            {
                lock (obj)
                {

                    if (_Singleton == null)
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }
        private Singleton()
        {
            counter++;
        }
    
        public void PrintDetail()
        {
            Console.WriteLine("This is "+counter);
        }
    }
}
