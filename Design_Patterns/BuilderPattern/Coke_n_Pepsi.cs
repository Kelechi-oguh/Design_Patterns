using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    // Step 4: (Part 2) Create concrete classes extending ColdDrink class.

    public class Coke : ColdDrink
    {
        public override float Price()
        {
            return 30.0f;
        }

        public override string Name()
        {
            return "Coke";
        }
    }

    public class Pepsi : ColdDrink
    {
        public override float Price()
        {
            return 35.0f;
        }

        public override string Name()
        {
            return "Pepsi";
        }
    }
}
