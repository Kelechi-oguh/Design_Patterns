using Design_Patterns.BuilderPattern;
using Design_Patterns.FactoryPattern;

namespace Design_Patterns;

class Program
{
    public static void Main(string[] args)
    {
        // Factory pattern demo
        Console.WriteLine("Factory pattern demo\n");
        ShapeFactory shapeFactory = new ShapeFactory();

        IShape shape1 = shapeFactory.GetShape("circle");
        shape1.draw();

        IShape shape2 = shapeFactory.GetShape("rectangle");
        shape2.draw();

        IShape shape3 = shapeFactory.GetShape("square");
        shape3.draw();


        // Builder pattern demo

        // Step 7: BuilderPatternDemo uses MealBuilder to demonstrate the builder pattern.

        Console.WriteLine("\n\nBuilder pattern demo\n");
        MealBuilder mealBuilder = new MealBuilder();

        Meal vegMeal = mealBuilder.PrepareVegMeal();
        Console.WriteLine("Veg Meal");
        vegMeal.ShowItems();
        Console.WriteLine("Total Cost: " + vegMeal.GetCost());

        Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
        Console.WriteLine("\n\nNon-Veg Meal");
        nonVegMeal.ShowItems();
        Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
    }
}