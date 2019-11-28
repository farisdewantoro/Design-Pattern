using Abstract_Factory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }

    }
}
