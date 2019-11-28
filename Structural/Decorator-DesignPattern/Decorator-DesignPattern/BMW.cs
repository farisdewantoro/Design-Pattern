using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPattern
{
    public class BMW : ICar
    {
        public double Price()
        {
            return 100000;
        }
        public void ShowBasicDetails()
        {
            Console.WriteLine("Name : " + "BMW");
            Console.WriteLine("Model No : " + "BMW-1234");
        }
    }

}
