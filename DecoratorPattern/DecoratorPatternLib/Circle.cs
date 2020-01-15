using static System.Console;

namespace DecoratorPatternLib
{
    public class Circle : Shape
    {
        public void Draw()
        {
            WriteLine("I can draw a Circle");
        }
    }

}