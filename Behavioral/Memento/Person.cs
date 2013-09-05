namespace DesignPatterns.Behavioral.Memento
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }

        public Memento CreateMemento()
        {
            return new Memento
            {
                FirstName = FirstName,
                LastName = LastName,
                Height = Height
            };
        }

        public void RestoreFromMemento(Memento memento)
        {
            FirstName = memento.FirstName;
            LastName = memento.LastName;
            Height = memento.Height;
        }
    }
}