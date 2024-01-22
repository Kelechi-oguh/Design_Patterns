using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == "circle")
                return new Circle();

            else if (shapeType == "rectangle")
                return new Rectangle();

            else if (shapeType == "square")
                return new Square();

            else
                return null;
        }
    }
}
