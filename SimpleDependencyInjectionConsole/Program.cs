using System;
using Ninject;

namespace SimpleDependencyInjectionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceLocator.Register<IMessageValidator>(new SimpleMessageValidator());
            //ServiceLocator.Register<IMessageWriter>(new ConsoleMessageWriter());

            try
            {
                var kernel = new StandardKernel(new PrimaryModule());
                
                //Constructor Injection======================================================
                //var handler = new MessageHandler(new SimpleMessageValidator(), new ConsoleMessageWriter());
                var handler = kernel.Get<MessageHandler>();

                handler.Process("Hello CraftyCoders!");

                //Method Injection===========================================================
                var basket = new ShoppingBasket { ShippingMethod = ShippingMethod.Express };

                var checkout = kernel.Get<Checkout>();

                var shippingCost = checkout.CalculateShippingCost(basket);

                Console.WriteLine("Shipping cost = {0:C2}", shippingCost / 100);

                //Constructor Argument=======================================================
                //var repo = kernel.Get<ICustomerRepository>();

                //var customers = repo.GetAll();

                //foreach (var customer in customers)
                //    Console.WriteLine("{0}: {1} [{2}]", customer.CustomerId, customer.CompanyName, customer.Country);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
