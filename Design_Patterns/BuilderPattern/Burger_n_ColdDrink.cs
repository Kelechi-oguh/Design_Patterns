using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    // Step 3: Create abstract classes implementing the item interface providing default functionalities.

    public abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }

    public abstract class ColdDrink : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}
