namespace DesignPatterns.Creational.Clone
{
    public class Circle : Shape
    {

        public int Radius { get; set; }

        public Circle(Circle source) : base(source)
        {
            Radius = source.Radius;
        }

        public Circle() { }


        public override Shape Clone()
        {
           return new Circle(this);
        }
    }
}
