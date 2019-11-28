using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPattern
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar _car)
        {
            car = _car;
        }
        public double Price()
        {
            return car.Price();
        }
        public void ShowBasicDetails()
        {
            car.ShowBasicDetails();
        }
    }
    

}
