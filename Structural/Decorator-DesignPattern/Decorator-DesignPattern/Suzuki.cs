using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPattern
{
    public class Suzuki : ICar
    {
        public double Price()
        {
            return 300000;
        }
        public void ShowBasicDetails()
        {
            Console.WriteLine("Name : " + "Suzuki");
            Console.WriteLine("Model No : " + "Suzuki-6789");
        }
    }

}
