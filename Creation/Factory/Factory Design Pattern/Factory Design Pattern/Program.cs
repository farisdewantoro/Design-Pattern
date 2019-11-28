using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            ICreaditCard creditPlatinum = new PlatinumFactory().CreateProduct();
            Console.WriteLine(creditPlatinum.GetCreditLimit());
            Console.WriteLine(creditPlatinum.GetCardType());


            ICreaditCard creditTitanium = new TitaniumFactory().CreateProduct();
            Console.WriteLine(creditTitanium.GetCreditLimit());
            Console.WriteLine(creditTitanium.GetCardType());


            ICreaditCard creditGold = new GoldFactory().CreateProduct();
            Console.WriteLine(creditGold.GetCreditLimit());
            Console.WriteLine(creditGold.GetCardType());

         
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
