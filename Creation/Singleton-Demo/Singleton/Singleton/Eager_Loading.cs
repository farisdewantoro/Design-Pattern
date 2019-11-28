using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Eager_Loading
    {
        private static int counter = 0;
        private Eager_Loading()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Eager_Loading singleInstance = new Eager_Loading();

        public static Eager_Loading GetInstance
        {
            get
            {
                return singleInstance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
