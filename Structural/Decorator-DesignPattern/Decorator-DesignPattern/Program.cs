using System;

namespace Decorator_DesignPattern
{
    class Program
    {
        static void Main()
        {
            ICar bmwCar = new BMW();
            bmwCar.ShowBasicDetails();
            DiscountedDecorator decorator1 = new DiscountedDecorator(bmwCar);
            decorator1.DiscountedPrice();
            ICar suzukiCar = new Suzuki();
            suzukiCar.ShowBasicDetails();
            DiscountedDecorator decorator2 = new DiscountedDecorator(suzukiCar);
            decorator2.DiscountedPrice();
            Console.Read();
        }
    }

}
