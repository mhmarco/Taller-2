using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Components;

namespace Taller2.ProductsFactory
{
    public class ProductsConcreteFactory : IFactory
    {
        private static ProductsConcreteFactory _instance;

        public int SpeakerPrice { get; set; }
        public int GraphicCardPrice { get; set; }
        public int PhoneCameraPrice { get; set; }
        public int PhoneScreenPrice { get; set; }
        public int BatteryPrice { get; set; }

        public static ProductsConcreteFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ProductsConcreteFactory();
                }

                return _instance;
            }
        }

        private ProductsConcreteFactory()
        {
            SpeakerPrice = 7500;
            GraphicCardPrice = 54000;
            PhoneCameraPrice = 15000;
            PhoneScreenPrice = 56000;
            BatteryPrice = 23000;
        }

        public AComponent CreateComponent(EnumComponents component)
        {
            switch(component)
            {
                case EnumComponents.SPEAKER:
                    return new Speaker(SpeakerPrice);

                case EnumComponents.GRAPHIC_CARD:
                    return new Speaker(GraphicCardPrice);

                case EnumComponents.PHONE_CAMERA:
                    return new Speaker(PhoneCameraPrice);

                case EnumComponents.PHONE_SCREEN:
                    return new Speaker(PhoneScreenPrice);

                case EnumComponents.BATTERY:
                    return new Speaker(BatteryPrice);

                default:
                    throw new Exception("El componente no existe");
                    
            }
        }
    }
}
