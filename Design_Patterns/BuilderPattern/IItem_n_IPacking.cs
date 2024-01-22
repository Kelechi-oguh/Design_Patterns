using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    // Step 1: Create an interface Item representing a food item and packing.

    public interface IItem
    {
        string Name();
        public IPacking Packing();
        float Price();
    }

    public interface IPacking
    {
        string Pack();
    }
}
