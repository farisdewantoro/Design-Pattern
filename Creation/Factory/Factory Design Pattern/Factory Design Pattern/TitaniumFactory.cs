using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class TitaniumFactory : CreaditCardFactory
    {
        protected override ICreaditCard MakeProduct()
        {
            ICreaditCard product = new Titanium();
            return product;
        }
    }
}
