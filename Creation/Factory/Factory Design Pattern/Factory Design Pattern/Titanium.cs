using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class Titanium : ICreaditCard
    {
        public string GetCardType()
        {
            return "Titanium Plus";
        }
        public int GetCreditLimit()
        {
            return 325000;
        }
        public int GetAnnualCharge()
        {
            return 22000;

        }
    }
}
