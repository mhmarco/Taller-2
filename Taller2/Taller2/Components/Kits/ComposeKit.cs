using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components.Kits
{
    public class ComposeKit : BaseKit
    {
        public ComposeKit(List<BaseKit> kits)
        {
            Name = "Super mega kit";

            foreach (var item in kits)
            {
                Add(item);
            }
            
        }
    }
}
