using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class Gold : ICreaditCard
    {
        public int GetAnnualCharge()
        {
            throw new NotImplementedException();
        }

        public string GetCardType()
        {
            throw new NotImplementedException();
        }

        public int GetCreditLimit()
        {
            throw new NotImplementedException();
        }
    }
}
