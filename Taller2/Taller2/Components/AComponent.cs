using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
///
namespace Taller2.Components
{
    public abstract class AComponent
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double ExpectedRequiredtime { get; set; }
        private double Price;

        private List<AComponent> components = new List<AComponent>();

        public AComponent(double price)
        {
            Price = price;
        }

        public void Add(AComponent component)
        {
            components.Add(component);
        }
        public void Eliminar(AComponent component)
        {
            components.Remove(component);
        }
        public virtual double GetPrice()
        {
            foreach (var component in components)
                Price += component.GetPrice();

            return Price * 0.75;
        }
    }
}
