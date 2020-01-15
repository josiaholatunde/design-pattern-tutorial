using static System.Console;

namespace DecoratorPatternLib
{
    public class RedShapeDecorator: ShapeDecorator
    {
        public RedShapeDecorator(Shape shape) : base(shape)
        {}

        public override void Draw() 
        {
            _shape.Draw();
            AddRedBorder();
        }

        public void AddRedBorder()
        {
            WriteLine("I can add a red border to this shape");
        }
    }
}