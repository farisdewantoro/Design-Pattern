using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class GoldFactory : CreaditCardFactory
    {
        protected override ICreaditCard MakeProduct()
        {
            ICreaditCard product = new Gold();
            return product;
        }
    }
}
