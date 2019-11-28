using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public abstract class CreaditCardFactory
    {
        protected abstract ICreaditCard MakeProduct();
        public ICreaditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
