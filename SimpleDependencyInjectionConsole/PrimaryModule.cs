using System.Configuration;
using Ninject.Modules;

namespace SimpleDependencyInjectionConsole
{
    public class PrimaryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageWriter>().To<LoggingMessageWriter>().WhenInjectedInto<MessageHandler>();
            Bind<IMessageWriter>().To<UltimateMessageWriter>();
            Bind<ILogger>().To<ConsoleLogger>().InSingletonScope();
            Bind<IShippingCostCalculator>().To<StandardShippingCalculator>();
            Bind<IShippingCostCalculator>().To<PriceSaverShippingCalculator>();
            Bind<IShippingCostCalculator>().To<ExpressShippingCalculator>();

            var connString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            Bind<ICustomerRepository>().To<CustomerRepository>().WithConstructorArgument("connection", connString);
        }
    }
}