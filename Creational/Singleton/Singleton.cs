namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton
    {
        public int SingleTonVariable { get; set; }

        private static Singleton _instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }
}