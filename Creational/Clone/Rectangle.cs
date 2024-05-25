namespace DesignPatterns.Creational.Clone
{
    internal class Rectangle : Shape
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public Rectangle() { }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
