using System;
using DecoratorPatternLib;

namespace DecoratorDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();

            RedShapeDecorator redShapeCircle = new RedShapeDecorator(circle);

            //Print a circle with normal border
            circle.Draw();
            //Print a circle with an additional red border
            redShapeCircle.Draw();


            Shape rectangle = new Rectangle();
            RedShapeDecorator redShapedRectangle = new RedShapeDecorator(rectangle);
            

            //Print a rectangle wth normal border
            rectangle.Draw();

            //Print a rectangle with an additional red border
            redShapedRectangle.Draw();
        }
    }
}
