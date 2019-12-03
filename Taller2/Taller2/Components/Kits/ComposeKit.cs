using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components.Kits
{
    /// <summary>
    /// Kit of kits.
    /// </summary>
    /// 
    /// @Author Jose Ulloa
    /// @Author Marco Morales
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
