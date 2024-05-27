namespace DesignPatterns.Creational.Builder
{
    public static class BuilderExample
    {

        public static void Run()
        {           
            var builder = new CarBuilder();
            Director.ConstructSportsCar(builder);
            var car = builder.GetProduct();

            var carManualBuilder = new CarManualBuilder();
            Director.ConstructSportsCar(carManualBuilder);
            var manual = builder.GetProduct();
        }
    }
}
