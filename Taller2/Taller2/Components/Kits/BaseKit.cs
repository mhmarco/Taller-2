using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components.Kits
{
    /// <summary>
    /// Simple kit class
    /// </summary>
    /// 
    /// @Author Jose Ulloa
    /// @Author Marco Morales
    public class BaseKit : AComponent
    {
        public BaseKit() : base(0)
        {
        }

        public override double GetPrice()
        {
            double currentPrice = Price;
            foreach (var component in components)
                currentPrice += component.GetPrice();

            return currentPrice * 0.75;
        }
    }
}
