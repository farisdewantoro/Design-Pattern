using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class PlatinumFactory : CreaditCardFactory
    {
        protected override ICreaditCard MakeProduct()
        {
            ICreaditCard product = new Platinum();
            return product;
        }
    }
}
