using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
    //Facade 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started....");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully....");
        }
    }
    //Sub System 1
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details...");
        }
    }
    //Sub System 2
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully...");
        }
    }
    //Sub System 3
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully...");
        }
    }

}
