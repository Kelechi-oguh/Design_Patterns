using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    // Step 2: Create concrete classes implementing the Packing interface.

    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }

    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
