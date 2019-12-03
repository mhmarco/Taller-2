using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    /// <summary>
    /// Phone Camera component
    /// </summary>
    /// 
    /// @Author Marco Morales
    class PhoneCamera : AComponent
    {
        public PhoneCamera(double price) : base(price)
        {
            Number = 105;
            Name = "Cámara de teléfono";
            ExpectedRequiredtime = 4;

        }
    }
}