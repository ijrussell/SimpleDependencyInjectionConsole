using System.Collections.Generic;
using System.Linq;

namespace SimpleDependencyInjectionConsole
{
    public class ShippingCostCalculatorFactory
    {
        private readonly IEnumerable<IShippingCostCalculator> _calculators;

        public ShippingCostCalculatorFactory(IEnumerable<IShippingCostCalculator> calculators)
        {
            _calculators = calculators;
        }

        public IShippingCostCalculator GetCalculator(ShippingMethod shippingMethod)
        {
            //switch (shippingMethod)
            //{
            //    case ShippingMethod.Express:
            //        return new ExpressShippingCalculator();
            //    case ShippingMethod.PriceSaver:
            //        return new PriceSaverShippingCalculator();
            //    case ShippingMethod.Standard:
            //    default:
            //        return new StandardShippingCalculator();
            //}

            return (from c in _calculators
                    let handles = c as IHandleShippingMethod
                    where handles != null
                    && handles.CanHandle(shippingMethod)
                    select c).First();

            //return (from c in this.candidates
            //        let t = c.GetType()
            //        where t.Name.StartsWith(shippingMethod.ToString())
            //        select c).First();
        }
    }
}