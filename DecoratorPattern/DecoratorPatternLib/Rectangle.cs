using static System.Console;

namespace DecoratorPatternLib
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            WriteLine("I can draw a Rectangle");
        }
    }

}