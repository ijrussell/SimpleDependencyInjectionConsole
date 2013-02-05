using Ninject.Modules;

namespace SimpleDependencyInjectionConsole
{
    public class PrimaryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageValidator>().To<SimpleMessageValidator>();
            Bind<IMessageWriter>().To<ConsoleMessageWriter>().WhenInjectedInto<LoggingMessageWriter>();
            Bind<IMessageWriter>().To<LoggingMessageWriter>();
            Bind<ILogger>().To<ConsoleLogger>().InSingletonScope();

            Bind<IShippingCostCalculatorFactory>().To<ShippingCostCalculatorFactory>();
            Bind<IShippingCostCalculator>().To<StandardShippingCalculator>();
            Bind<IShippingCostCalculator>().To<PriceSaverShippingCalculator>().Named("PriceSaver");
            Bind<IShippingCostCalculator>().To<ExpressShippingCalculator>();

            Bind<ICustomerRepository>().To<CustomerRepository>().WithConstructorArgument("connection", @"Server=.\SQL2008R2;Database=Northwind;Trusted_Connection=True;");
        }
    }
}