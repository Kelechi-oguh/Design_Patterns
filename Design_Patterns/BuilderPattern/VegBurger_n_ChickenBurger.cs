using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    // Step 4: (Part 1) Create concrete classes extending Burger class.

    public class VegBurger : Burger
    {
        public override float Price()
        {
            return 25.0f;
        }

        public override string Name()
        {
            return "Veg Burger";
        }
    }

    public class ChickenBurger : Burger
    {
        public override float Price()
        {
            return 50.5f;
        }

        public override string Name()
        {
            return "Chicken Burger";
        }
    }
}
