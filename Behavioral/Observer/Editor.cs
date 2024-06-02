namespace DesignPatterns.Behavioral.Observer
{
    public class Editor
    {

        public EventManager EventManager { get; set; }
        public Editor() => EventManager = new EventManager();

        public void OpenFile(string file)
        {
            // Open the file

            // Raise the file open event            
            EventManager.Notify(new Event()
            {
                EventType = EventType.OpenFile,
                Data = file
            });
        }

        public void SaveFile(string file)
        {
            // Save the file

            // Raise the save event
            EventManager.Notify(new Event()
            {
                EventType = EventType.SaveFile,
                Data = file
            });
        }
    }
}