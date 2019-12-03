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
        protected double Price;

        protected List<AComponent> components = new List<AComponent>();

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
            return Price;
        }
    }
}
