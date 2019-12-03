using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Components;
using Taller2.Components.Kits;
using Taller2.ProductsFactory;

namespace Taller2
{
    /// <summary>
    /// Start point of the program.
    /// </summary>
    /// 
    /// @Author Jose Ulloa
    /// @Author Marco Morales
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("REPARACIONES J&M");
            Console.WriteLine("===========================================\n");
            Console.WriteLine("Bienvenido Usuario!");

            AComponent kit_1 = new Kit_1();
            Console.WriteLine($"Le ofrecemos el siguiente kit: {kit_1.Name}");
            Console.WriteLine($"Precio: {kit_1.GetPrice()}");

            AComponent component_1 = ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.SPEAKER);
            Console.WriteLine($"Al agregarle {component_1.Name} con un valor de: {component_1.GetPrice()}");

            kit_1.Add(component_1);
            Console.WriteLine($"Al combo el precio final sería: {kit_1.GetPrice()}");
            Console.Read();
        }
    }
}
