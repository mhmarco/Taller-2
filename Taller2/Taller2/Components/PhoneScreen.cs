using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    public class PhoneScreen : AComponent
    {
        public PhoneScreen(double price) : base(price)
        {
            Number = 101;
            Name = "Phone Screen";
            ExpectedRequiredtime = 3;

        }
    }
}
