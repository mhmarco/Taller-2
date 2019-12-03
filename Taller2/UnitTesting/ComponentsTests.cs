using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taller2.Components.Kits;
using Taller2.ProductsFactory;

namespace UnitTesting
{
    [TestClass]
    public class ComponentsTests
    {
        [TestMethod]
        public void Create_NewCombo_AddNewComponent_Success()
        {
            // arrange
            var kit = new Kit_1();
            var component = ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.BATTERY);
            double expectedPrice = 11250;

            // action
            kit.Add(component);
            var result = kit.GetPrice();

            // result
            Assert.AreEqual(result, expectedPrice);
        }
    }
}
