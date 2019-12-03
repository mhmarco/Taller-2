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

            BaseKit kit_1 = new Kit_1();
            Console.WriteLine($"Le ofrecemos el siguiente kit: {kit_1.Name}");
            Console.WriteLine($"Precio: {kit_1.GetPrice()}\n");

            AComponent component_1 = ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.SPEAKER);
            Console.Write($"Al agregarle {component_1.Name} con un valor de: {component_1.GetPrice()}");

            kit_1.Add(component_1);
            Console.Write($" al combo el precio final sería: {kit_1.GetPrice()}\n\n");


            BaseKit kit_2 = new Kit_2();
            Console.WriteLine($"Tambien tenemos el {kit_2.Name} a un valor de: {kit_2.GetPrice()}\n");

            kit_1 = new Kit_1();
            
            Console.WriteLine($"Ofrecemos us super mega combo de {kit_1.Name} y {kit_2.Name} a un valor de: ");

            List<BaseKit> kits = new List<BaseKit>();
            kits.Add(kit_1);
            kits.Add(kit_2);
            ComposeKit mega_kit = new ComposeKit(kits);
            Console.Write(mega_kit.GetPrice() + "\n\n");

            AComponent component_2 = ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.SPEAKER);
            Console.WriteLine($"Como información adicional el {component_2} requiere un total de {component_2.ExpectedRequiredtime} horas necesarias para trabajarlo.");
            Console.Read();
        }
    }
}
