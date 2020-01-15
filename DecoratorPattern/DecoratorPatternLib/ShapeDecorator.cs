namespace DecoratorPatternLib
{
    public abstract class ShapeDecorator: Shape
    {
        protected readonly Shape _shape;
        public ShapeDecorator(Shape shape)
        {
            _shape = shape;
        }

        public virtual void Draw()
        {
            _shape.Draw();
        }
    }
}