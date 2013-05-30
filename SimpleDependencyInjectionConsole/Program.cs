using System;
using System.Collections.Generic;
using Ninject;

namespace SimpleDependencyInjectionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceLocator.Register<IMessageValidator>(new SimpleMessageValidator());
            //ServiceLocator.Register<IMessageWriter>(new ConsoleMessageWriter());
            
            //var kernel = new StandardKernel(new PrimaryModule());

            try
            {

                //Constructor Injection======================================================
                //var handler = ObjectFactory.CreateMessageHandler();
                //var handler = kernel.Get<MessageHandler>();

                var handler = new MessageHandler();

                handler.Process("Hello Progressive.Net Tutorials 2013!");

                //kernel.Release(handler);


                //Method Injection===========================================================
                //var basket = new ShoppingBasket
                //{
                //    ShippingMethod = ShippingMethod.Express
                //};

                //var checkout = new Checkout(new ShippingCostCalculatorFactory(new List<IShippingCostCalculator>
                //{
                //    new ExpressShippingCalculator(),
                //    new PriceSaverShippingCalculator(),
                //    new StandardShippingCalculator()
                //}));
                //var checkout = kernel.Get<Checkout>();

                //var shippingCost = checkout.CalculateShippingCost(basket);

                //Console.WriteLine("Shipping cost = {0:C2}", shippingCost);

                //kernel.Release(checkout);

                //Constructor Argument=======================================================
                //var repository = kernel.Get<ICustomerRepository>();

                //var customers = repository.GetAll();

                //foreach (var customer in customers)
                //    Console.WriteLine("{0}: {1} [{2}]", customer.CustomerId, customer.CompanyName, customer.Country);

                //var selectedCustomer = repository.GetCustomer("QUICK");

                //Console.WriteLine("{0}: {1} [{2}]", selectedCustomer.CustomerId, selectedCustomer.CompanyName, selectedCustomer.Country);

                //kernel.Release(repository);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //kernel.Dispose();
            }

            Console.ReadLine();
        }
    }
}
